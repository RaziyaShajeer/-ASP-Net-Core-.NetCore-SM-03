using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
	public class Pet
	{
		// Encapsulated fields
		private string name;
		private string breed;
		private int age;

		// Properties with get set methods
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Breed
		{
			get { return breed; }
			set { breed = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		// Constructor
		public Pet(string name, string breed, int age)
		{
			this.name = name;
			this.breed = breed;
			this.age = age;
		}

		// Method to display pet details
		public virtual void Display()
		{
			Console.WriteLine($"Name: {name}, Breed: {breed}, Age: {age}");
		}
	}
}
