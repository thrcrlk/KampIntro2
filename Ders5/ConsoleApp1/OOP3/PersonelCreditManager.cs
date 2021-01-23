using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelCreditManager : ICreditManager//polymorphism
    {
        void ICreditManager.Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
