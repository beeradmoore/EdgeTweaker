using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Maui.Storage;

namespace EdgeTweaker.PolicyParser;

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
        
        using (var stream = await FileSystem.OpenAppPackageFileAsync("microsoft-edge-policies.md"))
        {
            using (var reader = new StreamReader(stream))
            {
                markdown = await reader.ReadToEndAsync();
            }
        }
        
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
        
        Debugger.Break();

        
        
        
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
        
        return policyGroups;
    }
}