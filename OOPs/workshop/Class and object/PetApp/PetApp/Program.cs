using PetApp;

class Program
{
	static void Main(string[] args)
	{
		// Creating instances of Pet class
		Pet pet1 = new Pet("Fluffy", "Cat", 3, 50.00);
		Pet pet2 = new Pet("Buddy", "Dog", 2, 100.00);
		Pet pet3 = new Pet();

		// Displaying pet information
		Console.WriteLine("Pet 1:");
		pet1.Display();
		Console.WriteLine();

		Console.WriteLine("Pet 2:");
		pet2.Display();
		Console.WriteLine();

		Console.WriteLine("Pet 3:");
		pet3.Name = "tomy";
		pet3.Price = pet1.Price;
		Console.WriteLine("Enter the age");
		pet3.Age = Convert.ToInt32(Console.ReadLine());
		pet3.Display();


	}
}
