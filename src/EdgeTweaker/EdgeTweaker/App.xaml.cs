using EdgeTweaker.Pages;

namespace EdgeTweaker;

public partial class App : Application
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public static App CurrentApp { get; private set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    
    public string AppDataDirectory
    {
        get
        {
#if WINDOWS
			return FileSystem.AppDataDirectory;
#elif __MACCATALYST__
            var systemAppDataDirectory = FileSystem.AppDataDirectory;
#if DEBUG
            var appDataDirectory = Path.Combine(systemAppDataDirectory, "EdgeTweaker_Debug");
#else
			var appDataDirectory = Path.Combine(systemAppDataDirectory, "EdgeTweaker");
#endif
            if (Directory.Exists(appDataDirectory) == false)
            {
                Directory.CreateDirectory(appDataDirectory);
            }
            return appDataDirectory;
#endif

            throw new PlatformNotSupportedException();
        }
    }
    
    
    public App()
    {
        CurrentApp = this;
        
        InitializeComponent();
        
        //var edgePolicyParser = new EdgePolicyParser.EdgePolicyParser();
        //edgePolicyParser.UpdateLatestEdgeEnterprisePolicy();
        MainPage = new MainPage();
    }
}