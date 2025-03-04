namespace PolymorphismSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculate sum1 = new Calculate();
           Console.WriteLine( sum1.Sum(3, 4));
            Console.WriteLine(sum1.Sum(6,7,8));
            Console.WriteLine(sum1.Sum(1.5,1.8));
        }
    }
}
