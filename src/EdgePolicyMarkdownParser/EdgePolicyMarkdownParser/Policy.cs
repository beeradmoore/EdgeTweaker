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
    
    [JsonPropertyName("can_be_mandatory")]
    public bool CanBeMandatory { get; set; } = false;
    
    [JsonPropertyName("can_be_recommended")]
    public bool CanBeRecommended { get; set; } = false;
    
    [JsonPropertyName("per_profile")]
    public bool PerProfile { get; set; } = false;
    
    [JsonPropertyName("dynamic_policy_refresh")]
    public bool DynamicPolicyRefresh { get; set; } = false;
    
    [JsonPropertyName("applies_to_signed_in_profile")]
    public bool AppliesToSignedInProfile { get; set; } = false;
    
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

    [JsonPropertyName("supported")]
    public bool Supported { get; set; } = false;

    public override string ToString()
    {
        return Name;
    }
    
}