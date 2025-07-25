using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PinStock
{
    public partial class AddProduct : Form
    {
        // Update this path to your actual SQLite database file
        private readonly string connectionString = @"data source=C:\Users\IPASON\Desktop\PinStock\PinStock\pinstock_db\PSIM.db";
        public AddProduct()
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
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Product (ProductName, ProductBrand, ProductCategory, ProductPrice, ProductQuantity, ProductStatus) " +
                                   "VALUES (@ProductName, @ProductBrand, @ProductCategory, @ProductPrice, @ProductQuantity, @ProductStatus)";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductBrand", productBrand);
                        cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                        cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(productPrice));
                        cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt32(productQuantity));
                        cmd.Parameters.AddWithValue("@ProductStatus", productStatus);
                        cmd.ExecuteNonQuery();
                    }
                }

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
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Product SET ProductBrand = @ProductBrand, ProductCategory = @ProductCategory, " +
                                   "ProductPrice = @ProductPrice, ProductQuantity = @ProductQuantity, ProductStatus = @ProductStatus " +
                                   "WHERE ProductName = @ProductName";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductBrand", productBrand);
                        cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                        cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(productPrice));
                        cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt32(productQuantity));
                        cmd.Parameters.AddWithValue("@ProductStatus", productStatus);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product Updated Successfully!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string productId = txtPId.Text;

            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Please enter a Product ID to delete.");
                return;
            }
            else
            {
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Product WHERE ProductId = @ProductId";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(productId));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Product Deleted Successfully!" : "Product not found.");
                        txtPId.Clear();
                    }
                }
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
           
           
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }

       
    }
}
