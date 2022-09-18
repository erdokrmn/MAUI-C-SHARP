using CommunityToolkit.Mvvm.ComponentModel;
using FindPartTimeJobs.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.ObjectModel;

namespace FindPartTimeJobs.Services
{
    public class UserService 
    {
        

        FirebaseClient firebaseClient;
        public UserService()
        {

            firebaseClient = new FirebaseClient("https://findparttimejobs-4e8b5-default-rtdb.firebaseio.com/");
        }

        List<User> userList = new();

        
        public async Task<User> SaveUser(User user)
        {

            await firebaseClient.Child("Users")
                .PostAsync(new User()
                {
                    UserName=user.UserName,
                    UserLastName= user.UserLastName,
                    UserTcNo = user.UserTcNo,
                    UserCity = user.UserCity,
                    UserDistrict= user.UserDistrict,
                    UserTelNo= user.UserTelNo,
                    UserMail= user.UserMail,
                    UserBirthDay = user.UserBirthDay,
                    UserImage= user.UserImage,
                    Password= user.Password
                    

                });
            
            return null;
        }
        public async Task SaveCompany(User user)
        {

            await firebaseClient.Child("Users")
                .PostAsync(new User()
                {
                    UserName = user.UserName,
                    UserCity = user.UserCity,
                    UserDistrict = user.UserDistrict,
                    UserTelNo = user.UserTelNo,
                    UserMail = user.UserMail,
                    UserImage = user.UserImage

                });

        }

        
    }
}
