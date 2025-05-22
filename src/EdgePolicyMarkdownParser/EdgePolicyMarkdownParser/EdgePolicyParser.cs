using System.Diagnostics;
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
    
    public string TocYmlFilePath => Path.Combine(OutputPath, "toc.yml");
    
    public string PolicyMarkdownDirectory => Path.Combine(OutputPath, "policy-markdown");


    public EdgePolicyParser()
    {
        if (Directory.Exists(OutputPath) == false)
        {
            Directory.CreateDirectory(OutputPath);
        }
        
        if (Directory.Exists(PolicyMarkdownDirectory) == false)
        {
            Directory.CreateDirectory(PolicyMarkdownDirectory);
        }
    }

    internal async Task DownloadOrUpdatePolicyAsync()
    {
        var needsDownload = true;
        if (File.Exists(TocYmlFilePath))
        {
            // TODO: Check git hash or etag or something else
            var fileInfo = new FileInfo(TocYmlFilePath);
            if ((DateTime.Now - fileInfo.LastWriteTime).Days > 1)
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

        // Download the TOC.yml file first
        using (var httpClient = new HttpClient())
        {
            // Download the TOC.yml file
            var tocResponse = await httpClient.GetAsync("https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-browser-policies/toc.yml");
            var tocContent = await tocResponse.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync(TocYmlFilePath, tocContent);

            // Parse the TOC.yml to extract policy groups and policies
            var policyGroups = ParseTocYml(tocContent);

            // Download each policy markdown file
            foreach (var policyGroup in policyGroups)
            {
                foreach (var policy in policyGroup.Value)
                {
                    if (string.IsNullOrEmpty(policy.Href)) continue;
                    
                    // Skip the first entry which points to the old file
                    if (policy.Href.Contains("../microsoft-edge-policies.md")) continue;
                    
                    var policyFilePath = Path.Combine(PolicyMarkdownDirectory, policy.Href);
                    var policyUrl = $"https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-browser-policies/{policy.Href}";
                    
                    try
                    {
                        var policyResponse = await httpClient.GetAsync(policyUrl);
                        var policyContent = await policyResponse.Content.ReadAsStringAsync();
                        await File.WriteAllTextAsync(policyFilePath, policyContent);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error downloading {policy.Name}: {ex.Message}");
                    }
                }
            }
        }
    }
    
    private Dictionary<string, List<(string Name, string Href)>> ParseTocYml(string tocContent)
    {
        var policyGroups = new Dictionary<string, List<(string Name, string Href)>>();
        var lines = tocContent.Split('\n');
        
        string currentGroup = string.Empty;
        bool inItems = false;
        
        foreach (var line in lines)
        {
            var trimmedLine = line.Trim();
            
            // Check if this is a top-level group
            if (trimmedLine.StartsWith("- name:") && !inItems)
            {
                var name = trimmedLine.Substring("- name:".Length).Trim();
                currentGroup = name;
                
                if (!policyGroups.ContainsKey(currentGroup))
                {
                    policyGroups[currentGroup] = new List<(string Name, string Href)>();
                }
                
                inItems = false;
            }
            // Check if we're entering the items section of a group
            else if (trimmedLine == "items:")
            {
                inItems = true;
            }
            // Check if this is a policy entry inside a group
            else if (trimmedLine.StartsWith("- name:") && inItems)
            {
                var name = trimmedLine.Substring("- name:".Length).Trim();
                string href = string.Empty;
                
                // Look ahead to get the href
                for (int i = Array.IndexOf(lines, line) + 1; i < lines.Length; i++)
                {
                    var nextLine = lines[i].Trim();
                    if (nextLine.StartsWith("href:"))
                    {
                        href = nextLine.Substring("href:".Length).Trim();
                        break;
                    }
                }
                
                if (!string.IsNullOrEmpty(currentGroup) && policyGroups.ContainsKey(currentGroup))
                {
                    policyGroups[currentGroup].Add((Name: name, Href: href));
                }
            }
        }
        
        return policyGroups;
    }

    public PolicyGroupDocument LoadPolicyGroupDocument()
    {
        var policyGroupDocument = new PolicyGroupDocument();
        var hashDepthRegex = new Regex(@"^( *)(?<hash_depth>#+)");
        var policyMappingRegex = new Regex(@"^\* (?<value>.*) \((?<key>.*?)\) = (?<description>.*)$");
        var windowsExampleRegex = new Regex(@"^SOFTWARE\\(.*) = (?<json_dictionary>(.|\n)*)$");
        var windowsListOfStringsExampleRegex = new Regex(@"^SOFTWARE\\(.*) = (?<example_value>.*)$");
        
        // Create dictionary for policy groups
        var tocFilePath = TocYmlFilePath;
        if (!File.Exists(tocFilePath))
        {
            throw new Exception("TOC.yml file not found. Please download policies first.");
        }
        
        var tocContent = File.ReadAllText(tocFilePath);
        var policyGroupsFromToc = ParseTocYml(tocContent);
        
        // Initialize policy groups
        foreach (var groupEntry in policyGroupsFromToc)
        {
            // Skip the first entry which is just a link to the old file
            if (groupEntry.Key == "Microsoft Edge - Policies") continue;
            
            var policyGroup = new PolicyGroup()
            {
                Name = groupEntry.Key,
                Link = groupEntry.Key.ToLower().Replace(" ", "-")
            };
            
            policyGroupDocument.PolicyGroups.Add(policyGroup.Name, policyGroup);
            
            // Add policies to the group
            foreach (var policyEntry in groupEntry.Value)
            {
                var policyId = policyEntry.Name;
                var policyFilePath = Path.Combine(PolicyMarkdownDirectory, policyEntry.Href);
                
                if (!File.Exists(policyFilePath))
                {
                    Console.WriteLine($"Warning: Policy file not found: {policyFilePath}");
                    continue;
                }
                
                var policy = new Policy()
                {
                    Id = policyId,
                    Name = policyId,
                    Link = policyId.ToLower(),
                };
                policy.Supported = SupportedPolicies.IsSupported(policy.Id);
                
                policyGroup.Policies.Add(policy.Id, policy);
                
                // Process the individual policy file
                var policyContent = File.ReadAllText(policyFilePath);
                ProcessPolicyFile(policy, policyContent, hashDepthRegex, policyMappingRegex, windowsExampleRegex, windowsListOfStringsExampleRegex);
            }
        }
        
        // Set the policy date (using the current date since we can't get it from the original file anymore)
        policyGroupDocument.PolicyDate = DateTime.Now.ToString("MM/dd/yyyy");
        policyGroupDocument.LastUpdated = DateTime.Now.ToString("yyyy-MM-dd");
        
        if (policyGroupDocument.PolicyGroups.Count == 0)
        {
            throw new Exception("No policy groups loaded.");
        }
        
        return policyGroupDocument;
    }
    
    private void ProcessPolicyFile(Policy policy, string content, Regex hashDepthRegex, Regex policyMappingRegex, Regex windowsExampleRegex, Regex windowsListOfStringsExampleRegex)
    {
        var lines = content.Split('\n');
        
        var markdownSectionsDocument = new MarkdownSection();
        var currnetMarkdownSection = markdownSectionsDocument;
        
        // Parse the markdown file structure first
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
        
        // Now process the structured document to extract policy details
        foreach (var section in markdownSectionsDocument.Children)
        {
            // Find the sections we need
            foreach (var childSection in section.Children)
            {
                // Skip the first section which is just the title
                if (childSection.Header.StartsWith("# "))
                {
                    continue;
                }
                
                // Extract policy description
                if (childSection.Header == "## Description")
                {
                    var readingPolicyMapping = false;
                    for (int j = 0; j < childSection.Data.Count; ++j)
                    {
                        var policyChildrenLine = childSection.Data[j];

                        if (string.IsNullOrWhiteSpace(policyChildrenLine))
                        {
                            continue;
                        }

                        if (readingPolicyMapping == true)
                        {
                            var match = policyMappingRegex.Match(policyChildrenLine);
                            if (match.Success)
                            {
                                policy.PolicyMapping.Add(match.Groups["key"].Value, match.Groups["value"].Value);
                            }
                            else
                            {
                                readingPolicyMapping = false;
                                break;
                            }

                            continue;
                        }

                        if (policyChildrenLine.StartsWith("Policy options mapping:"))
                        {
                            readingPolicyMapping = true;
                        }
                    }
                    
                    policy.Summary = childSection.GetSummary();
                }
                // Extract supported features
                else if (childSection.Header == "## Supported features")
                {
                    foreach (var data in childSection.Data)
                    {
                        if (data == string.Empty)
                        {
                            continue;
                        }

                        if (data.StartsWith("- Can be mandatory:"))
                        {
                            if (data.Contains("Yes"))
                            {
                                policy.CanBeMandatory = true;
                            }
                            else if (data.Contains("No"))
                            {
                                policy.CanBeMandatory = false;
                            }
                            else
                            {
                                throw new Exception($"Unknown mandatory row, {data}");
                            }
                        }
                        else if (data.StartsWith("- Can be recommended:"))
                        {
                            if (data.Contains("Yes"))
                            {
                                policy.CanBeRecommended = true;
                            }
                            else if (data.Contains("No"))
                            {
                                policy.CanBeRecommended = false;
                            }
                            else
                            {
                                throw new Exception($"Unknown recommended row, {data}");
                            }
                        }
                        else if (data.StartsWith("- Dynamic Policy Refresh:"))
                        {
                            if (data.Contains("Yes"))
                            {
                                policy.DynamicPolicyRefresh = true;
                            }
                            else if (data.Contains("No"))
                            {
                                policy.DynamicPolicyRefresh = false;
                            }
                            else
                            {
                                throw new Exception($"Unknown dynamic policy refresh row, {data}");
                            }
                        }
                        else if (data.StartsWith("- Per Profile:"))
                        {
                            if (data.Contains("Yes"))
                            {
                                policy.PerProfile = true;
                            }
                            else if (data.Contains("No"))
                            {
                                policy.PerProfile = false;
                            }
                            else
                            {
                                throw new Exception($"Unknown per profile row, {data}");
                            }
                        }
                        else if (data.StartsWith("- Applies to a profile that is signed in with a Microsoft account:"))
                        {
                            if (data.Contains("Yes"))
                            {
                                policy.AppliesToSignedInProfile = true;
                            }
                            else if (data.Contains("No"))
                            {
                                policy.AppliesToSignedInProfile = false;
                            }
                            else
                            {
                                throw new Exception($"Unknown applies to profile that is signed in with microsoft account row, {data}");
                            }
                        }
                    }
                }
                // Extract data type
                else if (childSection.Header == "## Data type")
                {
                    var dataType = string.Empty;
                    foreach (var data in childSection.Data)
                    {
                        if (string.IsNullOrWhiteSpace(data))
                        {
                            continue;
                        }

                        if (dataType == string.Empty)
                        {
                            dataType = data.Trim();
                        }
                        else
                        {
                            throw new Exception("Multiple data types found.");
                        }
                    }

                    policy.DataType = dataType switch
                    {
                        "- Dictionary" => "dictionary",
                        "- Boolean" => "boolean",
                        "- String" => "string",
                        "- List of strings" => "list_of_strings",
                        "- Integer" => "integer",
                        _ => throw new Exception($"Unknown data type {dataType}")
                    };
                }
                // Extract Windows information
                else if (childSection.Header == "## Windows information and settings")
                {
                    policy.PlatformWindows = true;
                    
                    foreach (var subSection in childSection.Children)
                    {
                        if (subSection.Header.Contains("Registry settings", StringComparison.OrdinalIgnoreCase))
                        {
                            var settingRegex = new Regex(@"^(\s*)(?<setting_name>.*?): (?<setting_value>.*)$");
                            
                            foreach (var data in subSection.Data)
                            {
                                if (string.IsNullOrEmpty(data)) continue;
                                
                                var settingMatch = settingRegex.Match(data);
                                if (!settingMatch.Success) continue;
                                
                                var settingValue = settingMatch.Groups["setting_value"].Value.Trim();
                                
                                if (data.Contains("Path (Mandatory):", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (settingValue != "N/A")
                                    {
                                        policy.WindowsRegistryMandatoryPath = settingValue;
                                    }
                                }
                                else if (data.Contains("Path (Recommended):", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (settingValue != "N/A")
                                    {
                                        policy.WindowsRegistryRecommendedPath = settingValue;
                                    }
                                }
                                else if (data.Contains("Value Name:", StringComparison.OrdinalIgnoreCase))
                                {
                                    policy.WindowsRegistryValueName = settingValue;
                                }
                                else if (data.Contains("Value Type:", StringComparison.OrdinalIgnoreCase))
                                {
                                    policy.WindowsRegistryValueType = settingValue;
                                    
                                    if (settingValue != "REG_SZ" && settingValue != "REG_DWORD" && settingValue != "list of REG_SZ")
                                    {
                                        throw new Exception($"Unknown registry value type in Windows registry settings, {settingValue}");
                                    }
                                }
                            }
                        }
                        else if (subSection.Header.Contains("Example value:", StringComparison.OrdinalIgnoreCase))
                        {
                            var readingExample = false;
                            var exampleBuffer = new LFStringBuilder();
                            
                            for (int j = 0; j < subSection.Data.Count; ++j)
                            {
                                var line = subSection.Data[j];
                                
                                if (readingExample)
                                {
                                    if (line.StartsWith("```"))
                                    {
                                        readingExample = false;
                                        policy.WindowsRegistryExampleValue = exampleBuffer.ToString().Trim();
                                        
                                        // Process the example value based on data type
                                        if (policy.DataType == "string")
                                        {
                                            policy.WindowsRegistryExampleValue = policy.WindowsRegistryExampleValue.Trim('"');
                                        }
                                        else if (policy.DataType == "dictionary")
                                        {
                                            var match = windowsExampleRegex.Match(policy.WindowsRegistryExampleValue);
                                            if (match.Success)
                                            {
                                                policy.WindowsRegistryExampleValue = match.Groups["json_dictionary"].Value;
                                            }
                                        }
                                        else if (policy.DataType == "list_of_strings")
                                        {
                                            var exampleLines = policy.WindowsRegistryExampleValue.Split('\n');
                                            
                                            for (var k = 0; k < exampleLines.Length; ++k)
                                            {
                                                var match = windowsListOfStringsExampleRegex.Match(exampleLines[k]);
                                                if (match.Success)
                                                {
                                                    exampleLines[k] = match.Groups["example_value"].Value.Trim('"');
                                                }
                                            }
                                            
                                            policy.WindowsRegistryExampleValue = string.Join('\n', exampleLines);
                                        }
                                        
                                        // This policy has some new lines and other descriptions in its example, this is to tidy it.
                                        if (policy.Id == "DownloadDirectory")
                                        {
                                            policy.WindowsRegistryExampleValue = policy.WindowsRegistryExampleValue.Replace("\\n", string.Empty).Trim().Replace("        ", ", ");
                                        }
                                        
                                        break;
                                    }
                                    else
                                    {
                                        exampleBuffer.AppendLine(line);
                                    }
                                    
                                    continue;
                                }
                                
                                if (line.StartsWith("```"))
                                {
                                    readingExample = true;
                                }
                            }
                        }
                    }
                }
                // Extract macOS information
                else if (childSection.Header == "## Mac information and settings")
                {
                    policy.PlatformMacOS = true;
                    
                    var readingExample = false;
                    var exampleBuffer = new LFStringBuilder();
                    
                    for (int j = 0; j < childSection.Data.Count; ++j)
                    {
                        var line = childSection.Data[j];
                        
                        if (readingExample)
                        {
                            if (line.StartsWith("```"))
                            {
                                readingExample = false;
                                policy.MacOSPreferenceExampleValue = exampleBuffer.ToString().Trim();
                                
                                // This policy has some new lines and other descriptions in its example, this is to tidy it.
                                if (policy.Id == "DownloadDirectory")
                                {
                                    policy.MacOSPreferenceExampleValue = policy.MacOSPreferenceExampleValue.Replace("\\n", string.Empty).Trim().Replace("        ", ", ");
                                }
                                
                                break;
                            }
                            else
                            {
                                exampleBuffer.AppendLine(line.Trim());
                            }
                            
                            continue;
                        }
                        
                        if (line.Contains("Preference Key Name:"))
                        {
                            var settingRegex = new Regex(@"^(\s*)(?<setting_name>.*?): (?<setting_value>.*)$");
                            var settingMatch = settingRegex.Match(line);
                            
                            if (settingMatch.Success)
                            {
                                policy.MacOSPreferenceKeyName = settingMatch.Groups["setting_value"].Value.Trim();
                            }
                        }
                        else if (line.StartsWith("```"))
                        {
                            readingExample = true;
                        }
                    }
                }
            }
        }
        
        // Generate full markdown for the policy
        policy.Markdown = markdownSectionsDocument.GenerateMarkdown();
    }
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
                    else
                    {
	                    if (string.IsNullOrEmpty(availablePoliciesLine) == true)
	                    {
		                    // NOOP
	                    }
	                    else if (availablePoliciesLine.StartsWith("These tables list all of") == true)
	                    {
		                    // NOOP
	                    }
	                    else
	                    {
		                    Debugger.Break();
	                    }
					}
                }

                foreach (var policyGroupChild in rootPolicyChildren.Children)
                {
                    var policyGroupMatch = policyGroupHeaderRegex.Match(policyGroupChild.Header);
                    if (policyGroupMatch.Success)
                    {
                        var policyGroupKey = policyGroupMatch.Groups["name"].Value;
                        policyGroupKey = policyGroupKey.Replace("&comma;", ",");

                        if (policyGroupKey == "Microsoft Edge Website Typo Protection settings")
                        {
	                        policyGroupKey = "Edge Website Typo Protection settings";
                        }

                        if (policyGroupDocument.PolicyGroups.ContainsKey(policyGroupKey) == false)
                        {
	                        Debugger.Break();
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
                            else if (string.IsNullOrEmpty(policyGroupChildLine) == true)
                            {
	                            // NOOP
                            }
                            else if (policyGroupChildLine == "|Policy Name|Caption|" || policyGroupChildLine == "|-|-|")
							{
	                            // NOOP
							}
							else
							{
	                            Debugger.Break();
							}
                        }
                    }
                    else
                    {
	                    Debugger.Break();
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

                            if (policy.Id == "DownloadDirectory")
                            {
                                policy.Warnings.Add("This policy has different expected values for Windows, macOS, and Linux. If you plan to use it on multiple operating systems you will need to use different values for each.");
                            }

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
                                    var readingPolicyMapping = false;
                                    for (int j = 0; j < policyChildren.Data.Count; ++j)
                                    {
                                        var policyChildrenLine = policyChildren.Data[j];

                                        if (string.IsNullOrWhiteSpace(policyChildrenLine))
                                        {
                                            continue;
                                        }

                                        if (readingPolicyMapping == true)
                                        {
                                            var match = policyMappingRegex.Match(policyChildrenLine);
                                            if (match.Success)
                                            {
                                                policy.PolicyMapping.Add(match.Groups["key"].Value, match.Groups["value"].Value);
                                            }
                                            else
                                            {
                                                readingPolicyMapping = false;
                                                break;
                                            }

                                            continue;
                                        }

                                        if (policyChildrenLine.StartsWith("Policy options mapping:"))
                                        {
                                            readingPolicyMapping = true;
                                        }
                                    }
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
                                                else if (policyChildrenChildData.StartsWith("  - Preference Key Name:", StringComparison.OrdinalIgnoreCase))
												{
													// Someone forgot to seperate macOS and Windows settings
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
                                            var exampleBuffer = new LFStringBuilder();
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
                                                        else if (policy.DataType == "dictionary")
                                                        {
                                                            if (policy.PlatformMacOS == true && policy.PlatformWindows == false)
                                                            {
                                                                Console.WriteLine($"Error: Policy {policy.Id} is a dictionary, but there may be issues generating its example as it is macOS only.");
                                                                Debugger.Break();
                                                            }

                                                            var match = windowsExampleRegex.Match(policy.WindowsRegistryExampleValue);
                                                            if (match.Success)
                                                            {
                                                                policy.WindowsRegistryExampleValue = match.Groups["json_dictionary"].Value;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Error: Could not prepare example for {policy.Id}.");
                                                                Debugger.Break();
                                                            }
                                                        }
                                                        else if (policy.DataType == "list_of_strings")
                                                        {
                                                            if (policy.PlatformMacOS == true && policy.PlatformWindows == false)
                                                            {
                                                                Console.WriteLine($"Error: Policy {policy.Id} is a list of strings, but there may be issues generating its example as it is macOS only.");
                                                                Debugger.Break();
                                                            }

                                                            var exampleLines = policy.WindowsRegistryExampleValue.Split('\n');

                                                            for (var k = 0; k < exampleLines.Length; ++k)
                                                            {
                                                                var match = windowsListOfStringsExampleRegex.Match(exampleLines[k]);
                                                                if (match.Success)
                                                                {
                                                                    exampleLines[k] = match.Groups["example_value"].Value.Trim('"');
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Error: Could not prepare example for {policy.Id}.");
                                                                    Debugger.Break();
                                                                }
                                                            }

                                                            policy.WindowsRegistryExampleValue = string.Join('\n', exampleLines);
                                                        }

                                                        // This policy has some new lines and other descriptions in its example, this is to tidy it.
                                                        if (policy.Id == "DownloadDirectory")
                                                        {
                                                            policy.WindowsRegistryExampleValue = policy.WindowsRegistryExampleValue.Replace("\\n", string.Empty).Trim().Replace("        ", ", ");
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
                                    var exampleBuffer = new LFStringBuilder();
                                    for (int j = 0; j < policyChildren.Data.Count; ++j)
                                    {
                                        var policyChildrenLine = policyChildren.Data[j];

                                        if (readingExample == true)
                                        {
                                            if (policyChildrenLine.StartsWith("```") == true)
                                            {
                                                readingExample = false;
                                                policy.MacOSPreferenceExampleValue = exampleBuffer.ToString().Trim();
                                                
                                                
                                                // This policy has some new lines and other descriptions in its example, this is to tidy it.
                                                if (policy.Id == "DownloadDirectory")
                                                {
                                                    policy.MacOSPreferenceExampleValue = policy.MacOSPreferenceExampleValue.Replace("\\n", string.Empty).Trim().Replace("        ", ", ");
                                                }
                                                
                                                break;
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
	            policyGroupDocument.LastUpdated = DateTime.Now.ToString("yyyy-MM-dd");
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
