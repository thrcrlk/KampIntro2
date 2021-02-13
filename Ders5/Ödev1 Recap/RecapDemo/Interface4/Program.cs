using System;

namespace Interface4
{
    class Program
    {
        static void Main(string[] args)
        {

            IPersonManager[] personManager = new IPersonManager[2]//interface le new ile oluşturulamaz kendisi birşey ifade etmez.
            {
            new EmployeeManager(),
            new CustomerManager()
            };

            //foreach (var item in personManager)
            //{
            //    item.Add();
            //    item.Update();
            //}

            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            IPersonManager ınternManager = new InternManager();
            //customerManager.Add();
            //employeeManager.Add();
            //customerManager.Update();
            //employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(ınternManager);
        }

        interface IPersonManager
        {
            void Add();
            void Update();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Musteri eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Musteri güncellendi.");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Çalışan eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Çalışan güncellendi.");
            }
        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi.");
            }
        }


        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                  personManager.Add();
            }
        }

    }
}
