using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
	public class Dog : Pet
	{
		// Constructor
		public Dog(string name, int age, string breed) : base(name, age, breed)
		{
		}

		// Implementation of abstract method
		public override void MakeSound()
		{
			Console.WriteLine("Woof!");
		}
	}
}
