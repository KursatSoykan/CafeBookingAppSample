namespace CafeBookingAppSample.Forms
{
    partial class FrmCustomers
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
            dataGridView1 = new DataGridView();
            lblName = new Label();
            lblSurName = new Label();
            lblMail = new Label();
            lblPhone = new Label();
            lblAdress = new Label();
            txtName = new TextBox();
            txtSurName = new TextBox();
            txtMail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnListele = new Button();
            lblListeleme = new Label();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(723, 326);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(731, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // lblSurName
            // 
            lblSurName.AutoSize = true;
            lblSurName.Location = new Point(731, 125);
            lblSurName.Name = "lblSurName";
            lblSurName.Size = new Size(56, 15);
            lblSurName.TabIndex = 2;
            lblSurName.Text = "SurName";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(731, 181);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 3;
            lblMail.Text = "Mail";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(731, 226);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(731, 275);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(49, 15);
            lblAdress.TabIndex = 5;
            lblAdress.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(837, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 6;
            // 
            // txtSurName
            // 
            txtSurName.Location = new Point(837, 122);
            txtSurName.Name = "txtSurName";
            txtSurName.Size = new Size(157, 23);
            txtSurName.TabIndex = 7;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(837, 178);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(157, 23);
            txtMail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(837, 223);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(837, 275);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(157, 23);
            txtAddress.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(731, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(891, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 43);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(399, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(248, 12);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(101, 37);
            btnListele.TabIndex = 14;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // lblListeleme
            // 
            lblListeleme.AutoSize = true;
            lblListeleme.Location = new Point(12, 24);
            lblListeleme.Name = "lblListeleme";
            lblListeleme.Size = new Size(0, 15);
            lblListeleme.TabIndex = 15;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(555, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(101, 37);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // FrmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 406);
            Controls.Add(btnMenu);
            Controls.Add(lblListeleme);
            Controls.Add(btnListele);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtMail);
            Controls.Add(txtSurName);
            Controls.Add(txtName);
            Controls.Add(lblAdress);
            Controls.Add(lblPhone);
            Controls.Add(lblMail);
            Controls.Add(lblSurName);
            Controls.Add(lblName);
            Controls.Add(dataGridView1);
            Name = "FrmCustomers";
            Text = "FrmCustomers";
            Load += FrmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblName;
        private Label lblSurName;
        private Label lblMail;
        private Label lblPhone;
        private Label lblAdress;
        private TextBox txtName;
        private TextBox txtSurName;
        private TextBox txtMail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnListele;
        private Label lblListeleme;
        private Button btnMenu;
    }
}