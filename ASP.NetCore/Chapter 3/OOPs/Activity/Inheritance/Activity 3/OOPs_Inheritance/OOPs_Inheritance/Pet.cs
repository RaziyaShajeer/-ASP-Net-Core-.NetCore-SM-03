using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Inheritance
{
	public class Pet
	{
		// Fields
		protected string name;
		protected int age;
		protected string breed;

		// Constructor
		public Pet(string name, int age, string breed)
		{
			this.name = name;
			this.age = age;
			this.breed = breed;
		}

		// Method to display pet details
		public void DisplayDetails()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Breed: {breed}");
		}
	}
}
