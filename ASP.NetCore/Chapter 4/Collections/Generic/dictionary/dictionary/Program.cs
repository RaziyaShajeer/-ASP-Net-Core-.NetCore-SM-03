internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> pets = new Dictionary<int, string>();
        pets.Add(1, "cat");
        pets.Add(2, "parrot");
        pets.Add(3, "dog");
        pets.Add(4, "pigeon");
        pets.Add(5, "rabbit");
        foreach(KeyValuePair<int,string> p in pets)
        {

            Console.WriteLine($"Key is {p.Key} and Value is {p.Value} ");

        }
        pets.Remove(3);
        Console.WriteLine("updated pet list ");
        foreach (KeyValuePair<int, string> p in pets)
        {

            Console.WriteLine($"Key is {p.Key} and Value is {p.Value} ");

        }
    }
}