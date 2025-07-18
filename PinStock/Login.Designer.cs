
namespace PinStock
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            logo = new PictureBox();
            pinstocklbl = new Label();
            usernamelbl = new Label();
            passwordlbl = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            LoginBtn = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(140, 34);
            logo.Name = "logo";
            logo.Size = new Size(98, 89);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // pinstocklbl
            // 
            pinstocklbl.AutoSize = true;
            pinstocklbl.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pinstocklbl.Location = new Point(244, 65);
            pinstocklbl.Name = "pinstocklbl";
            pinstocklbl.Size = new Size(389, 35);
            pinstocklbl.TabIndex = 1;
            pinstocklbl.Text = "PinStock Inventory Management";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(163, 192);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(75, 20);
            usernamelbl.TabIndex = 2;
            usernamelbl.Text = "Username";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(163, 254);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(70, 20);
            passwordlbl.TabIndex = 3;
            passwordlbl.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(272, 187);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter your Username";
            txtusername.Size = new Size(270, 27);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(272, 250);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Enter your Username";
            txtpassword.Size = new Size(270, 27);
            txtpassword.TabIndex = 5;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(318, 315);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(122, 40);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LogInButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(520, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(782, 403);
            Controls.Add(checkBox1);
            Controls.Add(LoginBtn);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Controls.Add(pinstocklbl);
            Controls.Add(logo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox logo;
        private Label pinstocklbl;
        private Label usernamelbl;
        private Label passwordlbl;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button LoginBtn;
        private CheckBox checkBox1;
    }
}
