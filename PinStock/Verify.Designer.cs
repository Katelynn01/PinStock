namespace PinStock
{
    partial class Verify
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
            label1 = new Label();
            passlbl = new Label();
            txtpass = new TextBox();
            pCheckBox = new CheckBox();
            cpassCheckBox = new CheckBox();
            txtCpass = new TextBox();
            Cpasslbl = new Label();
            confirmBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 58);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Verify if its you";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.Location = new Point(22, 161);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(141, 20);
            passlbl.TabIndex = 1;
            passlbl.Text = "Enter your Password";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(50, 195);
            txtpass.Name = "txtpass";
            txtpass.PlaceholderText = "Enter your Password";
            txtpass.Size = new Size(235, 27);
            txtpass.TabIndex = 2;
            // 
            // pCheckBox
            // 
            pCheckBox.AutoSize = true;
            pCheckBox.Location = new Point(262, 201);
            pCheckBox.Name = "pCheckBox";
            pCheckBox.Size = new Size(18, 17);
            pCheckBox.TabIndex = 3;
            pCheckBox.UseVisualStyleBackColor = true;
            pCheckBox.CheckedChanged += pCheckBox_CheckedChanged;
            // 
            // cpassCheckBox
            // 
            cpassCheckBox.AutoSize = true;
            cpassCheckBox.Location = new Point(262, 272);
            cpassCheckBox.Name = "cpassCheckBox";
            cpassCheckBox.Size = new Size(18, 17);
            cpassCheckBox.TabIndex = 6;
            cpassCheckBox.UseVisualStyleBackColor = true;
            cpassCheckBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // txtCpass
            // 
            txtCpass.Location = new Point(50, 266);
            txtCpass.Name = "txtCpass";
            txtCpass.PlaceholderText = "Confirm Password";
            txtCpass.Size = new Size(235, 27);
            txtCpass.TabIndex = 5;
            // 
            // Cpasslbl
            // 
            Cpasslbl.AutoSize = true;
            Cpasslbl.Location = new Point(22, 232);
            Cpasslbl.Name = "Cpasslbl";
            Cpasslbl.Size = new Size(127, 20);
            Cpasslbl.TabIndex = 4;
            Cpasslbl.Text = "Confirm Password";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(103, 328);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(107, 36);
            confirmBtn.TabIndex = 7;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_CLick;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(219, 402);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(107, 36);
            backBtn.TabIndex = 8;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Verify
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(338, 450);
            Controls.Add(backBtn);
            Controls.Add(confirmBtn);
            Controls.Add(cpassCheckBox);
            Controls.Add(txtCpass);
            Controls.Add(Cpasslbl);
            Controls.Add(pCheckBox);
            Controls.Add(txtpass);
            Controls.Add(passlbl);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Verify";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verification";
            Load += Verify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label passlbl;
        private TextBox txtpass;
        private CheckBox pCheckBox;
        private CheckBox cpassCheckBox;
        private TextBox txtCpass;
        private Label Cpasslbl;
        private Button confirmBtn;
        private Button backBtn;
    }
}