internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int,string> pets = new SortedList<int,string>();
        pets.Add(1, "cat");
        pets.Add(2, "parrot");
        pets.Add(3, "dog");
        pets.Add(4, "pigeon");
        pets.Add(5, "rabbit");
        Console.WriteLine(" Pet list:");
        foreach (KeyValuePair<int, string> item in pets)
        {
            Console.WriteLine($"pet {item.Key} is {item.Value}");
        }
        pets.Remove(3);
        Console.WriteLine(" updated Pet list:");
        foreach (KeyValuePair<int, string> item in pets)
        {
            Console.WriteLine($"pet {item.Key} is {item.Value}");
        }
        Console.WriteLine("enter pet that you want to check");
        int check = Convert.ToInt32(Console.ReadLine());
        if (pets.ContainsKey(check))
        {
            Console.WriteLine($"{check} found");
        }
        else
        {
            Console.WriteLine($"{check} not found");
        }
    }
}