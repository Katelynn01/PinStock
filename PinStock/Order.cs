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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddOrder obj = new AddOrder();
            obj.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AddOrder obj = new AddOrder();
            obj.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this order?","Confirm deletion", MessageBoxButtons.YesNo);
        }
    }
}
