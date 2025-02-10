using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    abstract class Animal
    {
        public abstract void AnimalSound();

        public void Eat()
        {
            Console.WriteLine("Animal is Eating........");
        }
       
    }
}
