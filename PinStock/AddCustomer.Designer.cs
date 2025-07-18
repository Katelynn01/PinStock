namespace PinStock
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            customerlbl = new Label();
            logo = new PictureBox();
            txtaddress = new TextBox();
            addresslbl = new Label();
            txtContactNum = new TextBox();
            contactNumlbl = new Label();
            cIdlbl = new Label();
            txtCustId = new TextBox();
            txtCName = new TextBox();
            cNamelbl = new Label();
            updateBtn = new Button();
            Addbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // customerlbl
            // 
            customerlbl.AutoSize = true;
            customerlbl.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerlbl.Location = new Point(87, 37);
            customerlbl.Name = "customerlbl";
            customerlbl.Size = new Size(181, 25);
            customerlbl.TabIndex = 28;
            customerlbl.Text = "Customer Dashboard";
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(69, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 27;
            logo.TabStop = false;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(56, 286);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Enter Address";
            txtaddress.Size = new Size(250, 27);
            txtaddress.TabIndex = 38;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Location = new Point(56, 263);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(62, 20);
            addresslbl.TabIndex = 37;
            addresslbl.Text = "Address";
            // 
            // txtContactNum
            // 
            txtContactNum.Location = new Point(56, 233);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.PlaceholderText = "Enter Contact Number";
            txtContactNum.Size = new Size(250, 27);
            txtContactNum.TabIndex = 36;
            // 
            // contactNumlbl
            // 
            contactNumlbl.AutoSize = true;
            contactNumlbl.Location = new Point(56, 210);
            contactNumlbl.Name = "contactNumlbl";
            contactNumlbl.Size = new Size(118, 20);
            contactNumlbl.TabIndex = 35;
            contactNumlbl.Text = "Contact Number";
            // 
            // cIdlbl
            // 
            cIdlbl.AutoSize = true;
            cIdlbl.Location = new Point(56, 100);
            cIdlbl.Name = "cIdlbl";
            cIdlbl.Size = new Size(91, 20);
            cIdlbl.TabIndex = 34;
            cIdlbl.Text = "Customer ID";
            // 
            // txtCustId
            // 
            txtCustId.Location = new Point(56, 123);
            txtCustId.Name = "txtCustId";
            txtCustId.ReadOnly = true;
            txtCustId.Size = new Size(250, 27);
            txtCustId.TabIndex = 33;
            // 
            // txtCName
            // 
            txtCName.Location = new Point(56, 178);
            txtCName.Name = "txtCName";
            txtCName.PlaceholderText = "Enter Customer Name";
            txtCName.Size = new Size(250, 27);
            txtCName.TabIndex = 32;
            // 
            // cNamelbl
            // 
            cNamelbl.AutoSize = true;
            cNamelbl.Location = new Point(56, 155);
            cNamelbl.Name = "cNamelbl";
            cNamelbl.Size = new Size(116, 20);
            cNamelbl.TabIndex = 30;
            cNamelbl.Text = "Customer Name";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(187, 351);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(81, 30);
            updateBtn.TabIndex = 40;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(87, 351);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(81, 30);
            Addbtn.TabIndex = 39;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(357, 450);
            Controls.Add(updateBtn);
            Controls.Add(Addbtn);
            Controls.Add(txtaddress);
            Controls.Add(addresslbl);
            Controls.Add(txtContactNum);
            Controls.Add(contactNumlbl);
            Controls.Add(cIdlbl);
            Controls.Add(txtCustId);
            Controls.Add(txtCName);
            Controls.Add(cNamelbl);
            Controls.Add(customerlbl);
            Controls.Add(logo);
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerlbl;
        private PictureBox logo;
        private TextBox txtaddress;
        private Label addresslbl;
        private TextBox txtContactNum;
        private Label contactNumlbl;
        private Label cIdlbl;
        private TextBox txtCustId;
        private TextBox txtCName;
        private Label cNamelbl;
        private Button updateBtn;
        private Button Addbtn;
    }
}