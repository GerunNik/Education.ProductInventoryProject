namespace ProductInventoryProject
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        Inventory InventoryOfProducts = new Inventory();
        public Form1()
        {
            this.InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewProduct newProd = new NewProduct();
            newProd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.totalValue_txt.Text = this.InventoryOfProducts.GetValueAll().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.itemValue_txt.Text = this.InventoryOfProducts.GetValue(this.item_txt.Text).ToString();

            this.newPrice_txt.Text = this.InventoryOfProducts.GetPrice(this.item_txt.Text).ToString(); 
            
            this.newQuantity_txt.Text = this.InventoryOfProducts.GetQuantity(this.item_txt.Text).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.newPrice_txt.Text != string.Empty)
            {
                this.InventoryOfProducts.SetPrice(this.item_txt.Text, Convert.ToDouble(this.newPrice_txt.Text));
            }
            if (this.newQuantity_txt.Text != string.Empty)
            {
                this.InventoryOfProducts.SetQuantity(this.item_txt.Text, Convert.ToInt32(this.newQuantity_txt.Text));
            }
        }
    }
}
