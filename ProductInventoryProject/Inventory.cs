using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    public class Inventory
    {
        public static List<Product> ProductInventory = new List<Product>();

        public double getValueAll()
        {
            double value = 0;
            foreach (var item in ProductInventory)
            {
                value += item.getPrice() * item.getQuantity();
            }
            return value;
        }
        public double getValue(string ProductName)
        {
            double value = 0;
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.getName())
                {
                    value += item.getPrice() * item.getQuantity();
                }
            }
            return value;
        }
    }
}
