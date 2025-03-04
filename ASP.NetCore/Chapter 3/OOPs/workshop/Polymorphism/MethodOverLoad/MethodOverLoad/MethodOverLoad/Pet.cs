using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoad
{
	public class Pet
	{
		// Properties
		public string Name { get; set; }
		public int Age { get; set; }

		// Constructor
		public Pet(string name, int age)
		{
			Name = name;
			Age = age;
		}

		// Method to display pet information
		public void DisplayInfo()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}
	}
}
