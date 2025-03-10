internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        var result=numbers.DefaultIfEmpty(5);
        Console.WriteLine("list:");
        foreach (var number in result)
        {
            Console.WriteLine(number); 
        }


        List<int> num = new List<int> { 8,10,6,4 };
        var result2 = num.DefaultIfEmpty();
        Console.WriteLine("list:");
        foreach (var number in result2)
        {
            Console.WriteLine(number);
        }
    }
}