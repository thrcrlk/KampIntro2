using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Tahir";
            customer.LastName = "Çerlek";
            customer.City = "sakarya";
            Customer customer1 = new Customer
            {
                Id = 2,
                City = "Sakarya",
                FirstName = "Tahir",
                LastName = "Çerlek"
            };

            Console.WriteLine(customer1.FirstName);

        }
    }
}
