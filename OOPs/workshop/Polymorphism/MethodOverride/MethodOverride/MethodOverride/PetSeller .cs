using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
	public class PetSeller :Pet
	{
		private decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		// Constructor
		public PetSeller(string name, string breed, int age, decimal price)
			: base(name, breed, age)
		{
			this.price = price;
		}

		// Override Display method to include price
		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Price: {price:C}");
		}
	}
}
