using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string MeintenanceTime = "Sistem bakımda";

        public static string ProductsListed = "Ürünler listelendi";

        public static string UnitPriceInvalid = "Ürün birim fiyatı geçersiz";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Erişim belirteci oluşturuldu";
                
        public static string PaymentSuccessful = "Ödeme başarılı.";
        public static string PaymentDenied = "Ödeme bilgileri reddedildi.";


        public static string PasswordIsIncorrect = "Parola doğru değil.";
        public static string PasswordUpdated = "Parola güncellendi.";
        public static string PasswordsDoNotMatch = "Parolalar aynı değil.";

        public static string WrongIdEntry = "Bu id için kayıt bulunmamaktadır.";
        public static string CategoryNameAlreadyExists = "Bu kategori adınında bir kategori bulunmaktadır.";
       

        public static string UsersListed = "Kullanıclar listelendi.";
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";


       
        public static string ProductListed = "Ürün listelendi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductLimitExceded = "Maksimum ürün ekleme sınırına ulaşıldı.";

        public static string CategoryAdded = "Kategori eklendi.";
        public static string CategoryListed = "Kategoriler listelendi.";
        public static string CategoryUpdated = "Kategori güncellendi.";
        public static string CategoryDeleted = "Kategori silindi.";
      

        public static string TopListAdd = "Listeniz eklendi";
        public static string TopListDelete = "Listeniz silindi";


        public static string SubListAdd = "Listeye Ürününüz eklendi";
        public static string SubListDelete = "Listeden ürününüz silindi";
        public static string AllListForTopList = "Listeden ürününüz silindi";

        public static string SalesProcess = "İşlem başarıyla gerçekleşti";
    }
}
