namespace PinStock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == " " && txtpassword.Text == "")
            {
                MessageBox.Show("Invalid Username or Password.");

            }
            else if (txtusername.Text == "Katelyn" && txtpassword.Text == "kiana")
            {
                MessageBox.Show("Login Successful!");
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else if (txtusername.Text == "Paul" && txtpassword.Text == "gonzales")
            {
                MessageBox.Show("Login Successful!");
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else if (txtusername.Text == "Erica" && txtpassword.Text == "cruz")
            {
                MessageBox.Show("Login Successful!");
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true; // Hide password
            }
        }

        // Renamed the duplicate method to resolve CS0111
        
    }
}

