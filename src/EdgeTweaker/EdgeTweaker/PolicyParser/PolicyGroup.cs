
namespace EdgeTweaker.PolicyParser;

public class PolicyGroup
{
    public string Name { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;

    public Dictionary<string, Policy> Policies { get; } = new Dictionary<string, Policy>();
    
    public override string ToString()
    {
        return Name;
    }
}