namespace ProductInventoryProject
{
    public class Product
    {
        static int AmountOfIDs = 0;
        int ID { get; set; }
        double Price { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }



        public Product(string newProductName, double newPrice, int newQuantity)
        {
            this.ID = AmountOfIDs++;
            this.ProductName = newProductName;
            this.Price = newPrice;
            this.Quantity = newQuantity;
            Inventory.ProductInventory.Add(this);
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public string GetName()
        {
            return this.ProductName;
        }
        public int GetQuantity()
        {
            return this.Quantity;
        }
        public void SetQuantity(int value)
        {
            this.Quantity = value;
        }
        public void SetPrice(double value)
        {
            this.Price = value;
        }
    }
}