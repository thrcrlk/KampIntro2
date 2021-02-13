using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Student student = new Student()
            { Id = 1, FirstName = "Ahmet", LastName = "Mehmet", Department = "Electronics" };
            Customer customer = new Customer()
            { Id = 1, FirstName = "Tahir", LastName = "Çetin" };

            personManager.Add(student);
            personManager.Add(customer);
            
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
        class Student : IPerson
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Department { get; set; }
        }

        class PersonManager
        {
            public  void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);

            }

        }
    }
}
