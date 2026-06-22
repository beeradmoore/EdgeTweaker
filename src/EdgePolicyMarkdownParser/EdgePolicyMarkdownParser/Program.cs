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
	// var policyGroupDocument = edgePolicyParser.LoadPolicyGroupDocument();

	var policyGroupDocument = edgePolicyParser.ParseRootPolicyFile();
	await edgePolicyParser.DownloadAllPoliciesAsync();
	edgePolicyParser.ParseSubPolicyFiles(policyGroupDocument);


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


    // Create reg cleanup for Windows
    var regCleanupStringBuilder = new LFStringBuilder();
    regCleanupStringBuilder.AppendLine("Windows Registry Editor Version 5.00");
    regCleanupStringBuilder.AppendLine();
    regCleanupStringBuilder.AppendLine("; Created with EdgeTweaker");
    regCleanupStringBuilder.AppendLine("; https://beeradmoore.github.io/EdgeTweaker/");
    regCleanupStringBuilder.AppendLine();

    var registryCleanupDirectory = new Dictionary<string, List<string>>();
    var registryCleanupSubKeyList = new List<string>();
    foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
    {
        foreach (var policy in policyGroup.Policies.Values)
        {
	        var windowsRegistryMandatoryPath = policy.WindowsRegistryMandatoryPath;
	        if (windowsRegistryMandatoryPath == "N/A")
	        {
		        windowsRegistryMandatoryPath = string.Empty;
	        }

	        var windowsRegistryRecommendedPath = policy.WindowsRegistryRecommendedPath;
	        if (windowsRegistryRecommendedPath == "N/A")
	        {
		        windowsRegistryRecommendedPath = string.Empty;
	        }

            if (policy.PlatformWindows == true)
            {
                if (policy.DataType == "list_of_strings")
                {
                    if (string.IsNullOrEmpty(windowsRegistryMandatoryPath) == false )
                    {
                        registryCleanupSubKeyList.Add(windowsRegistryMandatoryPath);
                    }

                    if (string.IsNullOrEmpty(windowsRegistryRecommendedPath) == false)
                    {
                        registryCleanupSubKeyList.Add(windowsRegistryRecommendedPath);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(windowsRegistryMandatoryPath) == false)
                    {
                        if (registryCleanupDirectory.ContainsKey(windowsRegistryMandatoryPath) == false)
                        {
                            registryCleanupDirectory[windowsRegistryMandatoryPath] = new List<string>();
                        }

                        registryCleanupDirectory[windowsRegistryMandatoryPath].Add(policy.WindowsRegistryValueName);
                    }

                    if (string.IsNullOrEmpty(windowsRegistryRecommendedPath) == false)
                    {
                        if (registryCleanupDirectory.ContainsKey(windowsRegistryRecommendedPath) == false)
                        {
                            registryCleanupDirectory[windowsRegistryRecommendedPath] = new List<string>();
                        }

                        registryCleanupDirectory[windowsRegistryRecommendedPath].Add(policy.WindowsRegistryValueName);
                    }

                    if (string.IsNullOrEmpty(policy.WindowsRegistryValueName))
                    {
                        Debugger.Break();
                    }
                }
            }
        }
    }

    foreach (var regKey in registryCleanupSubKeyList)
    {
        regCleanupStringBuilder.AppendLine($"[-HKEY_CURRENT_USER\\{regKey}]");
    }

    regCleanupStringBuilder.AppendLine();

    foreach (var (regKey, regNames) in registryCleanupDirectory)
    {
        regCleanupStringBuilder.AppendLine($"[HKEY_CURRENT_USER\\{regKey}]");
        foreach (var regName in regNames)
        {
            regCleanupStringBuilder.AppendLine($"\"{regName}\"=-");
        }
        regCleanupStringBuilder.AppendLine();
    }

    File.WriteAllText(Path.Combine(edgePolicyParser.OutputPath, "windows", "EdgeRegCleanup.reg"), regCleanupStringBuilder.ToString());


    var markdownSharp = new Markdown();

    foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
    {
        foreach (var policy in policyGroup.Policies.Values)
        {
            var htmlDoc = markdownSharp.Transform(policy.Markdown);
            var outputFile = Path.Combine(htmlDirectory, $"{policyGroup.Link}_{policy.Link.Replace("microsoft-edge-policies/", string.Empty)}.html");
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
