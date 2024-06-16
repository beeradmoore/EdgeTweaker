namespace EdgeTweaker.PolicyParser;

public class MarkdownSection
{
    public int Depth { get; set; } = 0;
    public string Header { get; set; } = string.Empty;
    public List<string> Data { get; set; } = new List<string>();
    public List<MarkdownSection> Children { get; set; } = new List<MarkdownSection>();
    public MarkdownSection? Parent { get; set; } = null;

    public override string ToString()
    {
        return Header;
    }
}