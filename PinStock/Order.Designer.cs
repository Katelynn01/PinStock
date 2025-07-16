namespace PinStock
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            dgOrder = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            searchBtn = new Button();
            aoBtn = new Button();
            logo = new PictureBox();
            productlbl = new Label();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // dgOrder
            // 
            dgOrder.BackgroundColor = Color.LavenderBlush;
            dgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrder.GridColor = Color.Lavender;
            dgOrder.Location = new Point(63, 177);
            dgOrder.Name = "dgOrder";
            dgOrder.RowHeadersWidth = 51;
            dgOrder.Size = new Size(678, 196);
            dgOrder.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 104);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search order";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLight;
            comboBox1.ForeColor = SystemColors.GrayText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(649, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 28);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "Filter by Status";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(566, 104);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(70, 27);
            searchBtn.TabIndex = 18;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // aoBtn
            // 
            aoBtn.Location = new Point(658, 35);
            aoBtn.Name = "aoBtn";
            aoBtn.Size = new Size(107, 27);
            aoBtn.TabIndex = 19;
            aoBtn.Text = "Add Order";
            aoBtn.UseVisualStyleBackColor = true;
            aoBtn.Click += aoBtn_Click;
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
            // productlbl
            // 
            productlbl.AutoSize = true;
            productlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productlbl.Location = new Point(87, 37);
            productlbl.Name = "productlbl";
            productlbl.Size = new Size(148, 25);
            productlbl.TabIndex = 14;
            productlbl.Text = "Order Dashboard";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(699, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 29;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(aoBtn);
            Controls.Add(searchBtn);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgOrder);
            Controls.Add(productlbl);
            Controls.Add(logo);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Dashboard";
            ((System.ComponentModel.ISupportInitialize)dgOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgOrder;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button searchBtn;
        private Button aoBtn;
        private PictureBox logo;
        private Label productlbl;
        private Button backBtn;
    }
}