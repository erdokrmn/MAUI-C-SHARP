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
        public bool isAuthenticateUser =false;


        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;


        [ObservableProperty]
        string labelText;


        [RelayCommand]
        async Task LoginUserAsync()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(Email, Password);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("FreshFirebaseToken", serializedContent);
                isAuthenticateUser = true;
                labelText = "Giriş Yapıldı";
                await Shell.Current.GoToAsync($"{nameof(AppShell)}");
                // await Shell.Current.GoToAsync("AppShell");

            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }
        }
        


        [RelayCommand]
        async Task GoToRegisterPageAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(Register)}");
        }
    }
}
