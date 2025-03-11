internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        int element1 = numbers.ElementAt(2);
        Console.WriteLine("element at index 2 : " + element1);
        int elementdefault1 = numbers.ElementAtOrDefault(2);
        Console.WriteLine("element at index 2 : " + elementdefault1);


       
        int element2 = numbers.ElementAt(6);
        Console.WriteLine("element at index 6: " + element2);
        int elementdefault2 = numbers.ElementAtOrDefault(6);
        Console.WriteLine("element at index 6 : " + elementdefault2);




        List<string> num = new List<string> { "sree","devu" };
        string element3 = num.ElementAt(1);
        Console.WriteLine("element at index 2 : " + element3);
        string elementdefault3 = num.ElementAtOrDefault(1);
        Console.WriteLine("element at index 2 : " + elementdefault3);



        string element4 = num.ElementAt(6);
        Console.WriteLine("element at index 6: " + element4);
        string elementdefault4 = num.ElementAtOrDefault(6);
        Console.WriteLine("element at index 6 : " + elementdefault4);
    }
}