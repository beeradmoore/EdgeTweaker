using System.Text.Json;
using System.Text.RegularExpressions;
using EdgePolicyMarkdownParser;

try
{
    var markdown = string.Empty;
    var markdownFile = "microsoft-edge-policies.md";
    using (var memoryStream = new MemoryStream())
    {
        if (File.Exists(markdownFile))
        {
            using (var fileStream = File.OpenRead(markdownFile))
            {
                await fileStream.CopyToAsync(memoryStream);
            }
        }
        else
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
    var policyGroups = new Dictionary<string, PolicyGroup>();
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
                    }
                }
            }
        }
    }
    
    
    var jsonSerializerOptions = new JsonSerializerOptions()
    {
        WriteIndented = true
    };
    var policyGroupsJson = JsonSerializer.Serialize(policyGroups, jsonSerializerOptions);
    await File.WriteAllTextAsync("policy_groups.json", policyGroupsJson);
}
catch (Exception err)
{
    Console.WriteLine($"Error: {err.Message}");
    return 1;
}

Console.WriteLine("Done");

return 0;