using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem Bakımda.";
        public static string ProductsListed="Ürünler Listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded="Kategori Limiti aşıldı.";

        public static string AuthorizationDenied="Yetkiniz yok.";
        
        public static string UserRegistered="Kullanıcı başarıyla kaydedildi.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre Hatalı.";
        public static string SuccessfulLogin="Sisteme giriş başarılı.";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated="Access token başarıyla oluşturuldu.";

        public static string OrderAdded="Şipariş başarıyla eklendi.";
        public static string OrderDeleted="Şipariş başarıyla silindi.";
        public static string OrderUpdated="Şipariş başarıyla güncellendi.";
        public static string OrdersListed ="Siparişler Listelendi.";

        internal static string CategoryAdded="Kategori başarıyla eklendi.";
        internal static string CategoryDeleted="Kategori başarıyla silindi.";
        internal static string CategoriesListed="Kategoriler başarıyla listelendi.";
        internal static string CategoryUpdated="Kategori başarıyla güncellendi.";
    }
}
