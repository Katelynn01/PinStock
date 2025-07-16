
namespace PinStock
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            logo = new PictureBox();
            pinstocklbl = new Label();
            productlogo = new PictureBox();
            orderlogo = new PictureBox();
            customerlogo = new PictureBox();
            productBtn = new Button();
            orderBtn = new Button();
            customerBtn = new Button();
            logoutBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerlogo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(140, 34);
            logo.Name = "logo";
            logo.Size = new Size(98, 89);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // pinstocklbl
            // 
            pinstocklbl.AutoSize = true;
            pinstocklbl.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pinstocklbl.Location = new Point(244, 65);
            pinstocklbl.Name = "pinstocklbl";
            pinstocklbl.Size = new Size(389, 35);
            pinstocklbl.TabIndex = 2;
            pinstocklbl.Text = "PinStock Inventory Management";
            // 
            // productlogo
            // 
            productlogo.Image = (Image)resources.GetObject("productlogo.Image");
            productlogo.Location = new Point(96, 197);
            productlogo.Name = "productlogo";
            productlogo.Size = new Size(126, 148);
            productlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            productlogo.TabIndex = 3;
            productlogo.TabStop = false;
            // 
            // orderlogo
            // 
            orderlogo.Image = (Image)resources.GetObject("orderlogo.Image");
            orderlogo.Location = new Point(339, 197);
            orderlogo.Name = "orderlogo";
            orderlogo.Size = new Size(123, 148);
            orderlogo.SizeMode = PictureBoxSizeMode.Zoom;
            orderlogo.TabIndex = 4;
            orderlogo.TabStop = false;
            // 
            // customerlogo
            // 
            customerlogo.Image = (Image)resources.GetObject("customerlogo.Image");
            customerlogo.Location = new Point(585, 197);
            customerlogo.Name = "customerlogo";
            customerlogo.Size = new Size(111, 124);
            customerlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            customerlogo.TabIndex = 5;
            customerlogo.TabStop = false;
            // 
            // productBtn
            // 
            productBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productBtn.Location = new Point(97, 332);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(125, 30);
            productBtn.TabIndex = 6;
            productBtn.Text = "Product";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productButton_Click;
            // 
            // orderBtn
            // 
            orderBtn.Font = new Font("Impact", 12F);
            orderBtn.Location = new Point(337, 332);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(125, 30);
            orderBtn.TabIndex = 8;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderButton_Click;
            // 
            // customerBtn
            // 
            customerBtn.Font = new Font("Impact", 12F);
            customerBtn.Location = new Point(579, 332);
            customerBtn.Name = "customerBtn";
            customerBtn.Size = new Size(125, 30);
            customerBtn.TabIndex = 9;
            customerBtn.Text = "Customer";
            customerBtn.UseVisualStyleBackColor = true;
            customerBtn.Click += customerBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.Location = new Point(701, 414);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(90, 30);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutBtn);
            Controls.Add(customerBtn);
            Controls.Add(orderBtn);
            Controls.Add(productBtn);
            Controls.Add(customerlogo);
            Controls.Add(orderlogo);
            Controls.Add(productlogo);
            Controls.Add(pinstocklbl);
            Controls.Add(logo);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)productlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox logo;
        private Label pinstocklbl;
        private PictureBox productlogo;
        private PictureBox orderlogo;
        private PictureBox customerlogo;
        private Button productBtn;
        private Button orderBtn;
        private Button customerBtn;
        private Button logoutBtn;
    }
}