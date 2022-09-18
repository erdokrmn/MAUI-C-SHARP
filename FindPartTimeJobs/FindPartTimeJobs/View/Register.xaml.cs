using FindPartTimeJobs.ViewModel;


namespace FindPartTimeJobs.View;

public partial class Register : ContentPage
{
	public Register(UserRegisterViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
		DateTime dateTime = DateTime.Now;
		dateTime.ToString("dd/MM/yyyy");

    }
}