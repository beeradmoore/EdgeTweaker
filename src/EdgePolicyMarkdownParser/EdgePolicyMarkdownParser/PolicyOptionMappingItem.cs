using System.Text.Json.Serialization;

namespace EdgePolicyMarkdownParser;

public class PolicyOptionMappingItem
{
	[JsonPropertyName("value")]
	public string Value { get; set; } = string.Empty;

	[JsonPropertyName("name")]
	public string Name { get; set; } = string.Empty;

	[JsonPropertyName("description")]
	public string Description { get; set; } = string.Empty;
}
