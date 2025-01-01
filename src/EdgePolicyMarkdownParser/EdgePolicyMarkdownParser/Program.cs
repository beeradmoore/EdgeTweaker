using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using EdgePolicyMarkdownParser;
using MarkdownSharp;


var edgePolicyParser = new EdgePolicyParser();
await edgePolicyParser.DownloadOrUpdatePolicyAsync();
try
{
    var policyGroupDocument = edgePolicyParser.LoadPolicyGroupDocument();

    // This will throw exception if something is not right.
    policyGroupDocument.ValidatePolicyGroups();

    var jsonSerializerOptions = new JsonSerializerOptions()
    {
        WriteIndented = true,
        NewLine = "\n",
    };

    var policyGroupsJson = JsonSerializer.Serialize(policyGroupDocument, jsonSerializerOptions);
    await File.WriteAllTextAsync(Path.Combine(edgePolicyParser.OutputPath, "policy-groups.json"), policyGroupsJson);

    var htmlDirectory = Path.Combine(edgePolicyParser.OutputPath, "html");
    if (Directory.Exists(htmlDirectory) == false)
    {
        Directory.CreateDirectory(htmlDirectory);
    }
    
    var markdownSharp = new Markdown();

    foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
    {
        foreach (var policy in policyGroup.Policies.Values)
        {
            var htmlDoc = markdownSharp.Transform(policy.Markdown);
            // Bad way to do this, but oh well.
            htmlDoc = htmlDoc.Replace("<p><a href=\"#microsoft-edge---policies\">Back to top</a></p>", string.Empty);
            var outputFile = Path.Combine(htmlDirectory, $"{policyGroup.Link}_{policy.Link}.html");
            File.WriteAllText(outputFile, htmlDoc);
            policy.Markdown = string.Empty;
        }
    }
    
    policyGroupsJson = JsonSerializer.Serialize(policyGroupDocument, jsonSerializerOptions);
    await File.WriteAllTextAsync(Path.Combine(edgePolicyParser.OutputPath, "policy-groups-min.json"), policyGroupsJson);
}
catch (Exception err)
{
    Console.WriteLine($"ERROR: {err.Message}");
    return 1;
}

var policiesNotChecked = SupportedPolicies.PoliciesNotCheckedForSupport();
if (policiesNotChecked.Any())
{
    Console.WriteLine();
    Console.WriteLine("WARNING: The following policies are not checked for support, maybe they were removed.");
    foreach (var policy in policiesNotChecked)
    {
        Console.WriteLine($"- {policy}");
    }
    Console.WriteLine();
}

Console.WriteLine("Done");
return 0;
