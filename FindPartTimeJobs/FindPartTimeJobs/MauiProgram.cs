using FindPartTimeJobs.Services;
using FindPartTimeJobs.View;
using FindPartTimeJobs.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace FindPartTimeJobs;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton<UserService>();
        builder.Services.AddTransient<UserRegisterViewModel>();
        builder.Services.AddSingleton<UserLoginViewModel>();
        builder.Services.AddTransient<Register>();
        builder.Services.AddSingleton<MainPage>();
        //v6m0s9gs vcv8juf4
        return builder.Build();
	}
}
