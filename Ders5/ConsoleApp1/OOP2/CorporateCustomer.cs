using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorpoeateCustomer: Customer //Inheritance-miras   bireysel müşterinin bir müşteri olduğunu belirtir 
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
       
    }
}
