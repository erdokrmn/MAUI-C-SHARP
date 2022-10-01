using CommunityToolkit.Mvvm.Input;
using Gib.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gib.ViewModel
{
    public partial class MainPageViewModel :BaseViewModel
    {
        [RelayCommand]
        async Task GoToLoginPageAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(Login)}");
        }



    }
}
