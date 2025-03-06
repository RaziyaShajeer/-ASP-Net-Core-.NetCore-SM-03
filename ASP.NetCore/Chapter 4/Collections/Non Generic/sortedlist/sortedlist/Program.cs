using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedList pets = new SortedList();
        pets.Add(1, "cat");
        pets.Add(2, "parrot");
        pets.Add(3, "dog");
        pets.Add(4, "pigeon");
        pets.Add(5, "rabbit");
        pets.Remove(3);
        foreach (var item in pets)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Parrot is found at index {pets.IndexOfKey(2)}");
        Console.WriteLine($"Value cat is at index {pets.IndexOfValue("cat")}");
        Console.WriteLine($"Length is:{pets.Count}");
    }
}