using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static new lenmez. message. dediğimizde tek instance olusur.
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountCategoryError = "Kategori max 15 ürün olamlı";
        public static string ProductNameAlreadyExists = "Aynı isimli ürün mevcut";
        public static string CategoryLimitExceded = "Kategori sayısı aşıldı. yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetki Yok!";
        public static string UserRegistered="Kullanıcı kaydedildi";
        public static string UserNotFound="Kullanıcı mevcut";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists= "UserAlreadyExists";
        public static string AccessTokenCreated= "Access Token oluşturuldu";
        internal static string ProductCountOfCategoryError;
    }
}
