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
        builder.Services.AddTransient<Login>();
        builder.Services.AddSingleton<MainFlyout>();




        //viewmodel
        builder.Services.AddTransient<UserRegisterViewModel>();
        builder.Services.AddTransient<UserLoginViewModel>();
        builder.Services.AddTransient<MainFlyoutViewModel>();

        return builder.Build();
	}
}
