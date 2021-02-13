using System;
using System.Reflection.Emit;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new RObot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
              
            }
            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            IGetSalary[] getSalary = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };

        }


        interface IWorker
        {
            void Work();
          
        }
        interface IEat
        {
            void Eat();
        }
        interface IGetSalary
        {
            void GetSalary();
        }



        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Worker : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class RObot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }




    }
}
