namespace PinStock
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            archivelbl = new Label();
            logo = new PictureBox();
            dgpListarchive = new DataGridView();
            plistlbl = new Label();
            olistlbl = new Label();
            dataGridView1 = new DataGridView();
            clistlbl = new Label();
            dataGridView2 = new DataGridView();
            backBtn = new Button();
            logBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgpListarchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // archivelbl
            // 
            archivelbl.AutoSize = true;
            archivelbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivelbl.Location = new Point(87, 37);
            archivelbl.Name = "archivelbl";
            archivelbl.Size = new Size(164, 25);
            archivelbl.TabIndex = 16;
            archivelbl.Text = "Archive Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 15;
            logo.TabStop = false;
            // 
            // dgpListarchive
            // 
            dgpListarchive.BackgroundColor = Color.LavenderBlush;
            dgpListarchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgpListarchive.GridColor = Color.Lavender;
            dgpListarchive.Location = new Point(82, 91);
            dgpListarchive.Name = "dgpListarchive";
            dgpListarchive.RowHeadersWidth = 51;
            dgpListarchive.Size = new Size(629, 108);
            dgpListarchive.TabIndex = 17;
            // 
            // plistlbl
            // 
            plistlbl.AutoSize = true;
            plistlbl.Location = new Point(347, 63);
            plistlbl.Name = "plistlbl";
            plistlbl.Size = new Size(86, 20);
            plistlbl.TabIndex = 21;
            plistlbl.Text = "Product List";
            // 
            // olistlbl
            // 
            olistlbl.AutoSize = true;
            olistlbl.Location = new Point(356, 215);
            olistlbl.Name = "olistlbl";
            olistlbl.Size = new Size(73, 20);
            olistlbl.TabIndex = 23;
            olistlbl.Text = "Order List";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Lavender;
            dataGridView1.Location = new Point(82, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(629, 108);
            dataGridView1.TabIndex = 22;
            // 
            // clistlbl
            // 
            clistlbl.AutoSize = true;
            clistlbl.Location = new Point(346, 358);
            clistlbl.Name = "clistlbl";
            clistlbl.Size = new Size(98, 20);
            clistlbl.TabIndex = 25;
            clistlbl.Text = "Customer List";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LavenderBlush;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Lavender;
            dataGridView2.Location = new Point(82, 386);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(629, 108);
            dataGridView2.TabIndex = 24;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 499);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 26;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // logBtn
            // 
            logBtn.Location = new Point(659, 26);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(91, 27);
            logBtn.TabIndex = 27;
            logBtn.Text = "Log";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += button1_Click;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 533);
            Controls.Add(logBtn);
            Controls.Add(clistlbl);
            Controls.Add(dataGridView2);
            Controls.Add(olistlbl);
            Controls.Add(dataGridView1);
            Controls.Add(plistlbl);
            Controls.Add(dgpListarchive);
            Controls.Add(archivelbl);
            Controls.Add(logo);
            Controls.Add(backBtn);
            Name = "Archive";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgpListarchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label archivelbl;
        private PictureBox logo;
        private DataGridView dgpListarchive;
        private Label plistlbl;
        private Label olistlbl;
        private DataGridView dataGridView1;
        private Label clistlbl;
        private DataGridView dataGridView2;
        private Button backBtn;
        private Button logBtn;
    }
}