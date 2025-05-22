using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

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
            // Use a relative path instead of an absolute path
            return "docs";
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

        Console.WriteLine("Downloading policy files...");
        
        // Download the TOC.yml file first
        using (var httpClient = new HttpClient())
        {
            // Download the TOC.yml file
            Console.WriteLine("Downloading TOC.yml file...");
            var tocResponse = await httpClient.GetAsync("https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-browser-policies/toc.yml");
            var tocContent = await tocResponse.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync(TocYmlFilePath, tocContent);
            Console.WriteLine("TOC.yml downloaded successfully.");

            // Parse the TOC.yml to extract policy groups and policies
            var policyGroups = ParseTocYml(tocContent);

            // Create a list to hold all download tasks
            var downloadTasks = new List<Task>();
            var semaphore = new SemaphoreSlim(10); // Limit concurrent downloads to 10
            var totalFiles = 0;
            var downloadedFiles = 0;
            
            // Count total files to download
            foreach (var policyGroup in policyGroups)
            {
                foreach (var policy in policyGroup.Value)
                {
                    if (string.IsNullOrEmpty(policy.Href)) continue;
                    if (policy.Href.Contains("../microsoft-edge-policies.md")) continue;
                    totalFiles++;
                }
            }
            
            Console.WriteLine($"Found {totalFiles} policy files to download.");
            
            // Download each policy markdown file in parallel
            foreach (var policyGroup in policyGroups)
            {
                foreach (var policy in policyGroup.Value)
                {
                    if (string.IsNullOrEmpty(policy.Href)) continue;
                    
                    // Skip the first entry which points to the old file
                    if (policy.Href.Contains("../microsoft-edge-policies.md")) continue;
                    
                    // Create a local copy of these variables to use in the lambda
                    var policyName = policy.Name;
                    var policyHref = policy.Href;
                    
                    downloadTasks.Add(DownloadPolicyFileAsync(httpClient, policyName, policyHref, semaphore, () => {
                        var progress = Interlocked.Increment(ref downloadedFiles);
                        Console.WriteLine($"Downloaded {progress}/{totalFiles}: {policyName}");
                    }));
                }
            }
            
            // Wait for all downloads to complete
            await Task.WhenAll(downloadTasks);
            Console.WriteLine("All policy files downloaded successfully.");
        }
    }
    
    private async Task DownloadPolicyFileAsync(HttpClient httpClient, string policyName, string policyHref, SemaphoreSlim semaphore, Action onComplete)
    {
        try
        {
            await semaphore.WaitAsync();
            
            var policyFilePath = Path.Combine(PolicyMarkdownDirectory, policyHref);
            var policyUrl = $"https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-browser-policies/{policyHref}";
            
            // Create directory if needed (for nested paths)
            var directory = Path.GetDirectoryName(policyFilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            
            var policyResponse = await httpClient.GetAsync(policyUrl);
            var policyContent = await policyResponse.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync(policyFilePath, policyContent);
            
            onComplete?.Invoke();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error downloading {policyName}: {ex.Message}");
        }
        finally
        {
            semaphore.Release();
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
                                    
                                    if (settingValue != "REG_SZ" && settingValue != "REG_DWORD" && settingValue != "list of REG_SZ" && settingValue != "List of REG_SZ")
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
}