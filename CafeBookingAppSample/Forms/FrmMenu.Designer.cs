namespace CafeBookingAppSample.Forms
{
    partial class FrmMenu
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblBaşlık = new Label();
            lblAcıklama = new Label();
            lblPrice = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnCustomers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(565, 222);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(287, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(158, 160);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBaşlık
            // 
            lblBaşlık.AutoSize = true;
            lblBaşlık.Location = new Point(29, 34);
            lblBaşlık.Name = "lblBaşlık";
            lblBaşlık.Size = new Size(34, 15);
            lblBaşlık.TabIndex = 4;
            lblBaşlık.Text = "TITLE";
            // 
            // lblAcıklama
            // 
            lblAcıklama.AutoSize = true;
            lblAcıklama.Location = new Point(30, 64);
            lblAcıklama.Name = "lblAcıklama";
            lblAcıklama.Size = new Size(79, 15);
            lblAcıklama.TabIndex = 5;
            lblAcıklama.Text = "DESCRIPTION";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(32, 96);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "PRİCE";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(175, 28);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(208, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(175, 64);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(208, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(175, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(208, 23);
            txtPrice.TabIndex = 7;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(417, 160);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(96, 40);
            btnCustomers.TabIndex = 8;
            btnCustomers.Text = "CUSTOMERS";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 445);
            Controls.Add(btnCustomers);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblPrice);
            Controls.Add(lblAcıklama);
            Controls.Add(lblBaşlık);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblBaşlık;
        private Label lblAcıklama;
        private Label lblPrice;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnCustomers;
    }
}