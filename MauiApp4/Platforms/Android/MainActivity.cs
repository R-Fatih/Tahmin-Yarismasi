using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using OneSignalSDK.DotNet;

namespace MauiApp4;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]

public class MainActivity : MauiAppCompatActivity
{


    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        OneSignal.Default.Initialize("a6b5fc88-8cb1-40a6-9ac2-d3225f3e1140");
        OneSignal.Default.PromptForPushNotificationsWithUserResponse();
#if DEBUG
        Platforms.Android.DangerousTrustProvider.Register();
#endif
	}


}