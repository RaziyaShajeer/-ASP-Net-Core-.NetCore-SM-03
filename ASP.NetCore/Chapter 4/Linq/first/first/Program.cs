internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 2, 4, 6,8,10 };
        int firsteven = numbers.First(n => n%2==0);
        Console.WriteLine("first odd number : " + firsteven);
        int defaulteven = numbers.FirstOrDefault(n => n % 2 == 0);
        Console.WriteLine("First even number : " + defaulteven);


        List<int> num = new List<int> { 3,5,7,9 };
        int firstnumeven = num.First(n => n%2==0);
        Console.WriteLine("first odd number : " + firstnumeven);
        int defaultnumeven = num.FirstOrDefault(n => n % 2 == 0);
        Console.WriteLine("First even number : " + defaultnumeven);


        List<int> n = new List<int>();
        int firstneven = n.First();
        Console.WriteLine("first odd number : " + firstneven);
        int defaultneven = n.FirstOrDefault(n => n % 2 == 0);
        Console.WriteLine("First even number : " + defaultneven);

    }
}