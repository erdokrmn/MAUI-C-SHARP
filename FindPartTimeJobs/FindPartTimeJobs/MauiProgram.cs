using FindPartTimeJobs.Services;
using FindPartTimeJobs.ViewModel;

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
        builder.Services.AddSingleton<UserViewModel>();
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
	}
}
