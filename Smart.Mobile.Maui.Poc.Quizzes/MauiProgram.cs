using System.Reflection;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Smart.Mobile.Config;
using Smart.Mobile.DomainData.Storage;
using Smart.Mobile.Storage;

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
		
		builder.Services.AddTransient<ISqliteService, SqliteService>()
			.AddSingleton<IConnectivity>(Connectivity.Current)
			.AddSingleton(WebAuthenticator.Default)
			.AddSingleton(SecureStorage.Default)
			.AddRefitClient<IUserProfileService>()
			.AddSingleton<AuthService>()
			.AddSingleton<JWTService>()
			.AddTransient<LoginViewModel>()
			.AddTransient<Login>()


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}