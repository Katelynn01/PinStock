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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }


        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            
            Verify obj = new Verify();
            obj.Show();
            this.Hide();
        }
    }
}
