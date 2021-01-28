using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Marketing
{
    class SalesManager : ISalesManager
    {
        public void AddtoWishList(GamerAccount gamerAccount)
        {
            Console.WriteLine("Oyun istek listesine eklendi");
        }

        public void Buy(GamerAccount gamerAccount)
        {
            DiscountManager discountManager = new DiscountManager();
            UserValidation userValidation = new UserValidation();

            if (userValidation.CheckUser(gamerAccount)==true&&gamerAccount.AccountValidation == true)
            {
                
                Console.WriteLine("Satış başarılı" + " " + "%" + discountManager.Discount() +" "+ "indirim uygulandı.");
            }
            else
            {

                Console.WriteLine("Kullanıcı doğrulanmadı satın alma gerçekleştirilemez.");
            }
        }
       
    }
}
