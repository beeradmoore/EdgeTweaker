using System.Text.Json.Serialization;

namespace EdgePolicyMarkdownParser;

public class PolicyGroupDocument
{
    [JsonPropertyName("policy_date")]
    public string PolicyDate { get; set; } = string.Empty;

    [JsonPropertyName("policy_groups")]
    public Dictionary<string, PolicyGroup> PolicyGroups { get; set; } = new Dictionary<string, PolicyGroup>();
}