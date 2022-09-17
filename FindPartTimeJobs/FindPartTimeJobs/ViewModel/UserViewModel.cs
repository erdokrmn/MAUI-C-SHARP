using CommunityToolkit.Mvvm.Input;
using FindPartTimeJobs.Model;
using FindPartTimeJobs.Services;
using System.Collections.ObjectModel;

namespace FindPartTimeJobs.ViewModel
{
    public partial class UserViewModel : BaseViewModel
    {
        UserService userService;
        public ObservableCollection<User> Users { get; set; } = new();
        public UserViewModel(UserService userService)
        {
            this.userService = userService;
            Title = "Kullanıcı Kayıt";
        }


        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; OnPropertyChanged("UserName"); }
        }

        private string userLastName;
        public string UserLastName
        {
            get { return userLastName; }
            set { userLastName = value; OnPropertyChanged("UserLastName"); }
        }

        private string userCity;
        public string UserCity
        {
            get { return userCity; }
            set { userCity = value; OnPropertyChanged("UserCity"); }
        }

        private string userDistrict;
        public string UserDistrict
        {
            get { return userDistrict; }
            set { userDistrict = value; OnPropertyChanged("UserDistrict"); }
        }

        private string userTelNo;
        public string UserTelNo
        {
            get { return userTelNo; }
            set { userTelNo = value; OnPropertyChanged("UserTelNo"); }
        }

        private string userMail;
        public string UserMail
        {
            get { return userMail; }
            set { userMail = value; OnPropertyChanged("UserMail"); }
        }

        private string userImage;
        public string UserImage
        {
            get { return userImage; }
            set { userImage = value; OnPropertyChanged("UserImage"); }
        }

        private string userTcNo;
        public string UserTcNo
        {
            get { return userTcNo; }
            set { userTcNo = value; OnPropertyChanged("UserTcNo"); }
        }

        private DateTime userBirthDay;
        public DateTime UserBirtDay
        {
            get { return userBirthDay; }
            set { userBirthDay = value; OnPropertyChanged("UserBirthDay"); }
        }

        [RelayCommand]
        async Task SaveUserAsync()
        {
            await Shell.Current.DisplayAlert("asd", "asd", "ok");
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                var users = await userService.SaveUser(new User
                {
                    UserName = userName,
                    UserLastName = userLastName,
                    UserTcNo = userTcNo,
                    UserCity = userCity,
                    UserDistrict = userDistrict,
                    UserTelNo = userTelNo,
                    UserMail = userMail,
                    UserBirthDay = userBirthDay,
                    UserImage = userImage


                });

                

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
