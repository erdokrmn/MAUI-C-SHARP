

using Microsoft.Maui.Controls;
using ServiceStack.DataAnnotations;

namespace FindPartTimeJobs.Model
{
    public class User 
    {
        //Burada şirket ve tüzel kişi olarak iki kayıt yapıcağımızdan bazıları ortak kayıt alacak


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; } // Ortak
        public string UserLastName { get; set; } // Tüzel kişi için
        public string UserTcNo { get; set; } // Tüzel kişi için
        public DateTime UserBirthDay { get; set; } // Tüzel kişi için
        public string UserImage { get;set; } //Ortak
        public string UserTelNo { get;set; } //Ortak
        public string UserMail { get;set; }  //Ortak
        public string UserCity { get; set; } //Ortak
        public string UserDistrict { get; set; } //Ortak
        public string Password { get; set; } //Ortak

        public FileResult ImageResult { get; set; }

    }
}
