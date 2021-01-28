using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Marketing
{
    interface ISalesManager
    {
        void Buy(GamerAccount gamerAccount);
        void AddtoWishList(GamerAccount gamerAccount);
    }
}
