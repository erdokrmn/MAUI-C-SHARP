using FindPartTimeJobs.View;

namespace FindPartTimeJobs;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Register), typeof(Register));
	}
}
