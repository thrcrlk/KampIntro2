using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Person(){FName="Tahir"},
                new Student(){FName="Ahmet"},
                 new Person(){FName="Mehmet"}

            };

            foreach (var item in people)
            {
                Console.WriteLine(item.FName);
            }

               Console.ReadLine();

        
        }
    }



    class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }

    class Person2
    {

    }

    class Customer:Person // Customer:Person,Person2 şeklinde kullanılamaz interfaceler bunu mümkün kılardı fakat inheritance ta bu metot kullanılamaz.
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Adress { get; set; }
    }

}
