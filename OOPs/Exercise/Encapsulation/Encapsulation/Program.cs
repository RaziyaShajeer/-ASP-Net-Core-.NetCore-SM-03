using Encapsulation;

class Program
{
	static void Main(string[] args)
	{
		// Creating pet objects
		Pet dog = new Pet("Max", 3, "Labrador");
		Pet cat = new Pet("Whiskers", 2, "Persian");

		// Creating an array of pets for sale
		Pet[] petsForSale = { dog, cat };

		// Creating a pet seller object
		PetSeller petSeller = new PetSeller(petsForSale);

		// Displaying available pets for sale
		petSeller.DisplayAvailablePets();
	}
}