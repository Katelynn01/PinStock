
namespace PinStock
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            txtCName = new TextBox();
            txtOId = new TextBox();
            cNamelbl = new Label();
            oIdlbl = new Label();
            orderlbl = new Label();
            logo = new PictureBox();
            txtCustId = new TextBox();
            cIdlbl = new Label();
            txtContactNum = new TextBox();
            contactNumlbl = new Label();
            txtaddress = new TextBox();
            addresslbl = new Label();
            deleteBtn = new Button();
            updateBtn = new Button();
            Addbtn = new Button();
            backBtn = new Button();
            productlistlbl = new Label();
            dgProductList = new DataGridView();
            searchBtn = new Button();
            txtsearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).BeginInit();
            SuspendLayout();
            // 
            // txtCName
            // 
            txtCName.Location = new Point(30, 243);
            txtCName.Name = "txtCName";
            txtCName.PlaceholderText = "Enter Customer Name";
            txtCName.Size = new Size(250, 27);
            txtCName.TabIndex = 18;
            // 
            // txtOId
            // 
            txtOId.Location = new Point(30, 133);
            txtOId.Name = "txtOId";
            txtOId.ReadOnly = true;
            txtOId.Size = new Size(250, 27);
            txtOId.TabIndex = 17;
            // 
            // cNamelbl
            // 
            cNamelbl.AutoSize = true;
            cNamelbl.Location = new Point(30, 220);
            cNamelbl.Name = "cNamelbl";
            cNamelbl.Size = new Size(116, 20);
            cNamelbl.TabIndex = 16;
            cNamelbl.Text = "Customer Name";
            // 
            // oIdlbl
            // 
            oIdlbl.AutoSize = true;
            oIdlbl.Location = new Point(30, 110);
            oIdlbl.Name = "oIdlbl";
            oIdlbl.Size = new Size(66, 20);
            oIdlbl.TabIndex = 15;
            oIdlbl.Text = "Order ID";
            // 
            // orderlbl
            // 
            orderlbl.AutoSize = true;
            orderlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderlbl.Location = new Point(87, 37);
            orderlbl.Name = "orderlbl";
            orderlbl.Size = new Size(148, 25);
            orderlbl.TabIndex = 14;
            orderlbl.Text = "Order Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 13;
            logo.TabStop = false;
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(30, 188);
            txtCustId.Name = "txtCustId";
            txtCustId.ReadOnly = true;
            txtCustId.Size = new Size(250, 27);
            txtCustId.TabIndex = 19;
            
            // 
            // cIdlbl
            // 
            cIdlbl.AutoSize = true;
            cIdlbl.Location = new Point(30, 165);
            cIdlbl.Name = "cIdlbl";
            cIdlbl.Size = new Size(91, 20);
            cIdlbl.TabIndex = 20;
            cIdlbl.Text = "Customer ID";
            // 
            // txtContactNum
            // 
            txtContactNum.Location = new Point(30, 298);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.PlaceholderText = "Enter Contact Number";
            txtContactNum.Size = new Size(250, 27);
            txtContactNum.TabIndex = 22;
            // 
            // contactNumlbl
            // 
            contactNumlbl.AutoSize = true;
            contactNumlbl.Location = new Point(30, 275);
            contactNumlbl.Name = "contactNumlbl";
            contactNumlbl.Size = new Size(118, 20);
            contactNumlbl.TabIndex = 21;
            contactNumlbl.Text = "Contact Number";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(30, 351);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Enter Address";
            txtaddress.Size = new Size(250, 27);
            txtaddress.TabIndex = 24;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Location = new Point(30, 328);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(62, 20);
            addresslbl.TabIndex = 23;
            addresslbl.Text = "Address";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(265, 398);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(81, 30);
            deleteBtn.TabIndex = 27;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(165, 398);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(81, 30);
            updateBtn.TabIndex = 26;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(65, 398);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 25;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 28;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += this.backBtn_Click;
            // 
            // productlistlbl
            // 
            productlistlbl.AutoSize = true;
            productlistlbl.Location = new Point(533, 98);
            productlistlbl.Name = "productlistlbl";
            productlistlbl.Size = new Size(86, 20);
            productlistlbl.TabIndex = 29;
            productlistlbl.Text = "Product List";
            // 
            // dgProductList
            // 
            dgProductList.BackgroundColor = Color.LavenderBlush;
            dgProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductList.GridColor = Color.Lavender;
            dgProductList.Location = new Point(387, 129);
            dgProductList.Name = "dgProductList";
            dgProductList.RowHeadersWidth = 51;
            dgProductList.Size = new Size(377, 266);
            dgProductList.TabIndex = 30;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(673, 44);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 29);
            searchBtn.TabIndex = 31;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(417, 47);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search Product  ";
            txtsearch.Size = new Size(250, 27);
            txtsearch.TabIndex = 32;
            txtsearch.TextAlign = HorizontalAlignment.Right;
            // 
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsearch);
            Controls.Add(searchBtn);
            Controls.Add(dgProductList);
            Controls.Add(productlistlbl);
            Controls.Add(backBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Addbtn);
            Controls.Add(txtaddress);
            Controls.Add(addresslbl);
            Controls.Add(txtContactNum);
            Controls.Add(contactNumlbl);
            Controls.Add(cIdlbl);
            Controls.Add(txtCustId);
            Controls.Add(txtCName);
            Controls.Add(txtOId);
            Controls.Add(cNamelbl);
            Controls.Add(oIdlbl);
            Controls.Add(orderlbl);
            Controls.Add(logo);
            Name = "AddOrder";
            Text = "Order Dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCName;
        private TextBox txtOId;
        private Label cNamelbl;
        private Label oIdlbl;
        private Label orderlbl;
        private PictureBox logo;
        private TextBox txtCustId;
        private Label cIdlbl;
        private TextBox txtContactNum;
        private Label contactNumlbl;
        private TextBox txtaddress;
        private Label addresslbl;
        private Button deleteBtn;
        private Button updateBtn;
        private Button Addbtn;
        private Button backBtn;
        private Label productlistlbl;
        private DataGridView dgProductList;
        private Button searchBtn;
        private TextBox txtsearch;
        
    }
}