using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace EdgePolicyMarkdownParser;


/*
NOTE: This tool currently only focuses on browser policy reference.

Browser policy reference
Microsoft Edge - Policies
https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies

EdgeUpdater policy reference
Microsoft Edge - EdgeUpdater policies for macOS
https://learn.microsoft.com/en-us/deployedge/microsoft-edge-edgeupdater-policies-mac

Update policy reference
Microsoft Edge - Update policies
https://learn.microsoft.com/en-us/deployedge/microsoft-edge-update-policies


Mobile policy reference
Microsoft Edge Mobile - Policies
https://learn.microsoft.com/en-us/deployedge/microsoft-edge-mobile-policies

WebView2 policy reference
Microsoft Edge WebView2 - Policies
https://learn.microsoft.com/en-us/deployedge/microsoft-edge-webview-policies
*/

public class EdgePolicyParser
{
    public string OutputPath
    {
        get
        {
#if DEBUG
            return Path.Combine("..", "..", "..", "..", "..", "..", "docs");
#else
            return "output";
#endif
        }
    }

    public string MarkdownFilePath => Path.Combine(OutputPath, "microsoft-edge-policies.md");


    public EdgePolicyParser()
    {
        if (Directory.Exists(OutputPath) == false)
        {
            Directory.CreateDirectory(OutputPath);
        }
    }

    internal async Task DownloadOrUpdatePolicyAsync()
    {
        var needsDownload = true;
        if (File.Exists(MarkdownFilePath))
        {
            // TODO: Check git hash or etag or something else
            var fileInfo = new FileInfo(MarkdownFilePath);
            if ((DateTime.Now - fileInfo.LastWriteTime).Days > 7)
            {
                needsDownload = true;
            }
            else
            {
                needsDownload = false;
            }
        }

        if (needsDownload == false)
        {
            return;
        }

        using (var memoryStream = new MemoryStream())
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-policies.md");
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                await stream.CopyToAsync(memoryStream);
            }

            memoryStream.Position = 0;

            using (var fileStream = File.Create(MarkdownFilePath))
            {
                await memoryStream.CopyToAsync(fileStream);
            }
        }
    }

    public PolicyGroupDocument LoadPolicyGroupDocument()
    {
        var lines = File.ReadAllLines(MarkdownFilePath);

        //var policyRegex = new Regex(@"^\- \[(?<name>.*)\]\(#(?<link>.*)\)$");
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
            throw new Exception("Markdown file is not in the expected format.");
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

                        // Helper to build policy list
                        // Console.WriteLine($"// {policyGroup.Name}");

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
                                policy.Supported = SupportedPolicies.IsSupported(policy.Id);

                                // Helper to build policy list
                                // Console.WriteLine($"{{ \"{policy.Id}\", false }},");

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
                                                        throw new Exception("Unknown registry value type in Windows registry settings, {settingValue}");
                                                    }

                                                }
                                                else
                                                {
                                                    throw new Exception("Unknown option in Windows registry settings.");
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
                                                        
                                                        // If it's a string example, strip the double quotes from the example
                                                        if (policy.DataType == "string")
                                                        {
                                                            policy.WindowsRegistryExampleValue = policy.WindowsRegistryExampleValue.Trim('"');
                                                        }

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

        return policyGroupDocument;
    }
}