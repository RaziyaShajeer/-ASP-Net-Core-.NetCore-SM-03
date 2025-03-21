using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLLECTIONSASSESMEN
{
    public class ApplyDiscount(double discountPercentage)
    {
        double totalprice =
            CalculateTotalPrice();

        double discountedprice = totalprice * (discountPercentage / 100);
        double discountedamt = totalprice - discountedprice;
    }
}
