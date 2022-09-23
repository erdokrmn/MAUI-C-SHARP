﻿using Gib.View;

namespace Gib;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Register), typeof(Register));
        Routing.RegisterRoute(nameof(MainLayout), typeof(MainLayout));
    }
}
