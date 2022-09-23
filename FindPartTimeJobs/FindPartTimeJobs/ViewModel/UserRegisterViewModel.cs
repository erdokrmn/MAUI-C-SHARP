using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FindPartTimeJobs.Model;
using FindPartTimeJobs.Services;
using Firebase.Storage;
using ServiceStack.DataAnnotations;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FindPartTimeJobs.ViewModel
{
    public partial class UserRegisterViewModel : BaseViewModel
    {
        UserService userService;
        public FileResult result;


        public ObservableCollection<User> Users { get; set; } = new();
        FirebaseStorage firebaseStorage;
        public UserRegisterViewModel(UserService userService)
        {
            
            this.userService = userService;
            Title = "Kullanıcı Kayıt";
        }

        [ObservableProperty ,AutoIncrement]
        int id;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string userLastName;

        [ObservableProperty]
        string userCity;

        [ObservableProperty]
        string userDistrict;

        [ObservableProperty]
        string userTelNo;

        [ObservableProperty]
        string userMail;

        [ObservableProperty]
        string userImage;

        [ObservableProperty]
        string userTcNo;

        [ObservableProperty]
        string userPassword;

        [ObservableProperty]
        string userPassword2;

        [ObservableProperty]
        DateTime userBirthDay;

        [ObservableProperty]
        FileResult imageResult;
      
        
        public bool canSaveUser
        {
            get { return !string.IsNullOrEmpty(UserName)  && !string.IsNullOrEmpty(UserTcNo) && !string.IsNullOrEmpty(UserCity) && !string.IsNullOrEmpty(UserDistrict) && !string.IsNullOrEmpty(UserTelNo) && !string.IsNullOrEmpty(UserMail) && !string.IsNullOrEmpty(UserPassword) &&UserPassword==UserPassword2; }
        }

        [RelayCommand]
        async Task GetImageAsync()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
                {
                    Title = "Please pick a photo"
                });
                if (result == null)
                {
                    return;
                }
                string path = result.FullPath;
                UserImage = path;

            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Hata", $"Fotoğraf alınamadı :{ex.Message}", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        [RelayCommand]
        async Task SaveUserAsync()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                imageResult = result;
                var users = await userService.SaveUser(new User
                {
                    Id=id,
                    UserName = userName,
                    UserLastName = userLastName,
                    UserTcNo = userTcNo,
                    UserCity = userCity,
                    UserDistrict = userDistrict,
                    UserTelNo = userTelNo,
                    UserMail = userMail,
                    UserBirthDay = userBirthDay,
                    Password=userPassword,
                    ImageResult=imageResult
                    
                });
                await new FirebaseStorage("findparttimejobs-4e8b5.appspot.com").
                    Child("UserImages").Child(UserName).PutAsync(await result.OpenReadAsync());
                await Shell.Current.DisplayAlert("Bilgilendirme", "Kayıt yapıldı", "Ok");

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
