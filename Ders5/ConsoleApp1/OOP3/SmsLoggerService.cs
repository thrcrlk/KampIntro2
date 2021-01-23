using System;

namespace OOP3
{
    class SmsLoggerService : ILoggerService
    {
        void ILoggerService.Log()
        {
            Console.WriteLine("Sms yollandı");

        }
    }



}
