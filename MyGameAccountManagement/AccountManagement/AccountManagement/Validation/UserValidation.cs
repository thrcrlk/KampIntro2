using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    class UserValidation : IUserValidation
    {
        public bool CheckUser(GamerAccount gamerAccount)
        {
            if (gamerAccount.NationalId>0)
            {
                gamerAccount.AccountValidation = true;
                return true;
            }
            else
            {
                gamerAccount.AccountValidation = false;
                return false;  

            }
        }
    }
}
