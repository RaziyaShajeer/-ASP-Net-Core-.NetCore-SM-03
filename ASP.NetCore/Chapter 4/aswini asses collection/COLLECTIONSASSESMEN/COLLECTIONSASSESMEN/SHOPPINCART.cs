using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLLECTIONSASSESMEN
{
    public class SHOPPINCART
    {
         List<ITE_M> items = new List<ITE_M>();
        public void AddItem(ITE_M item)
        {
            items.Add(item);
        }
        public void RemoveItem(string itemname)
        {
            ITE_M itemtoremove =items.RemoveItem
        }

        public double CalculateTotalPrice()
        {

            return items.Sum(items.price * items.quantity);
        }
    }
}
