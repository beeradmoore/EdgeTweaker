using System.Text.Json.Serialization;

namespace EdgePolicyMarkdownParser;

public class PolicyGroupDocument
{
	[JsonPropertyName("policy_date")]
	public string PolicyDate { get; set; } = string.Empty;

	[JsonPropertyName("last_updated")]
	public string LastUpdated { get; set; } = string.Empty;

    [JsonPropertyName("policy_groups")]
    public Dictionary<string, PolicyGroup> PolicyGroups { get; set; } = new Dictionary<string, PolicyGroup>();

    /// <summary>
    /// Does some simple validation on the current policy document.
    /// </summary>
    /// <exception cref="Exception">Throws exception if some properties are not as expected</exception>
    public void ValidatePolicyGroups()
    {
        // Validate certain things that are assumed.
        foreach (var policyGroup in PolicyGroups.Values)
        {
            foreach (var policy in policyGroup.Policies.Values)
            {
                if (policy.CanBeMandatory == false && policy.CanBeRecommended == false)
                {
                    throw new Exception("At some point CanBeMandatory and CanBeRecommended were both false.");
                }

                if (policy.PlatformWindows)
                {
                    if (policy.CanBeRecommended == true && string.IsNullOrEmpty(policy.WindowsRegistryRecommendedPath) == true)
                    {
                        throw new Exception("Windows registry value can be recommended, but no path is defined.");
                    }

                    if (policy.CanBeMandatory == true && string.IsNullOrEmpty(policy.WindowsRegistryMandatoryPath) == true)
                    {
                        throw new Exception("Windows registry value can be mandatory, but no path is defined.");
                    }

                    if (policy.CanBeRecommended == true && policy.WindowsRegistryRecommendedPath.StartsWith(@"SOFTWARE\Policies\Microsoft\Edge") == false)
                    {
                        throw new Exception("Expected registry recommended path to begin with SOFTWARE\\Policies\\Microsoft\\Edge, but it didn't.");
                    }

                    if (policy.CanBeMandatory == true && policy.WindowsRegistryMandatoryPath.StartsWith(@"SOFTWARE\Policies\Microsoft\Edge") == false)
                    {
                        throw new Exception("Expected registry mandatory path to begin with SOFTWARE\\Policies\\Microsoft\\Edge, but it didn't.");
                    }
                }

                if (policy.PlatformMacOS)
                {
                    if (string.IsNullOrEmpty(policy.MacOSPreferenceExampleValue))
                    {
                        throw new Exception("macOS example value is empty.");
                    }

                    if (string.IsNullOrEmpty(policy.MacOSPreferenceKeyName))
                    {
                        throw new Exception("macOS Preference key name is empty.");
                    }
                }
            }
        }
    }
}
