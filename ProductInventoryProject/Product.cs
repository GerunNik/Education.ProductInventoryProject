using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInventoryProject.Properties;

namespace ProductInventoryProject
{
    public class Product
    {
        static int AmountOfIDs = 0;
        int ID { get; set; }
        double Price { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }



        public Product(string vProductName, double vPrice, int vQuantity)
        {
            ID = AmountOfIDs++;
            ProductName = vProductName;
            Price = vPrice;
            Quantity = vQuantity;
            Inventory.ProductInventory.Add(this);
        }

        public double getPrice()
        {
            return Price;
        }

        public string getName()
        {
            return ProductName;
        }
        public int getQuantity()
        {
            return Quantity;
        }
    }
}