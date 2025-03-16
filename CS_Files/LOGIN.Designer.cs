namespace EntityFrameWork_LINQ_Project
{
    partial class LOGIN
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.Location = new Point(38, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(544, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CornflowerBlue;
            textBox2.Location = new Point(38, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(544, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(482, 346);
            button1.Name = "button1";
            button1.Size = new Size(100, 46);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(699, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 468);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(220, 47);
            label3.Name = "label3";
            label3.Size = new Size(168, 36);
            label3.TabIndex = 4;
            label3.Text = "LOGIN NOW";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(220, 414);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(257, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I do not have account SIGN UP ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 153);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 4;
            label1.Text = "Enter Your Email : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 258);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 23);
            label2.TabIndex = 5;
            label2.Text = "Enter Your Password:";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1840, 863);
            Controls.Add(groupBox1);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.InfoText;
            Name = "LOGIN";
            Text = "form";
            Load += LOGIN_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}