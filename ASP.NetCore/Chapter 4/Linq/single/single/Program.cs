internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 2, 4, 6, 4, 10 };
        int single1 = numbers.Single(n => n==4);
        Console.WriteLine("single even number : " + single1);
       int default1 = numbers.SingleOrDefault(n => n==4);
       Console.WriteLine("single even number : " + default1);





        int single2 = numbers.Single(n => n==11);
        Console.WriteLine("single even number : " + single2);
        int default2 = numbers.SingleOrDefault(n => n==11);
        Console.WriteLine("single even number : " + default2);



        List<int> num = new List<int> ();
        int single3 = num.Single(n => n==4);
        Console.WriteLine("single even number : " + single3);
        int default3 = num.SingleOrDefault(n => n==4);
        Console.WriteLine("single even number : " + default3);
    }
}