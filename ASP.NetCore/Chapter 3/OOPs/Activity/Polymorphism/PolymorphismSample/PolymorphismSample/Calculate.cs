using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSample
{
    internal class Calculate
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sum(int x, int y, int z)
        {
            return x+y+z;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
