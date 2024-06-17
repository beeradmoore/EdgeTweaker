using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EdgeTweaker.PolicyParser;
using MarkdownSharp;

namespace EdgeTweaker.Pages;

public partial class MainPageModel : ObservableObject
{
    WeakReference<MainPage> weakPage;
    Dictionary<string, PolicyGroup> policyGroups = new Dictionary<string, PolicyGroup>();
    
    [ObservableProperty]
    PolicyGroup? selectedPolicyGroup;
    
    [ObservableProperty]
    Policy? selectedPolicy;

    [ObservableProperty]
    WebViewSource markdownSource = new HtmlWebViewSource();
    
    Markdown markdown = new Markdown();

    
    public ObservableCollection<PolicyGroup> PolicyGroupsCollection { get; } = new ObservableCollection<PolicyGroup>();
    public ObservableCollection<Policy> PolicyCollection { get; } = new ObservableCollection<Policy>();


    public MainPageModel(MainPage mainPage)
    {
        weakPage = new WeakReference<MainPage>(mainPage);

        LoadPolicies();
    }

    void LoadPolicies()
    {
        Task.Run(async () =>
        {
            var edgePolicyParser = new EdgePolicyParser();
            var loadedPolicyGroups = await edgePolicyParser.LoadPolicies();
            
            policyGroups.Clear();
            foreach (var policyGroup in loadedPolicyGroups)
            {
                policyGroups.Add(policyGroup.Key, policyGroup.Value);
                PolicyGroupsCollection.Add(policyGroup.Value);
            }

            SelectedPolicyGroup = PolicyGroupsCollection.FirstOrDefault();
        });
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        
        if (e.PropertyName == nameof(SelectedPolicyGroup))
        {
            SelectedPolicy = null;
            PolicyCollection.Clear();

            if (SelectedPolicyGroup?.Policies?.Any() == true)
            {
                foreach (var policy in SelectedPolicyGroup.Policies)
                {
                    PolicyCollection.Add(policy.Value);
                }
            }

            SelectedPolicy = PolicyCollection?.FirstOrDefault();
        }
        else if (e.PropertyName == nameof(SelectedPolicy))
        {
            var htmlWebViewSource = new HtmlWebViewSource();
            
            if (SelectedPolicy is not null)
            {
                //  <Setter Property="BackgroundColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource OffBlack}}"
                var html = @$"<!DOCTYPE html>
<html>
    <head>
        <link href=""https://fonts.googleapis.com/css2?family=Open+Sans&display=swap"" rel=""stylesheet"">
        <style>
            body {{
                font-family: 'Open Sans', sans-serif;
                color: #000000;
                background-color: #FFFFFF;
            }}

            a {{
                color: #696969;
                text-decoration: none;
            }}

            a:hover {{
                color: #696969;
                text-decoration: underline;
            }}
            
            @media (prefers-color-scheme: dark) {{
                body {{
                    color: #FFFFFF;
                    background-color: #1F1F1F;
                }}

                a {{
                    color: #696969;
                }}

                a:hover {{
                    color: #696969;
                }}
            }}
        </style>
    </head>
    <body>
        {markdown.Transform(SelectedPolicy?.Markdown)}
    </body>
</html>";
                htmlWebViewSource.Html = html;

            }
            
            MarkdownSource = htmlWebViewSource;
        }
    }

    [RelayCommand(AllowConcurrentExecutions = false)]
    async Task WebViewNavigatingAsync(WebNavigatingEventArgs args)
    {
        if (args.Url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || args.Url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {
            args.Cancel = true;
            await Browser.OpenAsync(args.Url);
        }
    }
}