
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList pet = new ArrayList();
        pet.Add("pigeon");
        pet.Add("cat");
        pet.Add("dog");
        pet.Add("parrot");
        pet.Add("rabbit");
        Console.WriteLine("Arraylist is");
        foreach(string p in pet)
        {
            Console.WriteLine(p);

        }
        Console.WriteLine($"Length is:{pet.Count}");
        pet.Remove("pigeon");
        pet.RemoveAt(0);
        pet[1]="cat";
        Console.WriteLine("Updated Arraylist is");
        foreach (string p in pet)
        {
            Console.WriteLine(p);

        }
        Console.WriteLine("Enter name of the pet you want to de check:");
        string check = Console.ReadLine();
        if (pet.Contains("cat"))
        {
            Console.WriteLine("pet is found");
        }
        else
        {

            Console.WriteLine("pet is not found");
        }
            pet.Sort();
            Console.WriteLine("sorted Arraylist is");
            foreach (string p in pet)
            {
                Console.WriteLine(p);

            }
            pet.Insert(3, "pigeon");
            Console.WriteLine("Updated Arraylist is");
            foreach (string p in pet)
            {
                Console.WriteLine(p);
            }
        Console.WriteLine($"rabbit is at:{pet.IndexOf("rabbit")}");

    }
    }
