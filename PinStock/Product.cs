using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinStock
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddProduct obj = new AddProduct();
            obj.Show();
            this.Hide();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddProduct obj = new AddProduct();
            obj.Show();
            this.Hide();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
        }

    } 
}
