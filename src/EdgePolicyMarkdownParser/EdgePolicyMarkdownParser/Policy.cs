using System.Text.Json.Serialization;

namespace EdgePolicyMarkdownParser;

public class Policy
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = string.Empty;

    [JsonPropertyName("data_type")]
    public string DataType { get; set; } = string.Empty;

    [JsonPropertyName("markdown")]
    public string Markdown { get; set; } = string.Empty;

    [JsonPropertyName("summary")]
    public string Summary { get; set; } = string.Empty;

    [JsonPropertyName("platform_windows")]
    public bool PlatformWindows { get; set; } = false;

    [JsonPropertyName("platform_macos")]
    public bool PlatformMacOS { get; set; } = false;

    [JsonPropertyName("platform_android")]
    public bool PlatformAndroid { get; set; } = false;

    [JsonPropertyName("platform_ios")]
    public bool PlatformiOS { get; set; } = false;

    [JsonPropertyName("can_be_mandatory")]
    public bool CanBeMandatory { get; set; } = false;

    [JsonPropertyName("can_be_recommended")]
    public bool CanBeRecommended { get; set; } = false;

    [JsonPropertyName("per_profile")]
    public bool PerProfile { get; set; } = false;

    [JsonPropertyName("dynamic_policy_refresh")]
    public bool DynamicPolicyRefresh { get; set; } = false;

    [JsonPropertyName("dynamic_policy_refresh_requires_browser_restart")]
    public bool DynamicPolicyRefreshRequiresBrowserRestart { get; set; } = false;

    [JsonPropertyName("applies_to_signed_in_profile")]
    public bool AppliesToSignedInProfile { get; set; } = false;

    [JsonPropertyName("can_only_be_configured_through_cloud_policy_in_edge_management_service")]
    public bool CanOnlyBeConfiguredThroughCloudPolicyInEdgeManagementService { get; set; } = false;

    [JsonPropertyName("windows_registry_mandatory_path")]
    public string WindowsRegistryMandatoryPath { get; set; } = string.Empty;

    [JsonPropertyName("windows_registry_recommended_path")]
    public string WindowsRegistryRecommendedPath { get; set; } = string.Empty;

    [JsonPropertyName("windows_registry_value_name")]
    public string WindowsRegistryValueName { get; set; } = string.Empty;

    [JsonPropertyName("windows_registry_value_type")]
    public string WindowsRegistryValueType { get; set; } = string.Empty;

    [JsonPropertyName("windows_registry_example_value")]
    public string WindowsRegistryExampleValue { get; set; } = string.Empty;

    [JsonPropertyName("macos_preference_key_name")]
    public string MacOSPreferenceKeyName { get; set; } = string.Empty;

    [JsonPropertyName("macos_preference_example_value")]
    public string MacOSPreferenceExampleValue { get; set; } = string.Empty;

    [JsonPropertyName("android_preference_key_name")]
    public string AndroidPreferenceKeyName { get; set; } = string.Empty;

    [JsonPropertyName("android_preference_example_value")]
    public string AndroidPreferenceExampleValue { get; set; } = string.Empty;

    [JsonPropertyName("ios_preference_key_name")]
    public string iOSPreferenceKeyName { get; set; } = string.Empty;

    [JsonPropertyName("ios_preference_example_value")]
    public string iOSPreferenceExampleValue { get; set; } = string.Empty;

    [JsonPropertyName("supported")]
    public bool Supported { get; set; } = false;

    //[JsonPropertyName("policy_mapping")]
    //public Dictionary<string, string> PolicyMapping { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("policy_option_mapping")]
    public List<PolicyOptionMappingItem> PolicyOptionMapping { get; set; } = new List<PolicyOptionMappingItem>();

    [JsonPropertyName("warnings")]
    public List<string> Warnings { get; set; } = new List<string>();

    [JsonIgnore]
    public string LocalFile { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }

}
