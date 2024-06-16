using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EdgeTweaker.PolicyParser;

namespace EdgeTweaker.Pages;

public partial class MainPageModel : ObservableObject
{
    WeakReference<MainPage> weakPage;
    Dictionary<string, PolicyGroup> policyGroups = new Dictionary<string, PolicyGroup>();
    
    [ObservableProperty]
    PolicyGroup? selectedPolicyGroup;
    
    [ObservableProperty]
    Policy? selectedPolicy;
    
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
            
        }
    }
}