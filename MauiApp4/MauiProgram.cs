using Microsoft.Extensions.Logging;
using MauiApp4.Data;
using Plugin.LocalNotification;

namespace MauiApp4;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			//.UseLocalNotification()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();


#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		//#if IOS
		//using Plugin.Firebase.iOS;
		//#else
		//        using Plugin.Firebase.Android;
		//#endif
#if ANDROID && DEBUG
		Platforms.Android.DangerousTrustProvider.Register();
#endif
		builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
	}
}
