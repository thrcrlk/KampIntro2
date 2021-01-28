using AccountManagement.Marketing;
using System;

namespace AccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerAccount gamerAccount = new GamerAccount();
            gamerAccount.NationalId = 10;
            gamerAccount.FirstName = "Tahir";
            gamerAccount.LastName = "Çerlek";
            gamerAccount.BirthDate = "asdasd";
            gamerAccount.AccountValidation = false;

            UserValidation userValidation = new UserValidation();
            userValidation.CheckUser(gamerAccount);

            SalesManager salesManager = new SalesManager();
            salesManager.AddtoWishList(gamerAccount);
            salesManager.Buy(gamerAccount);
            
        }

    }
}
