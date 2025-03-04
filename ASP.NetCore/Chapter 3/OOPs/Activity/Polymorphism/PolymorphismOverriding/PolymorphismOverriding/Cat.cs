using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding
{
    internal class Cat : Animal
    {
        public override void MakingSound()
        {
            Console.WriteLine("Cat Sound.....");
        }
    }
}
