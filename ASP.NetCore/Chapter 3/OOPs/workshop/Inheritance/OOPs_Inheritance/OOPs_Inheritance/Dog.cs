using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Inheritance
{// Derived class for Dogs
	public class Dog : Pet
	{
		// Additional field specific to Dog class
		private string favoriteToy;

		// Constructor
		//This constructor initializes the Dog class's fields using parameters like name, age, breed, and favoriteToy,
		//while also ensuring that the base class's constructor (Pet class) initializes its fields first.
		public Dog(string name, int age, string breed, string favoriteToy) : base(name, age, breed)
		{
			this.favoriteToy = favoriteToy;
		}

		// Method to display dog details
		public void DisplayDogDetails()
		{
			DisplayDetails(); // Reuse base class method
			Console.WriteLine($"Favorite Toy: {favoriteToy}");
		}
	}
}
