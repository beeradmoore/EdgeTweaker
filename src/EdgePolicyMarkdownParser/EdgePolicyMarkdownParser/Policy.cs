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
    
    [JsonPropertyName("platform_windows")]
    public bool PlatformWindows { get; set; } = false;
    
    [JsonPropertyName("platform_macos")]
    public bool PlatformMacOS { get; set; } = false;
    
    [JsonPropertyName("can_be_manditory")]
    public bool CanBeManditory { get; set; } = false;
    
    [JsonPropertyName("can_be_recommended")]
    public bool CanBeRecommended { get; set; } = false;
    
    [JsonPropertyName("per_profile")]
    public bool PerProfile { get; set; } = false;
    
    [JsonPropertyName("dynamic_policy_refresh")]
    public bool DynamicPolicyRefresh { get; set; } = false;
    
    [JsonPropertyName("applies_to_signed_in_profile")]
    public bool AppliesToSignedInProfile { get; set; } = false;
    
    
    
    
    
    public override string ToString()
    {
        return Name;
    }
    
}