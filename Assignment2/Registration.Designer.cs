namespace Assignment2
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            linkLabel1 = new LinkLabel();
            register_btn = new Button();
            txtpassword = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 433);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 35);
            label1.Name = "label1";
            label1.Size = new Size(180, 39);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 116);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(134, 138);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(155, 27);
            txtusername.TabIndex = 2;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(102, 384);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(213, 22);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Have an Account? Sign in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // register_btn
            // 
            register_btn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.Location = new Point(160, 322);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(101, 38);
            register_btn.TabIndex = 4;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(134, 208);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(155, 27);
            txtpassword.TabIndex = 6;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 186);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(134, 272);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 250);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 477);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Registration";
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtpassword;
        private Label label3;
        private Button register_btn;
        private LinkLabel linkLabel1;
        private TextBox txtusername;
        private Label label2;
    }
}