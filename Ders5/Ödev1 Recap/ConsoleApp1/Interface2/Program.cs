using Interface2;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {new MySqlServerCustomerDal(),new OracleServerCustomerDal(),new SqlServerCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }


        interface IPerson
        {
            int Id { get; set; }
            String FirstName { get; set; }
            String LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Adress { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Department { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);

            }

        }
    }
}
