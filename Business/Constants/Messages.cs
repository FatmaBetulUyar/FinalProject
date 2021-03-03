using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //newlemeye gerek yok
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 tane olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
