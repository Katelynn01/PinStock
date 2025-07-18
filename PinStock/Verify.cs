using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinStock
{
    public partial class Verify : Form
    {
        public Verify()
        {
            InitializeComponent();
        }

    private void Verify_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            txtCpass.UseSystemPasswordChar = true;
        }
    

    private void pCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pCheckBox.Checked)
            {
                txtpass.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtpass.UseSystemPasswordChar = true; // Hide password
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cpassCheckBox.Checked)
            {
                txtCpass.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtCpass.UseSystemPasswordChar = true; // Hide password
            }
        }
      private  void confirmBtn_CLick(object sender, EventArgs e)
        {
            string password = txtpass.Text;
            string ConfirmPassword = txtCpass.Text;

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("Invalid Password.");
            } 
            else if (password != ConfirmPassword)
            {
                MessageBox.Show("Password do not match.", "Mismatch", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("User Verified!");
                Archive obj = new Archive();
                obj.Show();
                this.Hide();
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }
    }
}
