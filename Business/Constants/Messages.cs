using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistemimiz Şu An Bakımda!";

        public static string UnitPriceInvalid = "Ürün Fiyatı Geçersiz";
        public static string StartWithA = "Ürünler A harfi ile başlamalı";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldı";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
