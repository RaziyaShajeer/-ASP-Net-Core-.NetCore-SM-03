using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding 
{
    internal class Dog : Animal
    {
        public override void MakingSound()
        {
            Console.WriteLine(" Dog sound...");
        }
    }
}
