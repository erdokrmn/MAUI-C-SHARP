using FindPartTimeJobs.View;
using FindPartTimeJobs.ViewModel;

namespace FindPartTimeJobs;

public partial class MainPage : ContentPage
{
	public MainPage(UserLoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;

    }
}

