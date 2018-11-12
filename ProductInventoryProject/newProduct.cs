using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventoryProject
{
    public partial class newProduct : Form
    {
        public newProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product ps1 = new Product(Name_txt.Text, Convert.ToDouble(Price_txt.Text), Convert.ToInt32(Quantity_txt.Text));
            this.Close();
        }
    }
}
