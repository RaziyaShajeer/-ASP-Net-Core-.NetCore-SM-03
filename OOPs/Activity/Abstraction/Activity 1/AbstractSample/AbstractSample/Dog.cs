﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    internal class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog is Barking....");
        }
    }
}
