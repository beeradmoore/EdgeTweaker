using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using EdgePolicyMarkdownParser;
using MarkdownSharp;

try
{
    var markdown = string.Empty;
    var markdownFile = "microsoft-edge-policies.md";
    using (var memoryStream = new MemoryStream())
    {
        var downloadFresh = true;
        if (File.Exists(markdownFile))
        {
            var fileInfo = new FileInfo(markdownFile);
            if ((DateTime.Now - fileInfo.LastWriteTime).Days > 7)
            {
                downloadFresh = true;
            }
            else
            {
                downloadFresh = false;
                using (var fileStream = File.OpenRead(markdownFile))
                {
                    await fileStream.CopyToAsync(memoryStream);
                }
            }
        }
        
        if (downloadFresh == true)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-policies.md");
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                await stream.CopyToAsync(memoryStream);
            }

            memoryStream.Position = 0;

            using (var fileStream = File.Create(markdownFile))
            {
                await memoryStream.CopyToAsync(fileStream);
            }
        }
        
        memoryStream.Position = 0;
        
        using (var reader = new StreamReader(memoryStream))
        {
            markdown = await reader.ReadToEndAsync();
        }
    }
    
        
    if (string.IsNullOrEmpty(markdown))
    {
        Console.WriteLine("Markdown file is empty. Exiting...");
        return 1;
    }
        
    //var policyRegex = new Regex(@"^\- \[(?<name>.*)\]\(#(?<link>.*)\)$");
    var lines = markdown.Split("\n");
    var policyGroupDocument = new PolicyGroupDocument();
    //var policyGroups = new Dictionary<string, PolicyGroup>();
    //var headerRegex = new Regex(@"^(\s*)##\s+(?<header>.*)$");
    var hashDepthRegex = new Regex(@"^( *)(?<hash_depth>#+)");
    var markdownSectionsDocument = new MarkdownSection();
    var currnetMarkdownSection = markdownSectionsDocument;
    foreach (var line in lines)
    {
        var match = hashDepthRegex.Match(line);
        if (match.Success)
        {
            var currentDepth = currnetMarkdownSection.Depth;
            var newDepth = match.Groups["hash_depth"].Value.Length;
            if (newDepth == currentDepth)
            {
                var newSection = new MarkdownSection()
                {
                    Depth = newDepth,
                    Header = line.Trim(),
                    Parent = currnetMarkdownSection.Parent
                };
                currnetMarkdownSection.Parent?.Children.Add(newSection);
                currnetMarkdownSection = newSection;
            }
            else if (newDepth > currentDepth)
            {
                var newSection = new MarkdownSection()
                {
                    Depth = newDepth,
                    Header = line.Trim(),
                    Parent = currnetMarkdownSection
                };
                newSection.Parent.Children.Add(newSection);
                currnetMarkdownSection = newSection;
            }
            else if (newDepth < currentDepth)
            {
                var depthUp = currentDepth - newDepth;
                var realParent = currnetMarkdownSection.Parent;
                while (depthUp > 0)
                {
                    realParent = realParent?.Parent;
                    --depthUp;
                }
                if (realParent is not null)
                {
                    var newSection = new MarkdownSection()
                    {
                        Depth = newDepth,
                        Header = line.Trim(),
                        Parent = realParent
                    };
                    newSection.Parent.Children.Add(newSection);
                    currnetMarkdownSection = newSection;
                }
            }
        }
        else
        {
            currnetMarkdownSection.Data.Add(line);
        }
    }

    if (markdownSectionsDocument.Children.Count != 1 || string.Equals(markdownSectionsDocument.Children[0].Header, "# Microsoft Edge - Policies", StringComparison.CurrentCultureIgnoreCase) == false)
    {
        Console.WriteLine("Markdown file is not in the expected format.");
        return 1;
    }

    var policiesRoot = markdownSectionsDocument.Children[0];

    var policyGroupHeaderRegex = new Regex(@"^### \[\*(?<name>.*)\*\]\(#(?<link>.*)\)$", RegexOptions.Multiline);
    var availablePolicyGroupRegex = new Regex(@"^- \[(?<name>.*)\]\(#(?<link>.*)\)$", RegexOptions.Multiline);
    var policyGroupSummaryRegex = new Regex(@"^\|\[(?<id>.*)\]\(#(?<link>.*)\)\|(?<name>.*)\|$", RegexOptions.Multiline);
    var policyGroupNameRegex = new Regex(@"^## (?<policy_group_name>(.*)) policies$");
    var policyNameRegex = new Regex(@"^### (?<name>.*)$", RegexOptions.Multiline);
    var settingRegex = new Regex(@"^(\s*)(?<setting_name>.*?): (?<setting_value>.*)$");
    foreach (var rootPolicyChildren in policiesRoot.Children)
    {
        // Setup default policy group.
        if (string.Equals(rootPolicyChildren.Header, "## Available policies", StringComparison.OrdinalIgnoreCase))
        {
            foreach (var availablePoliciesLine in rootPolicyChildren.Data)
            {
                var availablePolicyMatch = availablePolicyGroupRegex.Match(availablePoliciesLine);
                if (availablePolicyMatch.Success)
                {      
                    var policyGroup = new PolicyGroup()
                    {
                        Name = availablePolicyMatch.Groups["name"].Value,
                        Link = availablePolicyMatch.Groups["link"].Value
                    };
                    policyGroupDocument.PolicyGroups.Add(policyGroup.Name, policyGroup);
                }
            }
            
            foreach (var policyGroupChild in rootPolicyChildren.Children)
            {
                var policyGroupMatch = policyGroupHeaderRegex.Match(policyGroupChild.Header);
                if (policyGroupMatch.Success)
                {
                    var policyGroupKey = policyGroupMatch.Groups["name"].Value;
                    if (policyGroupDocument.PolicyGroups.ContainsKey(policyGroupKey) == false)
                    {
                        continue;
                    }

                    var policyGroup = policyGroupDocument.PolicyGroups[policyGroupKey];
                    
                    foreach (var policyGroupChildLine in policyGroupChild.Data)
                    {
                        var policyGroupSummaryMatch = policyGroupSummaryRegex.Match(policyGroupChildLine);
                        if (policyGroupSummaryMatch.Success)
                        { 
                            var policy = new Policy()
                            {
                                Id = policyGroupSummaryMatch.Groups["id"].Value,
                                Name = policyGroupSummaryMatch.Groups["name"].Value,
                                Link = policyGroupSummaryMatch.Groups["link"].Value,
                            };
                            policyGroup.Policies.Add(policy.Id, policy);
                        }
                    }
                }
            }
        }
        else if (string.Equals(rootPolicyChildren.Header, "## New policies", StringComparison.OrdinalIgnoreCase))
        {
            // No-op
        }
        else if (string.Equals(rootPolicyChildren.Header, "## See also", StringComparison.OrdinalIgnoreCase))
        {
            // No-op
        }
        else
        {
            // If we are in this else we assume this is a policy header. We first want to double check against the list we 
            // have already made. That way we can skip if something called "## Future policies" comes up.
            
            //## Application Guard settings policies
            //Application Guard settings
            var policyGroupNameMatch = policyGroupNameRegex.Match(rootPolicyChildren.Header);
            if (policyGroupNameMatch.Success)
            {
                // Startup, home page and new tab page
                // Startup, home page and new tab page
                var policyGroupName = policyGroupNameMatch.Groups["policy_group_name"].Value;

                if (policyGroupName.Contains("&comma;"))
                {
                    policyGroupName = policyGroupName.Replace("&comma;", ",");
                }
                
                if (policyGroupDocument.PolicyGroups.ContainsKey(policyGroupName) == false)
                {
                    Console.WriteLine($"Error: Policy group {rootPolicyChildren.Header} not found in list.");
                    continue;
                }

                var policyGroup = policyGroupDocument.PolicyGroups[policyGroupName];
                foreach (var rootPolicyChildrenChildren in rootPolicyChildren.Children)
                {
                    var policyNameMatch = policyNameRegex.Match(rootPolicyChildrenChildren.Header);
                    if (policyNameMatch.Success)
                    {
                        var policyNameKey = policyNameMatch.Groups["name"].Value;
                        if (policyGroup.Policies.ContainsKey(policyNameKey) == false)
                        {
                            continue;
                        }
                        
                        var policy = policyGroup.Policies[policyNameKey];
                        
                        for (var i = 0; i < rootPolicyChildrenChildren.Children.Count; ++i)
                        {
                            var policyChildren = rootPolicyChildrenChildren.Children[i];
                            if (i == 0)
                            {
                                // No-op, skip first as its the heading.
                            }
                            else if (policyChildren.Header == "#### Supported versions:")
                            {
                                // No-op, not handled at the moment.
                            }
                            else if (policyChildren.Header == "#### Description")
                            {
                                // No-op, not needed at the moment
                            }
                            else if (policyChildren.Header == "#### Supported features:")
                            {
                                foreach (var data in policyChildren.Data)
                                {
                                    if (data == string.Empty)
                                    {
                                        continue;
                                    }

                                    if (data.StartsWith("  - Can be mandatory:"))
                                    {
                                        if (data == "  - Can be mandatory: Yes")
                                        {
                                            policy.CanBeMandatory = true;
                                        }
                                        else if (data == "  - Can be mandatory: No")
                                        {
                                            policy.CanBeMandatory = false;
                                        }
                                        else
                                        {
                                            throw new Exception($"Unknown mandatory row, {data}");
                                        }
                                    }
                                    else if (data.StartsWith("  - Can be recommended: "))
                                    {
                                        if (data == "  - Can be recommended: Yes")
                                        {
                                            policy.CanBeRecommended = true;
                                        }
                                        else if (data == "  - Can be recommended: No")
                                        {
                                            policy.CanBeRecommended = false;
                                        }
                                        else
                                        {
                                            throw new Exception($"Unknown recommended row, {data}");
                                        }
                                    }
                                    else if (data.StartsWith("  - Dynamic Policy Refresh:"))
                                    {
                                        if (data == "  - Dynamic Policy Refresh: Yes")
                                        {
                                            policy.DynamicPolicyRefresh = true;
                                        }
                                        else if (data == "  - Dynamic Policy Refresh: No - Requires browser restart")
                                        {
                                            policy.DynamicPolicyRefresh = false;
                                        }
                                        else
                                        {
                                            throw new Exception($"Unknown dynamic policy refresh row, {data}");
                                        }
                                    }
                                    else if (data.StartsWith("  - Per Profile:"))
                                    {
                                        if (data == "  - Per Profile: Yes")
                                        {
                                            policy.PerProfile = true;
                                        }
                                        else if (data == "  - Per Profile: No")
                                        {
                                            policy.PerProfile = false;
                                        }
                                        else
                                        {
                                            throw new Exception($"Unknown per profile row, {data}");
                                        }
                                    }
                                    else if (data.StartsWith("  - Applies to a profile that is signed in with a Microsoft account:"))
                                    {
                                        if (data == "  - Applies to a profile that is signed in with a Microsoft account: Yes")
                                        {
                                            policy.AppliesToSignedInProfile = true;
                                        }
                                        else if (data == "  - Applies to a profile that is signed in with a Microsoft account: No")
                                        {
                                            policy.AppliesToSignedInProfile = false;
                                        }
                                        else
                                        {
                                            throw new Exception($"Unknown applies to profile that is signed in with microsoft account row, {data}");
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception($"Unknown feature row, {data}");
                                    }
                                }
                            }
                            else if (policyChildren.Header == "#### Data Type:")
                            {
                                var dataType = string.Empty;
                                foreach (var data in policyChildren.Data)
                                {
                                    if (string.IsNullOrWhiteSpace(data))
                                    {
                                        continue;
                                    }

                                    if (dataType == string.Empty)
                                    {
                                        dataType = data;
                                    }
                                    else
                                    {
                                        throw new Exception("Multiple data types found.");
                                    }
                                }
                                
                                policy.DataType = dataType switch
                                {
                                    "  - Dictionary" => "dictionary",
                                    "  - Boolean" => "boolean",
                                    "  - String" => "string",
                                    "  - List of strings" => "list_of_strings",
                                    "  - Integer" => "integer",
                                    _ => throw new Exception($"Unknown data type {policyChildren.Data[1]}")
                                };
                            }
                            else if (policyChildren.Header == "#### Windows information and settings")
                            {
                                policy.PlatformWindows = true;
                                foreach (var policyChildrenChild in policyChildren.Children)
                                {
                                    if (policyChildrenChild.Header.StartsWith("##### Windows Registry Settings", StringComparison.OrdinalIgnoreCase))
                                    {
                                        foreach (var policyChildrenChildData in policyChildrenChild.Data)
                                        {
                                            if (string.IsNullOrEmpty(policyChildrenChildData))
                                            {
                                                continue;
                                            }

                                            var settingMatch = settingRegex.Match(policyChildrenChildData);
                                            if (settingMatch.Success == false)
                                            {
                                                continue;
                                            }
                                            
                                            var settingValue = settingMatch.Groups["setting_value"].Value.Trim();

                                            if (policyChildrenChildData.StartsWith("  - Path (Mandatory):", StringComparison.OrdinalIgnoreCase))
                                            {
                                                // - Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
                                                if (settingValue != "N/A")
                                                {
                                                    policy.WindowsRegistryMandatoryPath = settingValue;
                                                }
                                            }
                                            else if (policyChildrenChildData.StartsWith("  - Path (Recommended):", StringComparison.OrdinalIgnoreCase))
                                            {
                                                //  - Path (Recommended): N/A
                                                if (settingValue != "N/A")
                                                {
                                                    policy.WindowsRegistryRecommendedPath = settingValue;
                                                }
                                            }
                                            else if (policyChildrenChildData.StartsWith("  - Value Name:", StringComparison.OrdinalIgnoreCase))
                                            {
                                                // - Value Name: ApplicationGuardContainerProxy
                                                policy.WindowsRegistryValueName = settingValue;
                                            }
                                            else if (policyChildrenChildData.StartsWith("  - Value Type:", StringComparison.OrdinalIgnoreCase))
                                            {
                                                //  - Value Type: REG_SZ
                                                policy.WindowsRegistryValueType = settingValue;

                                                //list of REG_SZ
                                                if (settingValue != "REG_SZ" && settingValue != "REG_DWORD" && settingValue != "list of REG_SZ")
                                                {
                                                    Console.WriteLine("ERROR: Unknown registry value type in Windows registry settings, {settingValue}");
                                                    return 1;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("ERROR: Unknown option in Windows registry settings.");
                                                return 1;
                                            }
                                        }
                                        //Debugger.Break();
                                    }
                                    else if (policyChildrenChild.Header.StartsWith("##### Example value:", StringComparison.OrdinalIgnoreCase))
                                    {
                                        var readingExample = false;
                                        var exampleBuffer = new StringBuilder();
                                        for (int j = 0; j < policyChildrenChild.Data.Count; ++j)
                                        {
                                            var policyChildrenLine = policyChildrenChild.Data[j];

                                            if (readingExample == true)
                                            {
                                                if (policyChildrenLine.StartsWith("```") == true)
                                                {
                                                    readingExample = false;
                                                    policy.WindowsRegistryExampleValue = exampleBuffer.ToString().Trim();
                                                    break;
                                                }
                                                else
                                                {
                                                    exampleBuffer.AppendLine(policyChildrenLine);
                                                }
                                                continue;
                                            }
                                            
                                            if (policyChildrenLine.StartsWith("```"))
                                            {
                                                readingExample = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (policyChildren.Header == "#### Mac information and settings")
                            {
                                var readingExample = false;
                                var exampleBuffer = new StringBuilder();
                                for (int j = 0; j < policyChildren.Data.Count; ++j)
                                {
                                    var policyChildrenLine = policyChildren.Data[j];

                                    if (readingExample == true)
                                    {
                                        if (policyChildrenLine.StartsWith("```") == true)
                                        {
                                            readingExample = false;
                                            policy.MacOSPreferenceExampleValue = exampleBuffer.ToString().Trim();
                                        }
                                        else
                                        {
                                            exampleBuffer.AppendLine(policyChildrenLine.Trim());
                                        }
                                        continue;
                                    }
                                    
                                    if (policyChildrenLine.StartsWith("  - Preference Key Name:"))
                                    {
                                        
                                        var settingMatch = settingRegex.Match(policyChildrenLine);
                                        if (settingMatch.Success == false)
                                        {
                                            continue;
                                        }
                                        
                                        policy.MacOSPreferenceKeyName = settingMatch.Groups["setting_value"].Value.Trim();
                                    }
                                    else if (policyChildrenLine.StartsWith("``` xml"))
                                    {
                                        readingExample = true;
                                    }

                                }
                                
                                policy.PlatformMacOS = true;
                            }
                            else
                            {
                                throw new Exception($"Unknown child policy header {policyChildren.Header}");
                            }
                        }
                        
                        policy.Markdown = rootPolicyChildrenChildren.GenerateMarkdown();
                        policy.Summary = rootPolicyChildrenChildren.GetSummary();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Error: Unknown policy group {rootPolicyChildren.Header}");
            }
        }
    }

    foreach (var data in markdownSectionsDocument.Data)
    {
        if (data.StartsWith("ms.date: "))
        {
            policyGroupDocument.PolicyDate = data.Replace("ms.date: ", string.Empty);
            break;
        }
    }

    if (string.IsNullOrEmpty(policyGroupDocument.PolicyDate))
    {
        throw new Exception("Policy date not found.");
    }

    if (policyGroupDocument.PolicyGroups.Count == 0)
    {
        throw new Exception("No policy groups loaded.");
    }
    
    var jsonSerializerOptions = new JsonSerializerOptions()
    {
        WriteIndented = true
    };

    // Validate certain things that are assumed.
    foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
    {
        foreach (var policy in policyGroup.Policies.Values)
        {
            if (policy.CanBeMandatory == false && policy.CanBeRecommended == false)
            {
                Console.WriteLine("ERROR: At some point CanBeMandatory and CanBeRecommended were both false.");
                Debugger.Break();
                return 1;
            }

            if (policy.PlatformWindows)
            {
                if (policy.CanBeRecommended == true && string.IsNullOrEmpty(policy.WindowsRegistryRecommendedPath) == true)
                {
                    Console.WriteLine("ERROR: Windows registry value can be recommended, but no path is defined.");
                    Debugger.Break();
                    return 1;
                }

                if (policy.CanBeMandatory == true && string.IsNullOrEmpty(policy.WindowsRegistryMandatoryPath) == true)
                {
                    Console.WriteLine("ERROR: Windows registry value can be mandatory, but no path is defined.");
                    Debugger.Break();
                    return 1;
                }

                if (policy.CanBeRecommended == true && policy.WindowsRegistryRecommendedPath.StartsWith(@"SOFTWARE\Policies\Microsoft\Edge") == false)
                {
                    Console.WriteLine("ERROR: Expected registry recommended path to begin with SOFTWARE\\Policies\\Microsoft\\Edge, but it didnt.");
                    Debugger.Break();
                    return 1;
                }

                if (policy.CanBeMandatory == true && policy.WindowsRegistryMandatoryPath.StartsWith(@"SOFTWARE\Policies\Microsoft\Edge") == false)
                {
                    Console.WriteLine("ERROR: Expected registry mandatory path to begin with SOFTWARE\\Policies\\Microsoft\\Edge, but it didnt.");
                    Debugger.Break();
                    return 1;
                }
            }

            if (policy.PlatformMacOS)
            {
                if (string.IsNullOrEmpty(policy.MacOSPreferenceExampleValue))
                {
                    Console.WriteLine("ERROR: macOS example value is empty.");
                    Debugger.Break();
                    return 1;
                }
                
                if (string.IsNullOrEmpty(policy.MacOSPreferenceKeyName))
                {
                    Console.WriteLine("ERROR: macOS Preference key name is empty.");
                    Debugger.Break();
                    return 1;
                }
            }
        }
    }
    
    
    var policyGroupsJson = JsonSerializer.Serialize(policyGroupDocument, jsonSerializerOptions);
    await File.WriteAllTextAsync("policy-groups.json", policyGroupsJson);

    var markdownSharp = new Markdown();
    if (Directory.Exists("html") == false)
    {
        Directory.CreateDirectory("html");
    }
    
    foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
    {
        foreach (var policy in policyGroup.Policies.Values)
        {
            var htmlDoc = markdownSharp.Transform(policy.Markdown);
            // Bad way to do this, but oh well.
            htmlDoc = htmlDoc.Replace("<p><a href=\"#microsoft-edge---policies\">Back to top</a></p>", string.Empty);
            var outputFile = Path.Combine("html", $"{policyGroup.Link}_{policy.Link}.html");
            File.WriteAllText(outputFile, htmlDoc);
            policy.Markdown = string.Empty;
            
        }
    }
    
    policyGroupsJson = JsonSerializer.Serialize(policyGroupDocument, jsonSerializerOptions);
    await File.WriteAllTextAsync("policy-groups-min.json", policyGroupsJson);
}
catch (Exception err)
{
    Console.WriteLine($"Error: {err.Message}");
    return 1;
}

Console.WriteLine("Done");

return 0;