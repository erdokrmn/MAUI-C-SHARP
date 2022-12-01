using Gib.ViewModel;

namespace Gib.View;

public partial class Login : ContentPage
{
	public Login(UserLoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
	
}