using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gib.Pattern
{
    public class Login : LogState
    {
        public override async void LoginOrLogout(Control control)
        {
            await App.Current.MainPage.DisplayAlert("Bilgilendirme","Giriş sayfasına yönlendiriliyorsunuz.", "Ok");
        }
    }
}
