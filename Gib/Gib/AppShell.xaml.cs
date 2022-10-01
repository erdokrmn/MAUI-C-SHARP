using Gib.View;

namespace Gib;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("Register", typeof(Register));
        Routing.RegisterRoute("Login", typeof(Login));
        Routing.RegisterRoute("MainFlyout", typeof(MainFlyout));
        
    }
}
