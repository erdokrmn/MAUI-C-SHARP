using Gib.View;
using Gib.ViewModel;

namespace Gib;

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
        //view
        builder.Services.AddTransient<Register>();
        builder.Services.AddTransient<MainLayout>();
        builder.Services.AddSingleton<MainPage>();


        //viewmodel
        builder.Services.AddSingleton<UserRegisterViewModel>();
        builder.Services.AddSingleton<UserLoginViewModel>();

        return builder.Build();
	}
}
