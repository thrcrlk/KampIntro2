using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CommercialCreditManager : ICreditManager
    {
        void ICreditManager.Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }
    }

}
