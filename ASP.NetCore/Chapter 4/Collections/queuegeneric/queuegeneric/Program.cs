internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> pets = new Queue<string>();
        pets.Enqueue("cat");
        pets.Enqueue("dog");
        pets.Enqueue("pigeon");
        pets.Enqueue("parrot");
        pets.Enqueue("rabbit");
        Console.WriteLine("pet list:");
        foreach(string p in pets)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine("first item in pet list is {0}",pets.Peek());
        pets.Dequeue();
        Console.WriteLine("first item in pet list is {0}", pets.Peek());
        Console.WriteLine("Length is {0}", pets.Count);
    }
}