using Firebase.Auth;
using Gib.ViewModel;
using Newtonsoft.Json;
using ServiceStack.Auth;

namespace Gib.View;

public partial class MainFlyout : ContentPage
{
    public string webApiKey = "AIzaSyC0BrudDfiY3j_Ubdiqhjx-T4x8lPzJTjQ";
    public MainFlyout(MainFlyoutViewModel mainFlyoutViewModel)

	{
        
		InitializeComponent();
		BindingContext = mainFlyoutViewModel;	
	}

	
}