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

    [JsonPropertyName("markdown")]
    public string Markdown { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }
    
}