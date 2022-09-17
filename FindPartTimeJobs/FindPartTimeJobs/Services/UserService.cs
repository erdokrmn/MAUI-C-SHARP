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
                    UserBirthDay= user.UserBirthDay,
                    UserImage= user.UserImage
                    

                });
            
            return null;
        }
        public async Task SaveCompany(
             string userName,
             string userCity,
             string userDistrict,
             string userTelNo,
             string userMail,
             string userImage)
        {

            await firebaseClient.Child("Users")
                .PostAsync(new User()
                {
                    UserName = userName,
                    UserCity = userCity,
                    UserDistrict = userDistrict,
                    UserTelNo = userTelNo,
                    UserMail = userMail,
                    UserImage = userImage

                });

        }

        
    }
}
