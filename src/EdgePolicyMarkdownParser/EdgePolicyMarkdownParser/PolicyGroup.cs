using System.Text.Json.Serialization;

namespace EdgePolicyMarkdownParser;

public class PolicyGroup
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("link")]
    public string Link { get; set; } = string.Empty;

    [JsonPropertyName("policies")]
    public Dictionary<string, Policy> Policies { get; } = new Dictionary<string, Policy>();
    
    public override string ToString()
    {
        return Name;
    }
}