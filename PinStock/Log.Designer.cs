namespace PinStock
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            dgpListarchive = new DataGridView();
            archivelbl = new Label();
            logo = new PictureBox();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgpListarchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // dgpListarchive
            // 
            dgpListarchive.BackgroundColor = Color.LavenderBlush;
            dgpListarchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgpListarchive.GridColor = Color.Lavender;
            dgpListarchive.Location = new Point(87, 124);
            dgpListarchive.Name = "dgpListarchive";
            dgpListarchive.RowHeadersWidth = 51;
            dgpListarchive.Size = new Size(629, 267);
            dgpListarchive.TabIndex = 20;
            // 
            // archivelbl
            // 
            archivelbl.AutoSize = true;
            archivelbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivelbl.Location = new Point(87, 37);
            archivelbl.Name = "archivelbl";
            archivelbl.Size = new Size(131, 25);
            archivelbl.TabIndex = 19;
            archivelbl.Text = "Log Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 18;
            logo.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(697, 411);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(91, 27);
            backBtn.TabIndex = 27;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += this.backBtn_Click;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(dgpListarchive);
            Controls.Add(archivelbl);
            Controls.Add(logo);
            Name = "Log";
            Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)dgpListarchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgpListarchive;
        private Label archivelbl;
        private PictureBox logo;
        private Button backBtn;
    }
}