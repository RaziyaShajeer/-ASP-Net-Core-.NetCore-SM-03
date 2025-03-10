using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> petlist = new List<string>();
        petlist.Add("cat");
        petlist.Add("dog");
        petlist.Add("pigeon");
        petlist.Add("parrot");
        petlist.Add("rabbit");
        petlist.Remove("pigeon");
        Console.WriteLine("pet list:");
        int c = 0;
        foreach (string pet in petlist)
        {
           
            Console.Write("At position {0} ", c);
            Console.WriteLine(pet);
            c++;
        }
        Console.WriteLine($"Length is :{petlist.Count}");
        petlist.RemoveAt(1);
        int p = 0;
        foreach (string pet in petlist)
        {
            Console.Write("At position {0} ", p);
            Console.WriteLine(pet);
            p++;
        }


    }
}