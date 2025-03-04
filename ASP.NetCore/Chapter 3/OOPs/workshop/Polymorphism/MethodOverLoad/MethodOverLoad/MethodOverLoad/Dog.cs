using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodOverLoad
{
	public class Dog : Pet
	{
		// Additional properties
		public string Breed { get; set; }

		// Constructor
		public Dog(string name, int age, string breed) : base(name, age)
		{
			Breed = breed;
		}

		// Method Overload to display dog information
		public void DisplayInfo(bool includeBreed)
		{
			if (includeBreed)
				Console.WriteLine($"Name: {Name}, Age: {Age}, Breed: {Breed}");
			else
				DisplayInfo(); // Call base method
		}
	}
}
