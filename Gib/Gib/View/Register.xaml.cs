using Gib.ViewModel;

namespace Gib.View;

public partial class Register : ContentPage
{
	public Register(UserRegisterViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}