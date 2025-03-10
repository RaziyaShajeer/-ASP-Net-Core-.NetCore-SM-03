using ExceptionHandling5.Category;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ExceptionHandling5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
    
       public static void Menu()
        { 
            Dog dog = new Dog();
            dog.DisplayMenu();
            
         }
    }
}
   


