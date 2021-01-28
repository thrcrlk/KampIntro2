using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    class GamerAccountManager : IGamerAccountManager
    {
        public void Add(GamerAccount gamerAccount)
        {
            UserValidation userValidation = new UserValidation();

            if (userValidation.CheckUser(gamerAccount)==true)
            {
                Console.WriteLine("Eklendi");
                gamerAccount.AccountValidation = true;
            }
            else
            {
                Console.WriteLine("TC Kimlik Numarası tanımlı değil.");
            }


            Console.WriteLine("Eklendi");
        }
        public void Delete(GamerAccount gamerAccount)
        {
            Console.WriteLine("Silindi");
        }
             
        public void Update(GamerAccount gamerAccount)
        {
            UserValidation userValidation = new UserValidation();

            if (userValidation.CheckUser(gamerAccount) == true)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("TC Kimlik Numarası tanımlı değil.");
            }
        }
    }



}
