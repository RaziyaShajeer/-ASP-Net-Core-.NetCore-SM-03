using System.Xml.Linq;
using COLLECTIONSASSESMEN;

internal class Program
{
    private static void Main(string[] args)
    {
        SHOPPINCART cart=new SHOPPINCART();
        while (true) 
        {
            Console.WriteLine("shopping cart ,menu");
            Console.WriteLine("add item");
            Console.WriteLine("remove ite,ms");

            Console.WriteLine("apply disacxount");
            Console.WriteLine("csacxulsa\te tottsapricxe");
            string choice=Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("ENTER ITE,M NAME");
                    string NAME=Console.ReadLine();
                    Console.WriteLine("ENTER  ITE,M PRICE");
                    double price=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ENTER ITEM QTY");
                    int quantity= Convert.ToInt32(Console.ReadLine());
                    ITE_M newitem = newitem(NAME, price, quantity);
                    cart.AddItem(newitem);
                    Console.WriteLine("item added ");



            }

        }
    }
}