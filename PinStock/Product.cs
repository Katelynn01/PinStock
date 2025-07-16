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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string productName = txtPName.Text;
            string productBrand = txtBrand.Text;
            string productCategory = catCBox.Text;
            string productPrice = txrPrice.Text;
            string productQuantity = txtQuantity.Text;
            string productStatus = StatCBox.Text;

            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productBrand) ||
                string.IsNullOrEmpty(productCategory) || string.IsNullOrEmpty(productPrice) ||
                string.IsNullOrEmpty(productQuantity) || string.IsNullOrEmpty(productStatus))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                MessageBox.Show("Product Added Successfully!");
                txtPName.Clear();
                txtBrand.Clear();
                catCBox.SelectedIndex = -1;
                txrPrice.Clear();
                txtQuantity.Clear();
                StatCBox.SelectedIndex = -1;

            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }
    }
}
