
namespace PinStock
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
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
            label1 = new Label();
            Addbtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            archiveBtn = new Button();
            backBtn = new Button();
            dgProductList = new DataGridView();
            searchlbl = new Label();
            txtsearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).BeginInit();
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
            pIdlbl.Location = new Point(30, 110);
            pIdlbl.Name = "pIdlbl";
            pIdlbl.Size = new Size(79, 20);
            pIdlbl.TabIndex = 4;
            pIdlbl.Text = "Product ID";
            // 
            // PNamelbl
            // 
            PNamelbl.AutoSize = true;
            PNamelbl.Location = new Point(30, 150);
            PNamelbl.Name = "PNamelbl";
            PNamelbl.Size = new Size(104, 20);
            PNamelbl.TabIndex = 5;
            PNamelbl.Text = "Product Name";
            // 
            // catlbl
            // 
            catlbl.AutoSize = true;
            catlbl.Location = new Point(30, 190);
            catlbl.Name = "catlbl";
            catlbl.Size = new Size(69, 20);
            catlbl.TabIndex = 6;
            catlbl.Text = "Category";
            // 
            // brandlbl
            // 
            brandlbl.AutoSize = true;
            brandlbl.Location = new Point(30, 230);
            brandlbl.Name = "brandlbl";
            brandlbl.Size = new Size(48, 20);
            brandlbl.TabIndex = 7;
            brandlbl.Text = "Brand";
            // 
            // Quantitylbl
            // 
            Quantitylbl.AutoSize = true;
            Quantitylbl.Location = new Point(30, 270);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(65, 20);
            Quantitylbl.TabIndex = 8;
            Quantitylbl.Text = "Quantity";
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Location = new Point(30, 310);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(41, 20);
            Pricelbl.TabIndex = 9;
            Pricelbl.Text = "Price";
            // 
            // Statuslbl
            // 
            Statuslbl.AutoSize = true;
            Statuslbl.Location = new Point(30, 350);
            Statuslbl.Name = "Statuslbl";
            Statuslbl.Size = new Size(49, 20);
            Statuslbl.TabIndex = 10;
            Statuslbl.Text = "Status";
            // 
            // txtPId
            // 
            txtPId.Location = new Point(152, 110);
            txtPId.Name = "txtPId";
            txtPId.ReadOnly = true;
            txtPId.Size = new Size(250, 27);
            txtPId.TabIndex = 11;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(152, 150);
            txtPName.Name = "txtPName";
            txtPName.PlaceholderText = "Enter Product Name";
            txtPName.Size = new Size(250, 27);
            txtPName.TabIndex = 12;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(152, 230);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Enter Brand";
            txtBrand.Size = new Size(250, 27);
            txtBrand.TabIndex = 13;
            // 
            // catCBox
            // 
            catCBox.ForeColor = SystemColors.GrayText;
            catCBox.FormattingEnabled = true;
            catCBox.Location = new Point(152, 190);
            catCBox.Name = "catCBox";
            catCBox.Size = new Size(250, 28);
            catCBox.TabIndex = 14;
            catCBox.Text = "Enter Category";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(152, 270);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter Quantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 15;
            // 
            // txrPrice
            // 
            txrPrice.Location = new Point(152, 310);
            txrPrice.Name = "txrPrice";
            txrPrice.PlaceholderText = "Enter Price";
            txrPrice.Size = new Size(250, 27);
            txrPrice.TabIndex = 16;
            // 
            // StatCBox
            // 
            StatCBox.ForeColor = SystemColors.GrayText;
            StatCBox.FormattingEnabled = true;
            StatCBox.Items.AddRange(new object[] { "Available", "Low Stock", "Unavailable" });
            StatCBox.Location = new Point(152, 350);
            StatCBox.Name = "StatCBox";
            StatCBox.Size = new Size(250, 28);
            StatCBox.TabIndex = 17;
            StatCBox.Text = "Enter Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 18;
            label1.Text = "Product ID";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(100, 408);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 19;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(200, 408);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(81, 30);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(300, 408);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(81, 30);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // archiveBtn
            // 
            archiveBtn.Location = new Point(400, 408);
            archiveBtn.Name = "archiveBtn";
            archiveBtn.Size = new Size(81, 30);
            archiveBtn.TabIndex = 22;
            archiveBtn.Text = " Archive";
            archiveBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 23;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click_1;
            // 
            // dgProductList
            // 
            dgProductList.BackgroundColor = Color.LavenderBlush;
            dgProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductList.GridColor = Color.Lavender;
            dgProductList.Location = new Point(479, 98);
            dgProductList.Name = "dgProductList";
            dgProductList.RowHeadersWidth = 51;
            dgProductList.Size = new Size(264, 310);
            dgProductList.TabIndex = 26;
            // 
            // searchlbl
            // 
            searchlbl.AutoSize = true;
            searchlbl.Font = new Font("Segoe UI", 10F);
            searchlbl.Location = new Point(436, 40);
            searchlbl.Name = "searchlbl";
            searchlbl.Size = new Size(70, 23);
            searchlbl.TabIndex = 24;
            searchlbl.Text = "Search: ";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(501, 36);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search Product";
            txtsearch.Size = new Size(224, 27);
            txtsearch.TabIndex = 25;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(797, 453);
            Controls.Add(dgProductList);
            Controls.Add(txtsearch);
            Controls.Add(searchlbl);
            Controls.Add(backBtn);
            Controls.Add(archiveBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Addbtn);
            Controls.Add(label1);
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
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Dashboard";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).EndInit();
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
        private Label label1;
        private Button Addbtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button archiveBtn;
        private Button backBtn;
        private DataGridView dgProductList;
        private Label searchlbl;
        private TextBox txtsearch;
    }
}