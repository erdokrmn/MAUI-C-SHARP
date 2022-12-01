using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Gib.View;
using Newtonsoft.Json;


namespace Gib.ViewModel
{
    public partial class UserLoginViewModel :BaseViewModel
    {
        public string webApiKey = "AIzaSyC0BrudDfiY3j_Ubdiqhjx-T4x8lPzJTjQ";
        public FirebaseAuthLink auth;


        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

     

        [RelayCommand]
        async Task LoginUserAsync(string s)
        {

            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));

                try
                {
                    //var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));

                    auth = await authProvider.SignInWithEmailAndPasswordAsync(Email, Password);
                    var content = await auth.GetFreshAuthAsync();
                    var serializedContent = JsonConvert.SerializeObject(content);
                    Preferences.Set("FreshFirebaseToken", serializedContent);
                    s = auth.User.Email;
                    await Shell.Current.GoToAsync($"{".."}?Text={s}");

                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                }
           
        }

        [RelayCommand]
        async Task GoToRegisterPageAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(Register)}");
        }
    }
}
