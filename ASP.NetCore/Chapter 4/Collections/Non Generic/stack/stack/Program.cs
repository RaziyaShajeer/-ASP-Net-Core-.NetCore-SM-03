using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Stack pets = new Stack();
        pets.Push("dog");
        pets.Push("cat");
        pets.Push("rabbit");
        pets.Push("parrot");
        pets.Pop();
        foreach (string p in pets)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine($"Length : {pets.Count}");
        Console.WriteLine("Enter pet name you want to check");
        string check = Console.ReadLine();
        if (pets.Contains(check))
        {
            Console.WriteLine($"{check}  found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}