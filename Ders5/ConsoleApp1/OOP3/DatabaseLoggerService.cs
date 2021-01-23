using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {
        void ILoggerService.Log()
        {
            Console.WriteLine("Veritabanına loglandı");

        }
    }



}
