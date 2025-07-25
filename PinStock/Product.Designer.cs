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
            deleteBtn = new Button();
            updateBtn = new Button();
            Addbtn = new Button();
            filterCBox = new ComboBox();
            txtsearch = new TextBox();
            searchBtn = new Button();
            customerlbl = new Label();
            logo = new PictureBox();
            backBtn = new Button();
            dgProductlist = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductlist).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(702, 367);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(81, 30);
            deleteBtn.TabIndex = 48;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(602, 367);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(81, 30);
            updateBtn.TabIndex = 47;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(502, 367);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 46;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // filterCBox
            // 
            filterCBox.ForeColor = Color.Gray;
            filterCBox.FormattingEnabled = true;
            filterCBox.Items.AddRange(new object[] { "Shipped", "Order Completed", "Pending Order", "Canceled" });
            filterCBox.Location = new Point(658, 83);
            filterCBox.Name = "filterCBox";
            filterCBox.Size = new Size(108, 28);
            filterCBox.TabIndex = 45;
            filterCBox.Text = "Category";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(354, 84);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search Product  ";
            txtsearch.Size = new Size(207, 27);
            txtsearch.TabIndex = 43;
            txtsearch.TextAlign = HorizontalAlignment.Right;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(567, 84);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 29);
            searchBtn.TabIndex = 44;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // customerlbl
            // 
            customerlbl.AutoSize = true;
            customerlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerlbl.Location = new Point(87, 37);
            customerlbl.Name = "customerlbl";
            customerlbl.Size = new Size(166, 25);
            customerlbl.TabIndex = 42;
            customerlbl.Text = "Product Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 41;
            logo.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 49;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dgProductlist
            // 
            dgProductlist.BackgroundColor = Color.LavenderBlush;
            dgProductlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductlist.GridColor = Color.Lavender;
            dgProductlist.Location = new Point(36, 132);
            dgProductlist.Name = "dgProductlist";
            dgProductlist.RowHeadersWidth = 51;
            dgProductlist.Size = new Size(730, 220);
            dgProductlist.TabIndex = 40;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(Addbtn);
            Controls.Add(filterCBox);
            Controls.Add(txtsearch);
            Controls.Add(searchBtn);
            Controls.Add(customerlbl);
            Controls.Add(logo);
            Controls.Add(backBtn);
            Controls.Add(dgProductlist);
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Dashboard";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private Button updateBtn;
        private Button Addbtn;
        private ComboBox filterCBox;
        private TextBox txtsearch;
        private Button searchBtn;
        private Label customerlbl;
        private PictureBox logo;
        private Button backBtn;
        private DataGridView dgProductlist;
    }
}