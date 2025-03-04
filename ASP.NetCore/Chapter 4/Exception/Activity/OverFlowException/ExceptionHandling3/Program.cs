// See https://aka.ms/new-console-template for more information
using System;

namespace ExceptionHandling3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OverFlowException
            try
            {
                int i = int.MaxValue;
                int j = checked(i + 1);
                Console.WriteLine(j);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
