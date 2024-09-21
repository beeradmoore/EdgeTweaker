using System.Text.RegularExpressions;

namespace EdgePolicyMarkdownParser;

public class EdgePolicyParser
{
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
    public async Task<string> UpdateLatestEdgeEnterprisePolicy()
    {
        var tempFile = Path.GetTempFileName();
        try
        {
            using (var memoryStream = new MemoryStream())
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync("https://raw.githubusercontent.com/MicrosoftDocs/Edge-Enterprise/public/edgeenterprise/microsoft-edge-policies.md");
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    await stream.CopyToAsync(memoryStream);
                }

                memoryStream.Position = 0;

                var policyIsValid = ValidatePolicy(memoryStream);

                if (policyIsValid)
                {
                    using (var fileStream = File.Create(tempFile))
                    {
                        await memoryStream.CopyToAsync(fileStream);
                    }

                    return tempFile;
                }
                else
                {
                    throw new Exception("Policy document is not valid.");
                }
            }
        }
        catch (Exception err)
        {
            Console.WriteLine($"Error: {err.Message}");
        }
        
        return string.Empty;
    }
    
    public bool ValidatePolicy(Stream policyDocumentMemoryStream)
    {
        using (var reader = new StreamReader(policyDocumentMemoryStream))
        {
            return ValidatePolicy(reader.ReadToEnd());
        }
    }
    
    public bool ValidatePolicy(string policyDocument)
    {
        return false;
    }

    public async Task<Dictionary<string, PolicyGroup>> LoadPolicies()
    {
        var markdown = string.Empty;
        
        /*
        using (var stream = await FileSystem.OpenAppPackageFileAsync("microsoft-edge-policies.md"))
        {
            using (var reader = new StreamReader(stream))
            {
                markdown = await reader.ReadToEndAsync();
            }
        }
        */
        
        if (string.IsNullOrEmpty(markdown))
        {
            Console.WriteLine("Markdown file is empty. Exiting...");
            return new Dictionary<string, PolicyGroup>();
        }
        
        var policyRegex = new Regex(@"^\- \[(?<name>.*)\]\(#(?<link>.*)\)$");
        var lines = markdown.Split("\n");

        
        
        
        var policyGroups = new Dictionary<string, PolicyGroup>();
        
        var markdownSections = new Dictionary<string, string>();
        
        var headerRegex = new Regex(@"^(\s*)##\s+(?<header>.*)$");

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
            return new Dictionary<string, PolicyGroup>();
        }

        var policiesRoot = markdownSectionsDocument.Children[0];

        var policyGroupHeaderRegex = new Regex(@"^### \[\*(?<name>.*)\*\]\(#(?<link>.*)\)$", RegexOptions.Multiline);
        var availablePolicyGroupRegex = new Regex(@"^- \[(?<name>.*)\]\(#(?<link>.*)\)$", RegexOptions.Multiline);
        var policyGroupSummaryRegex = new Regex(@"^\|\[(?<id>.*)\]\(#(?<link>.*)\)\|(?<name>.*)\|$", RegexOptions.Multiline);
        var policyGroupNameRegex = new Regex(@"^## (?<policy_group_name>(.*)) policies$");
        var policyNameRegex = new Regex(@"^### (?<name>.*)$", RegexOptions.Multiline);
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
                        policyGroups.Add(policyGroup.Name, policyGroup);
                    }
                }
                
                
                foreach (var policyGroupChild in rootPolicyChildren.Children)
                {
                    var policyGroupMatch = policyGroupHeaderRegex.Match(policyGroupChild.Header);
                    if (policyGroupMatch.Success)
                    {
                        var policyGroupKey = policyGroupMatch.Groups["name"].Value;
                        if (policyGroups.ContainsKey(policyGroupKey) == false)
                        {
                            continue;
                        }

                        var policyGroup = policyGroups[policyGroupKey];
                        
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
                    var policyGroupName = policyGroupNameMatch.Groups["policy_group_name"].Value;
                    if (policyGroups.ContainsKey(policyGroupName) == false)
                    {
                        continue;
                    }

                    var policyGroup = policyGroups[policyGroupName];
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
                            policy.Markdown = rootPolicyChildrenChildren.GenerateMarkdown();
                            policy.Summary = rootPolicyChildrenChildren.GetSummary();
                        }
                    }
                }
            }
        }
        
        //Debugger.Break();
        
        /*
        var buffer = new List<string>();
        for (var i = 0; i < lines.Length; ++i)
        {
            var line = lines[i];
            
            var match = headerRegex.Match(line);
            if (match.Success)
            {
                if (buffer.Any())
                {
                    markdownSections.Add(buffer[0].Trim(), string.Join("\n", buffer));
                    buffer.Clear();
                }

                // Some sections have a space before the hash, lets tidy that up to parse easier in the future.
                buffer.Add(line.Trim());
            }
            else
            {
                if (buffer.Any())
                {
                    buffer.Add(line);
                }
            }
        }
        
        var availablePolciesKey = "## Available policies";
        if (markdownSections.ContainsKey(availablePolciesKey) == false)
        {
            // Couldn't load any policies.
            return new Dictionary<string, PolicyGroup>();
        }
        var availablePolicies = markdownSections[availablePolciesKey];
        var policyGroupsRegex = new Regex(@"^### \[\*(?<name>.*)\*\]\(#(?<link>.*)\)$", RegexOptions.Multiline);
        var policyGroupTitleMatches = policyGroupsRegex.Matches(availablePolicies);

        var policyGroupSummaryRegex = new Regex(@"^\|\[(?<id>.*)\]\(#(?<link>.*)\)\|(?<name>.*)\|$", RegexOptions.Multiline);
        
        for (int i = 0; i < policyGroupTitleMatches.Count; ++i)
        {
            var match = policyGroupTitleMatches[i];
            var policyGroup = new PolicyGroup()
            {
                Name = match.Groups["name"].Value,
                Link = match.Groups["link"].Value
            };
            policyGroups.Add(policyGroup.Link, policyGroup);

            var policyGroupLength = availablePolicies.Length - match.Index;
            if (i < policyGroupTitleMatches.Count - 1)
            {
                policyGroupLength = policyGroupTitleMatches[i + 1].Index - match.Index;
            }
            
            var policyGroupSummary = availablePolicies.Substring(match.Index, policyGroupLength);
            var policyGroupSummaryMatches = policyGroupSummaryRegex.Matches(policyGroupSummary);
            foreach (Match policyGroupSummaryMatch in policyGroupSummaryMatches)
            {
                var policy = new Policy()
                {
                    Id = policyGroupSummaryMatch.Groups["id"].Value,
                    Name = policyGroupSummaryMatch.Groups["name"].Value,
                    Link = policyGroupSummaryMatch.Groups["link"].Value,
                };
                policyGroup.Policies.Add(policy.Link, policy);

                var fsfd = markdownSections;
                Debugger.Break();
                //markdownSections
            }
        }
        */
        
        return policyGroups;
    }
}