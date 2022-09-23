using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Gib.View;

namespace Gib.ViewModel
{
    public partial class UserRegisterViewModel : BaseViewModel
    {
        public string webApiKey = "AIzaSyC0BrudDfiY3j_Ubdiqhjx-T4x8lPzJTjQ";
       

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string confirmpassword;



        [RelayCommand]
        async Task RegisterUserAsync()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                
                if (confirmpassword == password)
                {
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                    var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
                    string token = auth.FirebaseToken;
                    if (token != null)
                        await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");

                    await Shell.Current.GoToAsync($"{nameof(MainLayout)}");

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Şifreler Eşleşmedi", "OK");
                }

                
            }

            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Hata", $"Kayıt yapılamadı :{ex.Message}", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
