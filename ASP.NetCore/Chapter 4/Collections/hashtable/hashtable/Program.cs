using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable pets = new Hashtable();
        pets.Add(1, "cat");
        pets.Add(2, "parrot");
        pets.Add(3, "dog");
        pets.Add(4, "pigeon");
        pets.Add(5,"rabbit");
        foreach(DictionaryEntry entry in pets)
        {
            Console.WriteLine($"{entry.Key},{entry.Value}");
        }
        pets.Remove(2);
        Console.WriteLine("Updated HashTable");
        foreach (DictionaryEntry entry in pets)
        {
            Console.WriteLine($"{entry.Key},{entry.Value}");
        }
        Console.WriteLine($"Length is: {pets.Count}");
        Console.WriteLine("Enter pet to be checked");
        int check = Convert.ToInt32(Console.ReadLine());
        if (pets.Contains(check))
        {
            Console.WriteLine("pet found");
        }
        else
        {
            Console.WriteLine("pet not found");
        }
    }
}