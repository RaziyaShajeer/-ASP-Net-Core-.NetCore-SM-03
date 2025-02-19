using Abstract;

class Program
{
	static void Main(string[] args)
	{
		// Creating instances of Dog and Cat
		Dog dog = new Dog("Buddy", 3, "Labrador");
		Cat cat = new Cat("Whiskers", 2, "Siamese");

		// Outputting pet information
		Console.WriteLine("Dog:");
		Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Breed: {dog.Breed}");
		dog.MakeSound();

		Console.WriteLine("\nCat:");
		Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}, Breed: {cat.Breed}");
		cat.MakeSound();
	}
}