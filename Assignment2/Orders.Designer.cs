namespace Assignment2
{
    partial class Orders
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
            label5 = new Label();
            ordQuantityTextBox = new TextBox();
            addorder_btn = new Button();
            orderDate = new DateTimePicker();
            orderQuantity = new Label();
            label6 = new Label();
            productIdTextBox = new TextBox();
            label3 = new Label();
            customerName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            removeorder_btn = new Button();
            orderIdTextBox = new TextBox();
            label7 = new Label();
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ordQuantityTextBox);
            panel1.Controls.Add(addorder_btn);
            panel1.Controls.Add(orderDate);
            panel1.Controls.Add(orderQuantity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(productIdTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(customerName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 437);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 55);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 25;
            label5.Text = "(Fill up also for updating)";
            // 
            // ordQuantityTextBox
            // 
            ordQuantityTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordQuantityTextBox.Location = new Point(91, 298);
            ordQuantityTextBox.Name = "ordQuantityTextBox";
            ordQuantityTextBox.Size = new Size(155, 27);
            ordQuantityTextBox.TabIndex = 19;
            // 
            // addorder_btn
            // 
            addorder_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addorder_btn.Location = new Point(103, 365);
            addorder_btn.Name = "addorder_btn";
            addorder_btn.Size = new Size(143, 35);
            addorder_btn.TabIndex = 9;
            addorder_btn.Text = "Add Order";
            addorder_btn.UseVisualStyleBackColor = true;
            addorder_btn.Click += addorder_btn_Click;
            // 
            // orderDate
            // 
            orderDate.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderDate.Location = new Point(48, 226);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(250, 27);
            orderDate.TabIndex = 10;
            // 
            // orderQuantity
            // 
            orderQuantity.AutoSize = true;
            orderQuantity.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderQuantity.Location = new Point(91, 275);
            orderQuantity.Name = "orderQuantity";
            orderQuantity.Size = new Size(67, 19);
            orderQuantity.TabIndex = 18;
            orderQuantity.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 204);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 16;
            label6.Text = "Order Date";
            // 
            // productIdTextBox
            // 
            productIdTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productIdTextBox.Location = new Point(181, 153);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(146, 27);
            productIdTextBox.TabIndex = 15;
            productIdTextBox.TextChanged += productId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 131);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 14;
            label3.Text = "Product ID";
            // 
            // customerName
            // 
            customerName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerName.Location = new Point(13, 153);
            customerName.Name = "customerName";
            customerName.Size = new Size(145, 27);
            customerName.TabIndex = 13;
            customerName.TextChanged += txtusername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 131);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 12;
            label4.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 16);
            label1.Name = "label1";
            label1.Size = new Size(203, 39);
            label1.TabIndex = 8;
            label1.Text = "Add an Order";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(removeorder_btn);
            panel2.Controls.Add(orderIdTextBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(369, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 437);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(60, 250);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 17;
            button1.Text = "Update Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // removeorder_btn
            // 
            removeorder_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeorder_btn.Location = new Point(60, 301);
            removeorder_btn.Name = "removeorder_btn";
            removeorder_btn.Size = new Size(143, 35);
            removeorder_btn.TabIndex = 16;
            removeorder_btn.Text = "Remove Order";
            removeorder_btn.UseVisualStyleBackColor = true;
            removeorder_btn.Click += removeorder_btn_Click;
            // 
            // orderIdTextBox
            // 
            orderIdTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIdTextBox.Location = new Point(60, 163);
            orderIdTextBox.Name = "orderIdTextBox";
            orderIdTextBox.Size = new Size(143, 27);
            orderIdTextBox.TabIndex = 15;
            orderIdTextBox.TextChanged += orderId_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 141);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 14;
            label7.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 21);
            label2.Name = "label2";
            label2.Size = new Size(240, 34);
            label2.TabIndex = 8;
            label2.Text = "Update or Remove";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(646, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 437);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(22, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 19);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back to Menu Page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(646, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(63, 19);
            linkLabel2.TabIndex = 21;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Refresh";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1337, 495);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button addorder_btn;
        private DateTimePicker orderDate;
        private Label orderQuantity;
        private Label label6;
        private TextBox productIdTextBox;
        private Label label3;
        private TextBox customerName;
        private Label label4;
        private TextBox orderIdTextBox;
        private Label label7;
        private Button removeorder_btn;
        private Button button1;
        private TextBox ordQuantityTextBox;
        private LinkLabel linkLabel1;
        private Label label5;
        private LinkLabel linkLabel2;
    }
}