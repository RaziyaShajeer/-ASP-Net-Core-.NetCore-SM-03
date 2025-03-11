using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Queue pets = new Queue();
        pets.Enqueue("cat");
        pets.Enqueue("dog");
        pets.Enqueue("pigeon");
        pets.Enqueue("rabbit");
        pets.Enqueue("parrot");
        pets.Dequeue();
        foreach(string p in pets)
        {
            Console.WriteLine(p);

        }
        Console.WriteLine(pets.Peek());
        Console.WriteLine($"Length is :{pets.Count}");
    }
}