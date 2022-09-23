using FindPartTimeJobs.ViewModel;
using Firebase.Storage;

namespace FindPartTimeJobs.View;

public partial class Register : ContentPage
{
    FirebaseStorage firebaseStorage = new FirebaseStorage("findparttimejobs-4e8b5.appspot.com");
    public Register(UserRegisterViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
		
		DateTime dateTime = DateTime.Now;
		dateTime.ToString("dd/MM/yyyy");

    }

	
}