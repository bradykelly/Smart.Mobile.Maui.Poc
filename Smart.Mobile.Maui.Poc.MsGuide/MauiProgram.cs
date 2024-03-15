using System.Reflection;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Smart.Mobile.Config;

namespace Smart.Mobile.Maui.Poc.MsGuide;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
//   <Smart.Mobile.Maui.Poc.MsGuide>\MauiProgram.cs:842 Argument type 'Microsoft.Extensions.Configuration.IConfigurationSection' is not assignable to parameter type 'System.Action<Smart.Mobile.Config.MobileQuizzOptions>'