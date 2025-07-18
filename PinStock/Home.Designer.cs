
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
            pictureBox1 = new PictureBox();
            archiveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerlogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            productlogo.Location = new Point(84, 197);
            productlogo.Name = "productlogo";
            productlogo.Size = new Size(126, 148);
            productlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            productlogo.TabIndex = 3;
            productlogo.TabStop = false;
            // 
            // orderlogo
            // 
            orderlogo.Image = (Image)resources.GetObject("orderlogo.Image");
            orderlogo.Location = new Point(261, 197);
            orderlogo.Name = "orderlogo";
            orderlogo.Size = new Size(126, 148);
            orderlogo.SizeMode = PictureBoxSizeMode.Zoom;
            orderlogo.TabIndex = 4;
            orderlogo.TabStop = false;
            // 
            // customerlogo
            // 
            customerlogo.Image = (Image)resources.GetObject("customerlogo.Image");
            customerlogo.Location = new Point(438, 197);
            customerlogo.Name = "customerlogo";
            customerlogo.Size = new Size(111, 129);
            customerlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            customerlogo.TabIndex = 5;
            customerlogo.TabStop = false;
            // 
            // productBtn
            // 
            productBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productBtn.Location = new Point(85, 332);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(125, 30);
            productBtn.TabIndex = 8;
            productBtn.Text = "Product";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += productButton_Click;
            // 
            // orderBtn
            // 
            orderBtn.Font = new Font("Impact", 12F);
            orderBtn.Location = new Point(262, 332);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(125, 30);
            orderBtn.TabIndex = 9;
            orderBtn.Text = "Order";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderButton_Click;
            // 
            // customerBtn
            // 
            customerBtn.Font = new Font("Impact", 12F);
            customerBtn.Location = new Point(431, 332);
            customerBtn.Name = "customerBtn";
            customerBtn.Size = new Size(125, 30);
            customerBtn.TabIndex = 10;
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
            logoutBtn.TabIndex = 12;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(609, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // archiveBtn
            // 
            archiveBtn.Font = new Font("Impact", 12F);
            archiveBtn.Location = new Point(603, 332);
            archiveBtn.Name = "archiveBtn";
            archiveBtn.Size = new Size(125, 30);
            archiveBtn.TabIndex = 11;
            archiveBtn.Text = "Archive";
            archiveBtn.UseVisualStyleBackColor = true;
            archiveBtn.Click += archiveBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(archiveBtn);
            Controls.Add(pictureBox1);
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
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)productlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerlogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button archiveBtn;
    }
}