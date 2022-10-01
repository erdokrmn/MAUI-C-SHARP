using Gib.ViewModel;

namespace Gib.View;

public partial class Login : ContentPage
{
	public Login(UserLoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
	protected override void OnDisappearing()
	{
		base.OnDisappearing();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		OnDisappearing();
	}
}