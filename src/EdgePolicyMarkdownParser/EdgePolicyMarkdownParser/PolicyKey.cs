namespace EdgePolicyMarkdownParser;

public class PolicyKey
{
	public string Key { get; init; }
	public string Link { get; init; }
	public string Title { get; init; }

	public PolicyKey(string key, string link, string title)
	{
		Key = key;
		Link = link;
		Title = title;
	}
}
