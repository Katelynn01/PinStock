
namespace PinStock
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            dataGridView1 = new DataGridView();
            backBtn = new Button();
            customerlbl = new Label();
            logo = new PictureBox();
            txtsearch = new TextBox();
            searchBtn = new Button();
            filterCBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Lavender;
            dataGridView1.Location = new Point(36, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(730, 256);
            dataGridView1.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 24;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // customerlbl
            // 
            customerlbl.AutoSize = true;
            customerlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerlbl.Location = new Point(87, 37);
            customerlbl.Name = "customerlbl";
            customerlbl.Size = new Size(181, 25);
            customerlbl.TabIndex = 26;
            customerlbl.Text = "Customer Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 25;
            logo.TabStop = false;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(427, 47);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search Product  ";
            txtsearch.Size = new Size(250, 27);
            txtsearch.TabIndex = 34;
            txtsearch.TextAlign = HorizontalAlignment.Right;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(683, 44);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 29);
            searchBtn.TabIndex = 33;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // filterCBox
            // 
            filterCBox.ForeColor = Color.Gray;
            filterCBox.FormattingEnabled = true;
            filterCBox.Items.AddRange(new object[] { "Shipped", "Order Completed", "Pending Order", "Canceled" });
            filterCBox.Location = new Point(598, 83);
            filterCBox.Name = "filterCBox";
            filterCBox.Size = new Size(160, 28);
            filterCBox.TabIndex = 35;
            filterCBox.Text = "Filter by Status";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(filterCBox);
            Controls.Add(txtsearch);
            Controls.Add(searchBtn);
            Controls.Add(customerlbl);
            Controls.Add(logo);
            Controls.Add(backBtn);
            Controls.Add(dataGridView1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button backBtn;
        private Label customerlbl;
        private PictureBox logo;
        private TextBox txtsearch;
        private Button searchBtn;
        private ComboBox filterCBox;
        private EventHandler backBtn_Click;
    }
}