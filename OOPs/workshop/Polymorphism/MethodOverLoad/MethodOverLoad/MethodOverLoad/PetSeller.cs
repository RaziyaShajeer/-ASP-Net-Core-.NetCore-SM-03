using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoad
{
	public class PetSeller
	{
		private string _sellerName;
		private Pet _pet;

		// Constructor
		public PetSeller(string sellerName, Pet pet)
		{
			_sellerName = sellerName;
			_pet = pet;
		}

		// Method to sell pet
		public void SellPet()
		{
			Console.WriteLine($"{_sellerName} is selling:");
			_pet.DisplayInfo();
		}
	}
}
