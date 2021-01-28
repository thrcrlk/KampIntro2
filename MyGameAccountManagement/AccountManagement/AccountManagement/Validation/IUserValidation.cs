using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    interface IUserValidation
    {
        bool CheckUser(GamerAccount gamerAccount);
    }
}
