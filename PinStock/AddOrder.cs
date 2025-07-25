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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string CustomerName = txtCName.Text;
            string CustomerPhone = txtContactNum.Text;
            string Address = txtaddress.Text;

            if (string.IsNullOrEmpty(CustomerName) || string.IsNullOrEmpty(CustomerPhone) ||
                string.IsNullOrEmpty(Address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                MessageBox.Show("Order Added Successfully!");
                txtCName.Clear();
                txtContactNum.Clear();
                txtaddress.Clear();
            }


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Updated Successfully!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this order?", 
                "Confirm Deletion", MessageBoxButtons.YesNo);
        }
    }
}
