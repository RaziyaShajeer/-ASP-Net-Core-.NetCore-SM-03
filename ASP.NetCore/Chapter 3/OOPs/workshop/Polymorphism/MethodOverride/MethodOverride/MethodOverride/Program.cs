// Main class
using MethodOverride;

class Program
{
    static void Main(string[] args)
    {
        // Creating pet seller objects
        PetSeller pet1 = new PetSeller("Buddy", "Labrador", 3, 500);
        PetSeller pet2 = new PetSeller("Whiskers", "Persian Cat", 2, 300);

        // Displaying pet details including price
        Console.WriteLine("Pet 1 Details:");
        pet1.Display();

        Console.WriteLine("\nPet 2 Details:");
        pet2.Display();
    }
}
