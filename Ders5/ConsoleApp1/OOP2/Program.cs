using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 444;
            customer1.CustomerNo = "0001";
            customer1.CustomerId = "44155551";
            customer1.CustomerName = "Tahir";
            customer1.CustomerSurname = "Cerllke";

            CorpoeateCustomer customer2 = new CorpoeateCustomer();
            customer2.Id = 2324;
            customer2.CustomerNo = "0001";
            customer2.CompanyName = "NicevicElectronics";
            customer2.TaxNumber = "213124123123";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorpoeateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            





        }
    }
}
