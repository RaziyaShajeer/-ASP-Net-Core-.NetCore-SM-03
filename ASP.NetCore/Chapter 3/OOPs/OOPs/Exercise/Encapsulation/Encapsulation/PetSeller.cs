using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{


	public class PetSeller 
	{// Encapsulated field

	private Pet[] petsForSale;

		// Constructor
		public PetSeller(Pet[] petsForSale)
		{
			this.petsForSale = petsForSale;
		}

		// Method to display available pets for sale
		public void DisplayAvailablePets()
		{
			Console.WriteLine("Pets available for sale:");
			foreach (Pet pet in petsForSale)
			{
				pet.DisplayInfo();
			}
		}
	}
}
