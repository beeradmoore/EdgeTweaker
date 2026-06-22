using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
	private HttpClient _httpClient;


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

    public string PoliciesPath => Path.Combine(OutputPath, "markdown");

    public string MarkdownFilePath => Path.Combine(OutputPath, "microsoft-edge-policies.md");

    public string ETagsPath => "etags.json"; //Path.Combine(OutputPath, "etags.json");

    private List<PolicyKey> _newPolicies = new List<PolicyKey>();
    private List<PolicyKey> _deprecatedPolicies = new List<PolicyKey>();
    private List<PolicyKey> _obsoletePolicies = new List<PolicyKey>();
    private List<PolicyKey> _availablePolicies = new List<PolicyKey>();

    Dictionary<string, string> _eTags = new Dictionary<string, string>();

    private PolicyGroupDocument _policyGroupDocument = new PolicyGroupDocument();


    public EdgePolicyParser()
    {
        if (Directory.Exists(OutputPath) == false)
        {
            Directory.CreateDirectory(OutputPath);
        }

        Directory.CreateDirectory(PoliciesPath);

        if (File.Exists(ETagsPath))
        {
	        var etagData = File.ReadAllText(ETagsPath);
	        var eTags = JsonSerializer.Deserialize<Dictionary<string, string>>(etagData);
	        if (eTags is not null)
	        {
		        _eTags.Clear();
		        foreach (var eTag in eTags)
		        {
			        _eTags.Add(eTag.Key, eTag.Value);
		        }
	        }
        }

        _httpClient = new HttpClient();
    }

    internal async Task DownloadOrUpdatePolicyAsync()
    {
	    await DownloadFile("https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies?accept=text%2Fmarkdown", MarkdownFilePath);
    }

	async Task DownloadFile(string url, string outputPath)
    {
	    var needsDownload = false;
	    var eTag = string.Empty;
	    if (File.Exists(outputPath))
	    {
		    var fileInfo = new FileInfo(outputPath);
		    if ((DateTime.Now - fileInfo.LastWriteTime).TotalDays > 1)
		    {
			    needsDownload = true;
		    }
		    else
		    {
			    if (_eTags.TryGetValue(url, out var tag))
			    {
				    eTag = tag;
			    }
		    }
	    }

	    if (needsDownload == false)
	    {
		    return;
	    }


	    var request = new HttpRequestMessage(HttpMethod.Get, url);
	    if (string.IsNullOrEmpty(eTag) == false)
	    {
		    request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(eTag));
	    }

	    using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
	    {
		    if (response.StatusCode == HttpStatusCode.NotModified)
		    {
			    // Reset last write time.
			    var fileInfo = new FileInfo(outputPath);
			    fileInfo.LastWriteTime = DateTime.Now;

			    return;
		    }

		    response.EnsureSuccessStatusCode();

		    using (var memoryStream = new MemoryStream())
		    {
			    await using (var stream = await response.Content.ReadAsStreamAsync())
			    {
				    await stream.CopyToAsync(memoryStream);
			    }

			    if (string.IsNullOrWhiteSpace(response.Headers.ETag?.Tag) == false)
			    {
				    _eTags[url] = response.Headers.ETag.Tag;
			    }
			    else
			    {
				    _eTags.Remove(url);
			    }

			    await using (var fileStream = File.Create(ETagsPath))
			    {
				    await JsonSerializer.SerializeAsync(fileStream, _eTags, new JsonSerializerOptions { WriteIndented = true });
			    }

			    memoryStream.Position = 0;

			    await using (var fileStream = File.Create(outputPath))
			    {
				    await memoryStream.CopyToAsync(fileStream);
			    }
		    }
	    }
    }

    public PolicyGroupDocument ParseRootPolicyFile()
    {
	    var markdownFile = File.ReadAllText(MarkdownFilePath);

	    var updatedAtRegex = new Regex("^updated_at: (?<updated_at>.*)$", RegexOptions.Multiline | RegexOptions.Compiled);
		var updatedRegexMatch = updatedAtRegex.Match(markdownFile);

	    _policyGroupDocument = new PolicyGroupDocument()
	    {
		    LastUpdated = DateTime.Now.ToString("yyyy-MM-dd"),
		    PolicyDate = updatedRegexMatch.Groups["updated_at"].Value,
	    };


	    var newPoliciesKey = "## New policies";
	    var deprecatedPoliciesKey = "## Deprecated policies";
	    var obsoletePoliciesKey = "## Obsolete policies";
	    var availablePoliciesKey = "## Available policies";

	    var newPoliciesIndex = markdownFile.IndexOf(newPoliciesKey, StringComparison.OrdinalIgnoreCase);
	    var deprecatedPoliciesIndex = markdownFile.IndexOf(deprecatedPoliciesKey, StringComparison.OrdinalIgnoreCase);
	    var obsoletePoliciesIndex = markdownFile.IndexOf(obsoletePoliciesKey, StringComparison.OrdinalIgnoreCase);
	    var availablePoliciesIndex = markdownFile.IndexOf(availablePoliciesKey, StringComparison.OrdinalIgnoreCase);

	    if (newPoliciesIndex == -1 || deprecatedPoliciesIndex == -1 || obsoletePoliciesIndex == -1 || availablePoliciesIndex == -1)
	    {
		    throw new Exception("Markdown file is not in the expected format.");
	    }

	    var newPoliciesText = markdownFile.Substring(newPoliciesIndex, deprecatedPoliciesIndex - newPoliciesIndex);
	    var deprecatedPoliciesText = markdownFile.Substring(deprecatedPoliciesIndex, obsoletePoliciesIndex - deprecatedPoliciesIndex);
	    var obsoletePoliciesText = markdownFile.Substring(obsoletePoliciesIndex, availablePoliciesIndex - obsoletePoliciesIndex);
	    var availablePoliciesText = markdownFile.Substring(availablePoliciesIndex, markdownFile.Length - availablePoliciesIndex);

	    var tableRowsRegex = new Regex(@"^\| \[(?<id>.*)\]\((?<link>.*)\) \| (?<name>.*) \|\r$", RegexOptions.Multiline | RegexOptions.Compiled);

	    var newPoliciesMatches = tableRowsRegex.Matches(newPoliciesText);
		foreach (Match match in newPoliciesMatches)
		{
			_newPolicies.Add(new PolicyKey(match.Groups["id"].Value, match.Groups["link"].Value, match.Groups["name"].Value));
		}

		var obsoletePoliciesMatches = tableRowsRegex.Matches(obsoletePoliciesText);
		foreach (Match match in obsoletePoliciesMatches)
		{
			_obsoletePolicies.Add(new PolicyKey(match.Groups["id"].Value, match.Groups["link"].Value, match.Groups["name"].Value));
		}

		var deprecatedPoliciesMatches = tableRowsRegex.Matches(deprecatedPoliciesText);
		foreach (Match match in deprecatedPoliciesMatches)
		{
			_deprecatedPolicies.Add(new PolicyKey(match.Groups["id"].Value, match.Groups["link"].Value, match.Groups["name"].Value));
		}

		var availablePoliciesRegex = new Regex(@"^### (?<name>.*)\r$", RegexOptions.Multiline | RegexOptions.Compiled);
		var availablePoliciesHeaders = availablePoliciesRegex.Matches(availablePoliciesText);

		for (var i = 0; i < availablePoliciesHeaders.Count; ++i)
		{
			var startIndex = availablePoliciesHeaders[i].Index;
			var endIndex = i == availablePoliciesHeaders.Count - 1 ? availablePoliciesText.Length : availablePoliciesHeaders[i + 1].Index;

			var policyGroupSection = availablePoliciesText.Substring(startIndex, endIndex - startIndex);

			var policyGroup = new PolicyGroup()
			{
				Name = availablePoliciesHeaders[i].Groups["name"].Value,
				Link = availablePoliciesHeaders[i].Groups["name"].Value.Replace(' ', '-').ToLower(),
			};

			var policyGroupMatches = tableRowsRegex.Matches(policyGroupSection);
			foreach (Match match in policyGroupMatches)
			{
				var policy = new Policy()
				{
					Id = match.Groups["id"].Value,
					Name = match.Groups["name"].Value,
					Link = match.Groups["link"].Value,
				};

				policy.Supported = SupportedPolicies.IsSupported(policy.Id);

				policyGroup.Policies[match.Groups["id"].Value] = policy;
			}

			_policyGroupDocument.PolicyGroups.Add(policyGroup.Name, policyGroup);
		}

		return _policyGroupDocument;
    }

    internal async Task DownloadAllPoliciesAsync()
    {
	    foreach (var policyGroup in _policyGroupDocument.PolicyGroups)
	    {
		    foreach (var policy in policyGroup.Value.Policies)
		    {
			    Console.WriteLine($"Downloading: {policy.Value.Link}");
			    policy.Value.LocalFile = Path.Combine(PoliciesPath, $"{policyGroup.Value.Link}_{policy.Key.ToLower().Replace("microsoft-edge-policies/", "")}.md");
			    await DownloadFile($"https://learn.microsoft.com/en-us/deployedge/{policy.Value.Link}?accept=text%2Fmarkdown", policy.Value.LocalFile);
		    }
	    }
    }


    internal void ParseSubPolicyFiles(PolicyGroupDocument policyGroupDocument)
    {

        //var policyRegex = new Regex(@"^\- \[(?<name>.*)\]\(#(?<link>.*)\)$");
        //var policyGroups = new Dictionary<string, PolicyGroup>();
        //var headerRegex = new Regex(@"^(\s*)##\s+(?<header>.*)$");
        var hashDepthRegex = new Regex(@"^( *)(?<hash_depth>#+)");
        var policyMappingShortRegex = new Regex(@"^- (?<value>.*) = (?<description>.*)$", RegexOptions.Compiled);
        var policyMappingLongRegex = new Regex(@"^- (?<name>.*) \((?<value>.*?)\) = (?<description>.*)$", RegexOptions.Compiled);
        var windowsExampleRegex = new Regex(@"^SOFTWARE\\(.*) = (?<json_dictionary>(.|\n)*)$");
        var windowsListOfStringsExampleRegex = new Regex(@"^SOFTWARE\\(.*) = (?<example_value>.*)$");
		var policyHeaderRegex = new Regex(@"^---\n(?<header>[\s\S]*)^---$\n\n(?<markdown>[\s\S]*)", RegexOptions.Compiled | RegexOptions.Multiline);
        var sectionRegex = new Regex("^## (?<title>.*)$",  RegexOptions.Multiline | RegexOptions.Compiled);

        foreach (var policyGroup in policyGroupDocument.PolicyGroups.Values)
        {
	        foreach (var policy in policyGroup.Policies.Values)
	        {
		        var policyText = File.ReadAllText(policy.LocalFile);

		        var policyHeaderMatch = policyHeaderRegex.Match(policyText);
		        if (policyHeaderMatch.Success)
		        {
			        policy.Markdown = policyHeaderMatch.Groups["markdown"].Value;
		        }
		        else
		        {
			        Debugger.Break();
		        }

		        var matches = sectionRegex.Matches(policyText);
		        for (var i = 0; i < matches.Count; ++i)
		        {
			        var currentMatch = matches[i];
			        var currentMatchEndIndex = i == matches.Count - 1 ? policyText.Length : matches[i + 1].Index - 1;

			        var sectionText = policyText.Substring(currentMatch.Index, currentMatchEndIndex - currentMatch.Index).Trim();
			        var sectionTitle = currentMatch.Groups["title"].Value.Trim();
			        var sectionTextWithoutTitle = sectionText.Replace($"## {sectionTitle}", string.Empty).Trim();
			        if (sectionTitle == "Supported versions")
			        {
				        // TODO: New information.
			        }
			        else if (sectionTitle == "Description")
			        {
				        var indexOfStart = sectionText.IndexOf("\r\n", StringComparison.InvariantCultureIgnoreCase);
				        if (indexOfStart == -1)
				        {
					        throw new Exception("Could not find correct place to start summary.");
				        }

				        policy.Summary = sectionText.Substring(indexOfStart).Trim();
			        }
			        else if (sectionTitle == "Supported features")
			        {
				        var sectionLines = sectionText.Split('\n');

				        foreach (var sectionLine in sectionLines)
				        {
					        var trimmedSectionLine = sectionLine.TrimEnd('\r');

					        // Skip title
					        if (trimmedSectionLine == "## Supported features")
					        {
						        continue;
					        }

					        // Skip blank lines
					        if (trimmedSectionLine == string.Empty)
					        {
						        continue;
					        }

					        if (trimmedSectionLine == "- Can be mandatory: Yes")
					        {
						        policy.CanBeMandatory = true;
					        }
					        else if (trimmedSectionLine == "- Can be mandatory: No")
					        {
						        policy.CanBeMandatory = false;
					        }
					        else if (trimmedSectionLine == "- Can be recommended: Yes")
					        {
						        policy.CanBeRecommended = true;
					        }
					        else if (trimmedSectionLine == "- Can be recommended: No")
					        {
						        policy.CanBeRecommended = false;
					        }
					        else if (trimmedSectionLine == "- Dynamic Policy Refresh: Yes")
					        {
						        policy.DynamicPolicyRefresh = true;
					        }
					        else if (trimmedSectionLine == "- Dynamic Policy Refresh: No")
					        {
						        policy.DynamicPolicyRefresh = false;
					        }
					        else if (trimmedSectionLine == "- Dynamic Policy Refresh: No - Requires browser restart")
					        {
						        policy.DynamicPolicyRefresh = false;
						        policy.DynamicPolicyRefreshRequiresBrowserRestart = true;
					        }
					        else if (trimmedSectionLine == "- Per Profile: Yes")
					        {
						        policy.PerProfile = true;
					        }
					        else if (trimmedSectionLine == "- Per Profile: No")
					        {
						        policy.PerProfile = false;
					        }
					        else if (trimmedSectionLine == "- Applies to a profile that is signed in with a Microsoft account: Yes")
					        {
						        policy.AppliesToSignedInProfile = true;
					        }
					        else if (trimmedSectionLine == "- Applies to a profile that is signed in with a Microsoft account: No")
					        {
						        policy.AppliesToSignedInProfile = false;
					        }
					        else if (trimmedSectionLine == "- Can only be configured through cloud policy in the Edge management service: Yes")
					        {
						        policy.CanOnlyBeConfiguredThroughCloudPolicyInEdgeManagementService = true;
					        }
					        else if (trimmedSectionLine == "- Can only be configured through cloud policy in the Edge management service: No")
					        {
						        policy.CanOnlyBeConfiguredThroughCloudPolicyInEdgeManagementService = false;
					        }
					        else
					        {
						        Console.WriteLine($"Unknown section line: {sectionLine}");
						        Debugger.Break();
					        }
				        }
			        }
			        else if (sectionTitle == "Data type")
			        {
				        var dataTypeRegex = new Regex(@"^- (?<data_type>.*)$",  RegexOptions.Multiline | RegexOptions.Compiled);
				        var dataTypeMatch = dataTypeRegex.Match(sectionText);
				        if (dataTypeMatch.Success)
				        {
					        policy.DataType = dataTypeMatch.Groups["data_type"].Value switch
					        {
						        "Dictionary" => "dictionary",
						        "Boolean" => "boolean",
						        "String" => "string",
						        "List of strings" => "list_of_strings",
						        "Integer" => "integer",
						        _ => throw new Exception($"Unknown data type {policy.Link}")
					        };
				        }
				        else
				        {
					        Debugger.Break();
				        }
			        }
			        else if (sectionTitle == "Windows information and settings")
			        {
				        policy.PlatformWindows = true;

				        var groupPolicyRegex = new Regex("^### Group Policy \\(ADMX\\) info\r$", RegexOptions.Multiline | RegexOptions.Compiled);
				        var registrySettingsRegex = new Regex("^### Registry settings\r$", RegexOptions.Multiline | RegexOptions.Compiled);

				        var groupPolicyMatch = groupPolicyRegex.Match(sectionTextWithoutTitle);
				        var registrySettingsMatch = registrySettingsRegex.Match(sectionTextWithoutTitle);

				        if (groupPolicyMatch.Success == false || registrySettingsMatch.Success == false)
				        {
					        Debugger.Break();
					        return;
				        }

				        var groupPolicySection = sectionTextWithoutTitle.Substring(groupPolicyMatch.Index, registrySettingsMatch.Index - groupPolicyMatch.Index);
				        var registrySettingsSection = sectionTextWithoutTitle.Substring(registrySettingsMatch.Index, sectionTextWithoutTitle.Length - registrySettingsMatch.Index);

				        var groupPolicyLines = groupPolicySection.Split("\r\n");
				        foreach (var groupPolicyLine in groupPolicyLines)
				        {
					        var trimmedLine = groupPolicyLine.Trim();

					        if (trimmedLine == string.Empty)
					        {
						        continue;
					        }

					        if (trimmedLine == "### Group Policy (ADMX) info")
					        {
						        continue;
					        }

					        if (trimmedLine.StartsWith("- GP unique name:"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
								// TODO
					        }
					        else if (trimmedLine.StartsWith("- GP name:"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        // TODO
					        }
					        else if (trimmedLine.StartsWith("- GP path (Mandatory):"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        // TODO
					        }
					        else if (trimmedLine.StartsWith("- GP path (Recommended):"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        // TODO
					        }
					        else if (trimmedLine.StartsWith("- GP ADMX file name:"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        // TODO
					        }
					        else if (trimmedLine == "#### Example value")
					        {
						        // If we got to the examples we are done.
						        break;
					        }
					        else
					        {
						        // Missing a GP type
						        Debugger.Break();
					        }
				        }

				        var groupPolicyExampleRegex = new Regex("^```(xml|)\r\n(?<example>[\\s\\S]*?)\r\n```",   RegexOptions.Multiline | RegexOptions.Compiled);
						var groupPolicyExampleMatch = groupPolicyExampleRegex.Match(groupPolicySection);
						if (groupPolicyExampleMatch.Success)
						{
							// TODO
						}
						else
						{
							Debugger.Break();
						}



				        var registrySettingsLines = registrySettingsSection.Split("\r\n");
				        foreach (var registrySettingsLine in registrySettingsLines)
				        {
					        var trimmedLine = registrySettingsLine.Trim();

					        if (trimmedLine == string.Empty)
					        {
						        continue;
					        }

					        if (trimmedLine == "### Registry settings")
					        {
						        continue;
					        }

					        if (trimmedLine.StartsWith("- Path (Mandatory):"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        if (value == "N\\A")
						        {
							        continue;
						        }
						        policy.WindowsRegistryMandatoryPath = value;
					        }
					        else if (trimmedLine.StartsWith("- Path (Recommended):"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        if (value == "N\\A")
						        {
							        continue;
						        }
						        policy.WindowsRegistryRecommendedPath = value;
					        }
					        else if (trimmedLine.StartsWith("- Value name:"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        if (value == "N\\A")
						        {
							        continue;
						        }
						        policy.WindowsRegistryValueName = value;
					        }
					        else if (trimmedLine.StartsWith("- Value type:"))
					        {
						        var value = trimmedLine.Substring(trimmedLine.IndexOf(':') + 1).Trim();
						        if (value == "N\\A")
						        {
							        continue;
						        }

						        var regitryType = value switch
						        {
							        "REG\\_SZ" => "REG_SZ",
							        "REG\\_DWORD" => "REG_DWORD",
							        "List of REG\\_SZ" => "List of REG_SZ",
							        _ => string.Empty,
						        };

						        if (string.IsNullOrEmpty(regitryType))
						        {
							        Debugger.Break();
						        }
					        }
					        else if (trimmedLine == "#### Example registry value")
					        {
						        // If we got to the examples we are done.
						        break;
					        }
					        else
					        {
						        // Missing a GP type
						        Debugger.Break();
					        }
				        }

				        var registrySettingExampleRegex = new Regex("^```(xml|)\r\n(?<example>[\\s\\S]*?)\r\n```",   RegexOptions.Multiline | RegexOptions.Compiled);
						var registrySettingExampleMatch = registrySettingExampleRegex.Match(registrySettingsSection);
						if (registrySettingExampleMatch.Success)
						{
							policy.WindowsRegistryExampleValue = registrySettingExampleMatch.Groups["example"].Value;
						}
						else
						{
							Debugger.Break();
						}

			        }
			        else if (sectionTitle == "Mac information and settings")
			        {
				        policy.PlatformMacOS = true;

				        var preferenceKeyNameRegex = new Regex("^- Preference Key name: (?<key_name>.*)\r$",   RegexOptions.Multiline | RegexOptions.Compiled);
				        var preferenceExampleRegex = new Regex("^```(xml|)\r\n(?<example>[\\s\\S]*?)\r\n```",   RegexOptions.Multiline | RegexOptions.Compiled);

				        var preferenceKeyNameMatch = preferenceKeyNameRegex.Match(sectionTextWithoutTitle);
				        if (preferenceKeyNameMatch.Success)
				        {
					        policy.MacOSPreferenceKeyName = preferenceKeyNameMatch.Groups["key_name"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }

				        var preferenceExampleMatch = preferenceExampleRegex.Match(sectionTextWithoutTitle);
				        if (preferenceExampleMatch.Success)
				        {
					        policy.MacOSPreferenceExampleValue = preferenceExampleMatch.Groups["example"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }
			        }
			        else if (sectionTitle == "Android information and settings")
			        {
				        policy.PlatformAndroid = true;

				        var preferenceKeyNameRegex = new Regex("^- Preference Key name: (?<key_name>.*)\r$",   RegexOptions.Multiline | RegexOptions.Compiled);
				        var preferenceExampleRegex = new Regex("^```(xml|)\r\n(?<example>[\\s\\S]*?)\r\n```",   RegexOptions.Multiline | RegexOptions.Compiled);

				        var preferenceKeyNameMatch = preferenceKeyNameRegex.Match(sectionTextWithoutTitle);
				        if (preferenceKeyNameMatch.Success)
				        {
					        policy.AndroidPreferenceKeyName = preferenceKeyNameMatch.Groups["key_name"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }

				        var preferenceExampleMatch = preferenceExampleRegex.Match(sectionTextWithoutTitle);
				        if (preferenceExampleMatch.Success)
				        {
					        policy.AndroidPreferenceExampleValue = preferenceExampleMatch.Groups["example"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }
			        }
			        else if (sectionTitle == "iOS information and settings")
			        {
				        policy.PlatformiOS = true;

				        var preferenceKeyNameRegex = new Regex("^- Preference Key name: (?<key_name>.*)\r$",   RegexOptions.Multiline | RegexOptions.Compiled);
				        var preferenceExampleRegex = new Regex("^```(xml|)\r\n(?<example>[\\s\\S]*?)\r\n```",   RegexOptions.Multiline | RegexOptions.Compiled);

				        var preferenceKeyNameMatch = preferenceKeyNameRegex.Match(sectionTextWithoutTitle);
				        if (preferenceKeyNameMatch.Success)
				        {
					        policy.iOSPreferenceKeyName = preferenceKeyNameMatch.Groups["key_name"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }

				        var preferenceExampleMatch = preferenceExampleRegex.Match(sectionTextWithoutTitle);
				        if (preferenceExampleMatch.Success)
				        {
					        policy.iOSPreferenceExampleValue = preferenceExampleMatch.Groups["example"].Value;
				        }
				        else
				        {
					        Debugger.Break();
				        }
			        }
			        else if (sectionTitle == "Policy options mapping:")
			        {

				        var sectionLines = sectionTextWithoutTitle.Split('\n');
				        foreach (var sectionLine in sectionLines)
				        {
					        var trimmedSectionLine = sectionLine.Trim();

					        if (trimmedSectionLine == string.Empty || trimmedSectionLine == ">" || trimmedSectionLine == "> Use this information when configuring this policy.")
					        {
						        continue;
					        }

					        // Some policies have extra info below each policy, skip them.
					        if (sectionLine.StartsWith("    - Windows:") || sectionLine.StartsWith("    - macOS:") || sectionLine.StartsWith("    - iOS") || sectionLine.StartsWith("    - Android:"))
					        {
						        continue;
					        }

					        var policyMappingMatch = policyMappingLongRegex.Match(trimmedSectionLine);
					        if (policyMappingMatch.Success)
					        {
						        policy.PolicyOptionMapping.Add(new PolicyOptionMappingItem()
						        {
							        Value = policyMappingMatch.Groups["value"].Value,
							        Name = policyMappingMatch.Groups["name"].Value,
							        Description = policyMappingMatch.Groups["description"].Value,
						        });
					        }
					        else
					        {
						        policyMappingMatch = policyMappingShortRegex.Match(trimmedSectionLine);
						        if (policyMappingMatch.Success)
						        {
							        policy.PolicyOptionMapping.Add(new PolicyOptionMappingItem()
							        {
								        Value = policyMappingMatch.Groups["value"].Value,
								        Description = policyMappingMatch.Groups["description"].Value,
							        });
						        }
						        else
						        {
							        Debugger.Break();
						        }
					        }
				        }
			        }
			        else
			        {
				        if (policy.Name != sectionTitle)
				        {
					        // Title that was set and the title we have are different.
					        Debugger.Break();
				        }
			        }
		        }
	        }
        }

		/*
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
        */

        if (string.IsNullOrEmpty(policyGroupDocument.PolicyDate))
        {
            throw new Exception("Policy date not found.");
        }

        if (policyGroupDocument.PolicyGroups.Count == 0)
        {
            throw new Exception("No policy groups loaded.");
        }
    }
}
