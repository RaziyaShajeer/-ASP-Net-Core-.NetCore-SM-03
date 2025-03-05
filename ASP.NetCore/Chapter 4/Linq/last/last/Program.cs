internal class Program
{
    private static void Main(string[] args)
    {

        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        int lasteven = numbers.Last(n => n%2==0);
        Console.WriteLine("last odd number : " + lasteven);
        int defaulteven = numbers.LastOrDefault(n => n % 2 == 0);
        Console.WriteLine("last even number : " + defaulteven);


        List<int> num = new List<int> { 3, 5, 7, 9 };
        int lastnumeven = num.Last(n => n%2==0);
        Console.WriteLine("last odd number : " + lastnumeven);
        int defaultnumeven = num.LastOrDefault(n => n % 2 == 0);
        Console.WriteLine("last even number : " + defaultnumeven);


        List<int> n = new List<int>();
        int lastneven = n.Last();
        Console.WriteLine("last odd number : " + lastneven);
        int defaultneven = n.LastOrDefault(n => n % 2 == 0);
        Console.WriteLine("last even number : " + defaultneven);
    }
}