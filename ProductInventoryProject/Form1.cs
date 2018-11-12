using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductInventoryProject.Properties;

namespace ProductInventoryProject
{
    public partial class Form1 : Form
    {
        Inventory InventoryOfProducts = new Inventory();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newProduct newProd = new newProduct();
            newProd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalValue_txt.Text = InventoryOfProducts.getValueAll().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemValue_txt.Text = InventoryOfProducts.getValue(item_txt.Text).ToString();
        }
    }
}
