using MethodOverLoad;

class Program
{
	static void Main(string[] args)
	{
		// Creating instances of pets
		Pet myPet = new Pet("Fluffy", 3);
		Dog myDog = new Dog("Buddy", 5, "Golden Retriever");

		// Displaying pet information
		Console.WriteLine("My Pet:");
		myPet.DisplayInfo();
		Console.WriteLine("\nMy Dog:");
		myDog.DisplayInfo(true);

		// Creating a pet seller
		PetSeller petSeller = new PetSeller("John", myPet);

		// Selling pet
		petSeller.SellPet();
	}
}