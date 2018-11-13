namespace ProductInventoryProject
{
    using System;
    using System.Windows.Forms;
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product ps1 = new Product(this.Name_txt.Text, Convert.ToDouble(this.Price_txt.Text), Convert.ToInt32(this.Quantity_txt.Text));
            this.Close();
        }
    }
}
