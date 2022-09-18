

using CommunityToolkit.Mvvm.Input;
using FindPartTimeJobs.Model;
using FindPartTimeJobs.Services;
using FindPartTimeJobs.View;

namespace FindPartTimeJobs.ViewModel
{
    public partial class UserLoginViewModel : BaseViewModel
    {
        UserService userService;

        public UserLoginViewModel(UserService userService)
        {
            this.userService = userService;
            Title = "Kullanıcı giriş";
        }

        [RelayCommand]
        async Task GoToRegisterPageAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(Register)}");
        }
    }
}
