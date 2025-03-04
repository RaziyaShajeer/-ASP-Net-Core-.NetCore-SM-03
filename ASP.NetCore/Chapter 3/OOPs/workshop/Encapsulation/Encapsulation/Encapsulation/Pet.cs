using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	// Base class for pets
	public class Pet
	{
		// Encapsulated fields
		private string name;
		private int age;
		private string breed;

		// Constructor
		public Pet(string name, int age, string breed)
		{
			this.name = name;
			this.age = age;
			this.breed = breed;
		}

		// Method to display pet information
		public void DisplayInfo()
		{
			Console.WriteLine($"Name: {name}, Age: {age}, Breed: {breed}");
		}
	}
}

