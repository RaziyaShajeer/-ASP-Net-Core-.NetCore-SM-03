using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
	public abstract class Pet
	{
		// Properties
		public string Name { get; set; }
		public int Age { get; set; }
		public string Breed { get; set; }
		public abstract void MakeSound(); // Abstract method to make sound

		// Constructor
		public Pet(string name, int age, string breed)
		{
			Name = name;
			Age = age;
			Breed = breed;
		}
	}
}
