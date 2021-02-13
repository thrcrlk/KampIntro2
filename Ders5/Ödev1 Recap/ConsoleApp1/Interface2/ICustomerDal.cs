using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2
{
    interface ICustomerDal//Data Access Layer
    {
        void Add();
        void Uptade();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Uptade()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Uptade()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Uptade()
        {
            Console.WriteLine("MySql updated");
        }
    }


    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
            

    }



}
