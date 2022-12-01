using Android.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Gib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Gib.Pattern
{
    [QueryProperty("Text", "Text")]
    public partial class Control : BaseViewModel
    {
        [ObservableProperty]
        string text;


        //Login durumunu ve logout durumunu kontrol edeceğimiz kısımü
        private LogState _logState;
        public LogState LogState 
        {
            get { return _logState; }
            set
            { 
                _logState = value;
                _logState.LoginOrLogout(this);
            } 
        }
       

        public async void ButtonState(string text)
        {
            this.Text = text;
            if (Text == "Giriş")
            {
                this.LogState = new Login();
                await Shell.Current.GoToAsync($"{nameof(Login)}");
            }
            else
            {
                this.LogState = new Logout();
                var result = await App.Current.MainPage.DisplayActionSheet("Çıkış yapmak istediğinize emin misiniz ?", "Evet", "Hayır");
                if (result == "Evet")
                {
                    Text = "Giriş";
                    //Buraya nosqlden tam olarak çıkış yapmayı öğrenince kodunu yazıcam
                }

            }
            
        }
    }
}
