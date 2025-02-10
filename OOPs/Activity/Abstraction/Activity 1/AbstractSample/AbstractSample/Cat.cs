using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    internal class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat is making sound Meow....");
        }
    }
}
