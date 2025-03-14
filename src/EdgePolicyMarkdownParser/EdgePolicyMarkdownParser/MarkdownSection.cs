using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace EdgePolicyMarkdownParser;

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

    public string GenerateMarkdown()
    {
        var stringBuilder = new LFStringBuilder();
        stringBuilder.AppendLine(Header);
        foreach (var data in Data)
        {
            stringBuilder.AppendLine(data);
        }
        foreach (var child in Children)
        {
            stringBuilder.AppendLine(child.GenerateMarkdown());
        }

        return stringBuilder.ToString();
    }

    public string GetSummary()
    {
        if (Children.Any() == false)
        {
            return string.Empty;
        }

        var descriptionChild = Children.FirstOrDefault(c => c.Header.Contains("Description", StringComparison.Ordinal));
        if (descriptionChild is null)
        {
            return string.Empty;
        }
        
        foreach (var data in descriptionChild.Data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                continue;
            }

            var summary = data.Trim();
            summary = Regex.Replace(summary, @"\[(?<name>.*?)\]\((.*?)\)", "${name}");
            return summary;
        }

        return string.Empty;
    }

}