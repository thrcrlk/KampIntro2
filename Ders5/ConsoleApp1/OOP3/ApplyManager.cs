using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{       //Method Injection yapıyoruz- Dependency Injection
    class ApplyManager
    {
        public void PerformApply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();

            foreach (var Services in loggerServices)
            {
                Services.Log();
            }

        }
        public void PerformPredCreditInform(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }

    }
}
