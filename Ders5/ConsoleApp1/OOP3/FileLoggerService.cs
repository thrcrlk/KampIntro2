using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        void ILoggerService.Log()
        {
            Console.WriteLine("Dosyaya loglandı");

        }
    }



}
