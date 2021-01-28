using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    interface IGamerAccountManager
    {

        void Add(GamerAccount gamerAccount);
        void Delete(GamerAccount gamerAccount);
        void Update(GamerAccount gamerAccount);
    }
}
