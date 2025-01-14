using System;

namespace PetsApp_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //static Array declaration
            string[] petsName = new string[10];
            Console.WriteLine("How many pet Names you want to add to the array");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the name of {0}th Pet ", i + 1);
                petsName[i] = Console.ReadLine();
            }
            foreach (var pet in petsName)
            {
                Console.WriteLine(pet);
            }
            Console.ReadLine();
        }
    }
}