
using OOPs_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of Dog and Cat
        Dog dog = new Dog("Buddy", 5, "Labrador", "Ball");
        Cat cat = new Cat("Fluffy", 3, "Persian", true);

        // Displaying details of pets
        Console.WriteLine("Dog Details:");
        dog.DisplayDogDetails();
        Console.WriteLine("\nCat Details:");
        cat.DisplayCatDetails();
    }
}