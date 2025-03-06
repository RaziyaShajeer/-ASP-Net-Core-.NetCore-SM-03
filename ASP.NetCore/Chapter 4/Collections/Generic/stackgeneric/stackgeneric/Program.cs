internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> pets = new Stack<string>();
        pets.Push("dog");
        pets.Push("cat");
        pets.Push("rabbit");
        pets.Push("parrot");
        Console.WriteLine("pet list:");
        foreach (string p in pets)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine($"Length is:{pets.Count}");
        Console.WriteLine($"first item  is:{pets.Peek()}");
        pets.Pop();
        Console.WriteLine($"first item  is:{pets.Peek()}");
        Console.WriteLine("enter pet name that you want to check ");
        string check = Console.ReadLine();
        if (pets.Contains(check))
        {
            Console.WriteLine($"{check} found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}