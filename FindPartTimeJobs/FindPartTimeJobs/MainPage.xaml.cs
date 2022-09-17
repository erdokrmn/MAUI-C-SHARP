using FindPartTimeJobs.ViewModel;

namespace FindPartTimeJobs;

public partial class MainPage : ContentPage
{
	

	public MainPage(UserViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

