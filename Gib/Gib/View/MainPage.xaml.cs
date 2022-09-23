using Gib.ViewModel;

namespace Gib;

public partial class MainPage : ContentPage
{
	public MainPage(UserLoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		
	}

}

