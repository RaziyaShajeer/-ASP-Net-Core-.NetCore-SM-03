// See https://aka.ms/new-console-template for more information
using System;

namespace ExceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DivideByZeroException
             int i, j, k=0;
            try
            {
                Console.WriteLine("Enter first number:");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                j = Convert.ToInt32(Console.ReadLine());
                k = i / j;
            }
            catch(DivideByZeroException ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result is {0} :", k);
            }
        }
    }
}
