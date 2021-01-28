using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Marketing
{
    class DiscountManager : IDiscountManager
    {
        public double Discount()
        {
            DiscountPercentage discountPercentage = new DiscountPercentage();
            discountPercentage.DiscountRate = 10.00;

            return discountPercentage.DiscountRate;
        }
    }
}
