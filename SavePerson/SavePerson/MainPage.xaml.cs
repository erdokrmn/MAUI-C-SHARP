using SavePerson.View;

namespace SavePerson;


public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		
	}

	

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
        Navigation.PushAsync(new PersonSave());

    }
}

