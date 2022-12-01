using Android.App;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Gib.Pattern;
using Gib.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gib.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class MainFlyoutViewModel : BaseViewModel
    {
        [ObservableProperty]
        string text;

        Control control = new Control();

        public MainFlyoutViewModel()
        {
            

            
           
        }



        [RelayCommand]
        async Task GoToLoginPageAsync()
        {

            control.ButtonState(text);
            //if (Text == "Giriş")
            //{
            //    await Shell.Current.GoToAsync($"{nameof(Login)}");
            //}
            //else
            //{
            //    var result = await App.Current.MainPage.DisplayActionSheet("Çıkış yapmak istediğinize emin misiniz ?", "Evet", "Hayır");
            //    if (result == "Evet")
            //    {
            //        Text = "Giriş";
            //        //Buraya nosqlden tam olarak çıkış yapmayı öğrenince kodunu yazıcam
            //    }

            //}

        }
    }
}
