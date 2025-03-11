internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var even = from num in numbers where num%2==0 select num;
        Console.WriteLine("even numbers:");
        foreach (var number in even)
        {
            Console.WriteLine(number);
        }
    }
}