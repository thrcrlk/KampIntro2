using AbstractClass.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Customer:IEntity,ICustomerService
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
