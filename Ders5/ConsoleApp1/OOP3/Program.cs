using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager personelCreditMaganer = new PersonelCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            //Database loglama methodlarını tanımlama
            ILoggerService dataBaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();


            ApplyManager applyManager = new ApplyManager();
            applyManager.PerformApply(vehicleCreditManager,new List<ILoggerService>() {dataBaseLogger,new SmsLoggerService() });//Loglama operasyonu 2 farklı şekilde list kullanarak uygulandı.

            List<ICreditManager> krediler = new List<ICreditManager>() {personelCreditMaganer,vehicleCreditManager };
            //applyManager.PerformPredCreditInform(krediler);

        }
    }
}
