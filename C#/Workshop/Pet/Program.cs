using System;

namespace Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string petName;
            int age;

            Console.WriteLine("Enter the name of Pet");
            petName = Console.ReadLine();
            Console.WriteLine("Enter the Age of Pet");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Name:{0}\n Age of Pet:{1}", petName, age);
            Console.ReadLine();
        }
    }
}