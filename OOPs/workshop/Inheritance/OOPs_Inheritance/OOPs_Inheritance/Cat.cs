using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Inheritance
{
	public class Cat : Pet
	{
		// Additional field specific to Cat class
		private bool isLongHair;

		
		public Cat(string name, int age, string breed, bool isLongHair) : base(name, age, breed)
		{
			this.isLongHair = isLongHair;
		}



		// Method to display cat details
		public void DisplayCatDetails()
		{
			DisplayDetails(); // Reuse base class method
			Console.WriteLine($"Long Hair: {isLongHair}");
		}
	}
}
