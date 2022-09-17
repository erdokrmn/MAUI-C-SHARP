

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

	//async void UploadPhoto()
	//{
	//	await CrossMedia.Current.Initialize();
	//	if (!CrossMedia.Current.IsPickPhotoSupported)
	//	{
	//		DisplayAlert("Alert", "Upload not supported on this device", "OK");
	//		return;
	//	}
	//	var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
	//	{
	//		PhotoSize=Plugin.Media.Abstractions.PhotoSize.Full,
	//		CompressionQuality=40
	//	});

	//	byte[] imageArray = File.ReadAllBytes(file.Path);
	//	Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
	//	IBPersonImage.set
	//}
	private void btnSave_Clicked(object sender, EventArgs e)
	{
		//var firebaseClient = new Firebase.Database.FirebaseClient("https://personsave-a8a76-default-rtdb.europe-west1.firebasedatabase.app/");
		//firebaseClient.Child("Records").PostAsync(new Person
		//{
		//	PersonName = entPersonName.Text,
		//	PersonLastName=entPersonLastName.Text,
		//	PersonAge=entAge.Text
		//}); 
		

	}

	private async void ImageTap_Tapped(object sender, EventArgs e)
	{
		//await CrossMedia.Current.Initialize();
		
		//try
		//{
		//	file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
		//	{
		//		PhotoSize=PhotoSize.Medium

		//	});
		//	if (file==null)
		//	{
		//		return;
		//	}
		//	PersonImage.Source = ImageSource.FromStream(() =>
		//	{
		//		return file.GetStream();
		//	});
		//}
		//catch (Exception ex)
		//{
		//	DisplayAlert("Hata", "HATA", "OK");
		//}
		

	}
}