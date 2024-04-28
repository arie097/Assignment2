namespace Assignment2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            txtpassword = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(79, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 385);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 264);
            button1.Name = "button1";
            button1.Size = new Size(101, 38);
            button1.TabIndex = 13;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(43, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(250, 22);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No Account yet? Register here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(91, 210);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(155, 27);
            txtpassword.TabIndex = 11;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 188);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(91, 140);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(155, 27);
            txtusername.TabIndex = 9;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 118);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 8;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 35);
            label1.Name = "label1";
            label1.Size = new Size(97, 39);
            label1.TabIndex = 7;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(743, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtusername;
        private Label label2;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}