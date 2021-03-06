using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Common
        public static string MaintenanceTime = "Sistem Bakımda";

        //Car
        public static string CarAdded = "Arabanız Başarıyla Eklendi";
        public static string CarNameInvalid = "Lütfen Araba İsminin Uzunluğunu İki Karakterden Fazla Giriniz.";
        public static string CarList = "Ürünler Listelendi";
        public static string CarDeleted = "Arabanız Başarıyla Silindi";
        public static string CarUpdated = "Arabanız Başarıyla Güncellenmiştir";

        //Brand
        public static string BrandAdded = "Marka Başarıyla Eklendi.";
        public static string BrandNameInvalid = "Lütfen Marka İsminin Uzunluğunu İki Karakterden Fazla Giriniz.";
        public static string BrandList = "Markalar Listelendi.";
        public static string BrandDeleted = "Marka Başarıyla Silindi.";

        public static string BrandUpdated = "Marka Başarıyla Güncellenmiştir.";

        //Color
        public static string ColorAdded = "Araba Renginiz Başarıyla Eklenmiştir.";
        public static string ColorNameInvalid = "Araba Renginizin İsminin Uzunluğunu İki Karakterden Fazla Giriniz.";
        public static string ColorList = "Araba Renkleri Başarıyla Listelendi.";
        public static string ColorDeleted = "Araba Renginiz Başarıyla Silinmiştir.";
        public static string ColorUpdated = "Araba Renginiz Başarıyla Güncellenmiştir.";

        //User
        public static string UserAdded = "Kullanıcı Başarıyla Eklenmiştir.";
        public static string UserNameInvalid = "Kullanıcı  İsminin Uzunluğunu İki Karakterden Fazla Giriniz.";
        public static string UserList = "Kullanıcılar Başarıyla Listelendi.";
        public static string UserDeleted = "Kullanıcı Başarıyla Silinmiştir.";
        public static string UserUpdated = "Kullanıcı Başarıyla Güncellenmiştir.";

        //Customer
        public static string CustomerAdded = "Müşteri Başarıyla Eklenmiştir.";
        public static string CustomerNameInvalid = "Müşteri İsminin Uzunluğunu İki Karakterden Fazla Giriniz.";
        public static string CustomerList = "Müşteriler Başarıyla Listelendi.";
        public static string CustomerDeleted = "Müşteri Başarıyla Silinmiştir.";
        public static string CustomerUpdated = "Müşteri Başarıyla Güncellenmiştir.";

        //Rental
        public static string RentalAdded = "Araba Kiralanmıştır";
        public static string RentalNullDate = "Araba teslim edilmemiştir.";
        public static string RentalList = "Kiralanan Arabalar Listelenmiştir.";
        public static string RentalDeleted = "Araba Teslim Edilmiştir";
        public static string RentalUpdated = "Araba Kira Durumu Güncellenmiştir";
        public static string RentalNotFound = "Araba Bulunamadı.";
    }
}