namespace EntityFrameWork_LINQ_Project
{
    partial class Add_Categoty
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(635, 340);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 410);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(43, 284);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 7;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(207, 50);
            label3.Name = "label3";
            label3.Size = new Size(189, 36);
            label3.TabIndex = 4;
            label3.Text = "Add Category";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.CornflowerBlue;
            linkLabel1.Location = new Point(107, 418);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(257, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I do not have account SIGN UP ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 153);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 23);
            label1.TabIndex = 4;
            label1.Text = "Enter Your Category Name : ";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(435, 284);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.CornflowerBlue;
            textBox2.Location = new Point(43, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 27);
            textBox2.TabIndex = 1;
            // 
            // Add_Categoty
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1838, 776);
            Controls.Add(groupBox1);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Add_Categoty";
            Text = "Add_Categoty";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}