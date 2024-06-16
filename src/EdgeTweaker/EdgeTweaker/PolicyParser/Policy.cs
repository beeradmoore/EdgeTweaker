
namespace EdgeTweaker.PolicyParser;

public class Policy
{
    public string Id { get; set; } = string.Empty;
    
    public string Name { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }
}