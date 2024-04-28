namespace Assignment2
{
    partial class Products
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
            productQuantity = new TextBox();
            label6 = new Label();
            price = new TextBox();
            label5 = new Label();
            description = new TextBox();
            label4 = new Label();
            productName = new TextBox();
            label3 = new Label();
            addprod_btn = new Button();
            label1 = new Label();
            productIdTextBox = new TextBox();
            label8 = new Label();
            update_btn = new Button();
            panel2 = new Panel();
            removeprod_btn = new Button();
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
            panel1.Controls.Add(productQuantity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(price);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(description);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(productName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addprod_btn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 437);
            panel1.TabIndex = 1;
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
            label7.Click += label7_Click;
            // 
            // productQuantity
            // 
            productQuantity.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productQuantity.Location = new Point(202, 239);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(155, 27);
            productQuantity.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(202, 217);
            label6.Name = "label6";
            label6.Size = new Size(125, 19);
            label6.TabIndex = 22;
            label6.Text = "Product Quantity";
            // 
            // price
            // 
            price.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(13, 239);
            price.Name = "price";
            price.Size = new Size(155, 27);
            price.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 217);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 20;
            label5.Text = "Price";
            // 
            // description
            // 
            description.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.Location = new Point(202, 166);
            description.Name = "description";
            description.Size = new Size(155, 27);
            description.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 144);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 18;
            label4.Text = "Description";
            // 
            // productName
            // 
            productName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName.Location = new Point(13, 166);
            productName.Name = "productName";
            productName.Size = new Size(155, 27);
            productName.TabIndex = 17;
            productName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 144);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 16;
            label3.Text = "Product Name";
            // 
            // addprod_btn
            // 
            addprod_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addprod_btn.Location = new Point(101, 363);
            addprod_btn.Name = "addprod_btn";
            addprod_btn.Size = new Size(143, 35);
            addprod_btn.TabIndex = 9;
            addprod_btn.Text = "Add Product";
            addprod_btn.UseVisualStyleBackColor = true;
            addprod_btn.Click += addprod_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 26);
            label1.Name = "label1";
            label1.Size = new Size(213, 39);
            label1.TabIndex = 8;
            label1.Text = "Add a Product";
            label1.Click += label1_Click;
            // 
            // productIdTextBox
            // 
            productIdTextBox.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productIdTextBox.Location = new Point(68, 166);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(143, 27);
            productIdTextBox.TabIndex = 25;
            productIdTextBox.TextChanged += productId_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(68, 144);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 24;
            label8.Text = "Product ID";
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(68, 242);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(143, 35);
            update_btn.TabIndex = 17;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(update_btn);
            panel2.Controls.Add(removeprod_btn);
            panel2.Controls.Add(productIdTextBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(389, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 437);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // removeprod_btn
            // 
            removeprod_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeprod_btn.Location = new Point(50, 292);
            removeprod_btn.Name = "removeprod_btn";
            removeprod_btn.Size = new Size(175, 35);
            removeprod_btn.TabIndex = 16;
            removeprod_btn.Text = "Remove Product";
            removeprod_btn.UseVisualStyleBackColor = true;
            removeprod_btn.Click += removeprod_btn_Click;
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
            dataGridView1.Location = new Point(670, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 437);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(12, 13);
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
            linkLabel2.Location = new Point(670, 13);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(63, 19);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Refresh";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1362, 496);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
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
        private Button addprod_btn;
        private Label label1;
        private Panel panel2;
        private Button removeprod_btn;
        private Label label2;
        private TextBox productQuantity;
        private Label label6;
        private TextBox price;
        private Label label5;
        private TextBox description;
        private Label label4;
        private TextBox productName;
        private Label label3;
        private DataGridView dataGridView1;
        private Button update_btn;
        private TextBox productIdTextBox;
        private Label label8;
        private Label label7;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}