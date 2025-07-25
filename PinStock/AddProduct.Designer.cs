
namespace PinStock
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            logo = new PictureBox();
            productlbl = new Label();
            pIdlbl = new Label();
            PNamelbl = new Label();
            catlbl = new Label();
            brandlbl = new Label();
            Quantitylbl = new Label();
            Pricelbl = new Label();
            Statuslbl = new Label();
            txtPId = new TextBox();
            txtPName = new TextBox();
            txtBrand = new TextBox();
            catCBox = new ComboBox();
            txtQuantity = new TextBox();
            txrPrice = new TextBox();
            StatCBox = new ComboBox();
            Addbtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // productlbl
            // 
            productlbl.AutoSize = true;
            productlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productlbl.Location = new Point(87, 37);
            productlbl.Name = "productlbl";
            productlbl.Size = new Size(166, 25);
            productlbl.TabIndex = 3;
            productlbl.Text = "Product Dashboard";
            // 
            // pIdlbl
            // 
            pIdlbl.AutoSize = true;
            pIdlbl.Location = new Point(24, 86);
            pIdlbl.Name = "pIdlbl";
            pIdlbl.Size = new Size(79, 20);
            pIdlbl.TabIndex = 4;
            pIdlbl.Text = "Product ID";
            // 
            // PNamelbl
            // 
            PNamelbl.AutoSize = true;
            PNamelbl.Location = new Point(24, 126);
            PNamelbl.Name = "PNamelbl";
            PNamelbl.Size = new Size(104, 20);
            PNamelbl.TabIndex = 5;
            PNamelbl.Text = "Product Name";
            // 
            // catlbl
            // 
            catlbl.AutoSize = true;
            catlbl.Location = new Point(24, 166);
            catlbl.Name = "catlbl";
            catlbl.Size = new Size(69, 20);
            catlbl.TabIndex = 6;
            catlbl.Text = "Category";
            // 
            // brandlbl
            // 
            brandlbl.AutoSize = true;
            brandlbl.Location = new Point(24, 206);
            brandlbl.Name = "brandlbl";
            brandlbl.Size = new Size(48, 20);
            brandlbl.TabIndex = 7;
            brandlbl.Text = "Brand";
            // 
            // Quantitylbl
            // 
            Quantitylbl.AutoSize = true;
            Quantitylbl.Location = new Point(24, 246);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(65, 20);
            Quantitylbl.TabIndex = 8;
            Quantitylbl.Text = "Quantity";
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Location = new Point(24, 286);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(41, 20);
            Pricelbl.TabIndex = 9;
            Pricelbl.Text = "Price";
            // 
            // Statuslbl
            // 
            Statuslbl.AutoSize = true;
            Statuslbl.Location = new Point(24, 326);
            Statuslbl.Name = "Statuslbl";
            Statuslbl.Size = new Size(49, 20);
            Statuslbl.TabIndex = 10;
            Statuslbl.Text = "Status";
            // 
            // txtPId
            // 
            txtPId.Location = new Point(146, 86);
            txtPId.Name = "txtPId";
            txtPId.ReadOnly = true;
            txtPId.Size = new Size(250, 27);
            txtPId.TabIndex = 12;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(146, 126);
            txtPName.Name = "txtPName";
            txtPName.PlaceholderText = "Enter Product Name";
            txtPName.Size = new Size(250, 27);
            txtPName.TabIndex = 13;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(146, 206);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Enter Brand";
            txtBrand.Size = new Size(250, 27);
            txtBrand.TabIndex = 15;
            // 
            // catCBox
            // 
            catCBox.ForeColor = SystemColors.GrayText;
            catCBox.FormattingEnabled = true;
            catCBox.Items.AddRange(new object[] { "Smartphone", "Laptop", "Monitor", "PC Component", "Audio Device", "Accessories", "Storage Device", "Networking & IoT", "Power Bank", "Charger & Cables", "Gaming " });
            catCBox.Location = new Point(146, 166);
            catCBox.Name = "catCBox";
            catCBox.Size = new Size(250, 28);
            catCBox.TabIndex = 14;
            catCBox.Text = "Enter Category";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(146, 246);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 16;
            // 
            // txrPrice
            // 
            txrPrice.Location = new Point(146, 286);
            txrPrice.Name = "txrPrice";
            txrPrice.PlaceholderText = "Enter Price";
            txrPrice.Size = new Size(250, 27);
            txrPrice.TabIndex = 17;
            // 
            // StatCBox
            // 
            StatCBox.ForeColor = SystemColors.GrayText;
            StatCBox.FormattingEnabled = true;
            StatCBox.Items.AddRange(new object[] { "Available", "Low Stock", "Unavailable" });
            StatCBox.Location = new Point(146, 326);
            StatCBox.Name = "StatCBox";
            StatCBox.Size = new Size(250, 28);
            StatCBox.TabIndex = 18;
            StatCBox.Text = "Enter Status";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(96, 380);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 19;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(196, 380);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(81, 30);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(296, 380);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(81, 30);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(359, 416);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 23;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click_1;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(458, 453);
            Controls.Add(backBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Addbtn);
            Controls.Add(StatCBox);
            Controls.Add(txrPrice);
            Controls.Add(txtQuantity);
            Controls.Add(catCBox);
            Controls.Add(txtBrand);
            Controls.Add(txtPName);
            Controls.Add(txtPId);
            Controls.Add(Statuslbl);
            Controls.Add(Pricelbl);
            Controls.Add(Quantitylbl);
            Controls.Add(brandlbl);
            Controls.Add(catlbl);
            Controls.Add(PNamelbl);
            Controls.Add(pIdlbl);
            Controls.Add(productlbl);
            Controls.Add(logo);
            MaximizeBox = false;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Dashboard";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox logo;
        private Label productlbl;
        private Label pIdlbl;
        private Label PNamelbl;
        private Label catlbl;
        private Label brandlbl;
        private Label Quantitylbl;
        private Label Pricelbl;
        private Label Statuslbl;
        private TextBox txtPId;
        private TextBox txtPName;
        private TextBox txtBrand;
        private ComboBox catCBox;
        private TextBox txtQuantity;
        private TextBox txrPrice;
        private ComboBox StatCBox;
        private Button Addbtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button backBtn;
    }
}