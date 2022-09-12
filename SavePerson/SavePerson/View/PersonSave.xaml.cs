
namespace SavePerson.View;

public partial class PersonSave : ContentPage
{
	public PersonSave()
	{
		InitializeComponent();
	}

	private void IBPersonImage_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert", "Týklandý", "OK");
	}
}