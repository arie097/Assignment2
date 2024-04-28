namespace Assignment2
{
    partial class Customers
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
            panel1 = new Panel();
            label7 = new Label();
            email = new TextBox();
            label6 = new Label();
            address = new TextBox();
            label5 = new Label();
            phoneNumber = new TextBox();
            label4 = new Label();
            custName = new TextBox();
            label3 = new Label();
            addcust_btn = new Button();
            label1 = new Label();
            panel2 = new Panel();
            updatecust_btn = new Button();
            removecust_btn = new Button();
            customerIdTextBox = new TextBox();
            label8 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(address);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(phoneNumber);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(custName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addcust_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 437);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(114, 65);
            label7.Name = "label7";
            label7.Size = new Size(142, 15);
            label7.TabIndex = 24;
            label7.Text = "(Fill up also for updating)";
            // 
            // email
            // 
            email.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(191, 264);
            email.Name = "email";
            email.Size = new Size(155, 27);
            email.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(191, 242);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 22;
            label6.Text = "Email";
            // 
            // address
            // 
            address.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(17, 264);
            address.Name = "address";
            address.Size = new Size(155, 27);
            address.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 242);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 20;
            label5.Text = "Address";
            // 
            // phoneNumber
            // 
            phoneNumber.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(191, 186);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(155, 27);
            phoneNumber.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 164);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 18;
            label4.Text = "Phone Number";
            // 
            // custName
            // 
            custName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custName.Location = new Point(17, 186);
            custName.Name = "custName";
            custName.Size = new Size(155, 27);
            custName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 164);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 16;
            label3.Text = "Customer Name";
            // 
            // addcust_btn
            // 
            addcust_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addcust_btn.Location = new Point(97, 360);
            addcust_btn.Name = "addcust_btn";
            addcust_btn.Size = new Size(143, 35);
            addcust_btn.TabIndex = 9;
            addcust_btn.Text = "Add Customer";
            addcust_btn.UseVisualStyleBackColor = true;
            addcust_btn.Click += addcust_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 26);
            label1.Name = "label1";
            label1.Size = new Size(239, 39);
            label1.TabIndex = 8;
            label1.Text = "Add a Customer";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(updatecust_btn);
            panel2.Controls.Add(removecust_btn);
            panel2.Controls.Add(customerIdTextBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(389, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 437);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // updatecust_btn
            // 
            updatecust_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatecust_btn.Location = new Point(68, 242);
            updatecust_btn.Name = "updatecust_btn";
            updatecust_btn.Size = new Size(143, 35);
            updatecust_btn.TabIndex = 17;
            updatecust_btn.Text = "Update";
            updatecust_btn.UseVisualStyleBackColor = true;
            updatecust_btn.Click += updatecust_btn_Click;
            // 
            // removecust_btn
            // 
            removecust_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removecust_btn.Location = new Point(50, 292);
            removecust_btn.Name = "removecust_btn";
            removecust_btn.Size = new Size(175, 35);
            removecust_btn.TabIndex = 16;
            removecust_btn.Text = "Remove Customer";
            removecust_btn.UseVisualStyleBackColor = true;
            removecust_btn.Click += removecust_btn_Click;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIdTextBox.Location = new Point(68, 166);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(143, 27);
            customerIdTextBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(68, 144);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 24;
            label8.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(272, 39);
            label2.TabIndex = 8;
            label2.Text = "Update or Remove";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(682, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(596, 437);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(12, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 19);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back to Menu Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(682, 8);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(63, 19);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Refresh";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1304, 495);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox email;
        private Label label6;
        private TextBox address;
        private Label label5;
        private TextBox phoneNumber;
        private Label label4;
        private TextBox custName;
        private Label label3;
        private Button addcust_btn;
        private Label label1;
        private Panel panel2;
        private Button updatecust_btn;
        private Button removecust_btn;
        private TextBox customerIdTextBox;
        private Label label8;
        private Label label2;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}