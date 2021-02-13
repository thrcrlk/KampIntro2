using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer
    {

        //Properties 
        public int Id { get; set; }// get Id nin içindeki veriyi istenildiğinde göndermek amacıyla kullanılmaktadır.
        public string _firstName;
        public String FirstName { 
            get { return "Mr."+_firstName; }

            set { _firstName = value; } //_firstname e FirstName e atanan değer atanır. Bu sayede başına eklemek istediğimiz bir ünvanı ekleyebiliriz.
        } //set FirstName ise veriyi değiştirmek amacıyla kullanılır
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
