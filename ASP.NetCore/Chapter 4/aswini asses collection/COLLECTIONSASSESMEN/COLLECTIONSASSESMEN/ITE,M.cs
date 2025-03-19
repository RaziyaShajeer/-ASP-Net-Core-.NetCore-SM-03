using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLLECTIONSASSESMEN
{
    internal class ITE_M
    {
        public string  { get; set; }
        public double price{ get; set; }
        public int quantity {  get; set; }
        public ITE_M(string name, double price, int quantity ) 
        { 
            name = name;
            price = price;
            quantity = quantity;
        }
        
    }
}
