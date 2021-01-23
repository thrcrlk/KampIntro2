using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer //Inheritance-miras   bireysel müşterinin bir müşteri olduğunu belirtir
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }

    }
}
