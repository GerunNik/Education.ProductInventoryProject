namespace ProductInventoryProject
{
    using System.Collections.Generic;
    public class Inventory
    {
        public static List<Product> ProductInventory = new List<Product>();

        public double GetValueAll()
        {
            double value = 0;
            foreach (var item in ProductInventory)
            {
                value += item.GetPrice() * item.GetQuantity();
            }
            return value;
        }
        public double GetValue(string ProductName)
        {
            double value = 0;
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.GetName())
                {
                    value += item.GetPrice() * item.GetQuantity();
                }
            }
            return value;
        }
        public void SetPrice(string ProductName, double value)
        {
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.GetName())
                {
                    item.SetPrice(value);
                }
            }
        }
        public void SetQuantity(string ProductName, int value)
        {
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.GetName())
                {
                    item.SetQuantity(value);
                }
            }
        }
        public double GetPrice(string ProductName)
        {
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.GetName())
                {
                    return item.GetPrice();
                }
            }
            return 0;
        }
        public int GetQuantity(string ProductName)
        {
            foreach (var item in ProductInventory)
            {
                if (ProductName == item.GetName())
                {
                    return item.GetQuantity();
                }
            }
            return 0;
        }

    }
}
