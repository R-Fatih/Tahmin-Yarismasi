using OneSignalSDK.DotNet;

namespace MauiApp4;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();



		//OneSignal.Default.Initialize("a6b5fc88-8cb1-40a6-9ac2-d3225f3e1140");
		//OneSignal.Default.PromptForPushNotificationsWithUserResponse();
	}
}
