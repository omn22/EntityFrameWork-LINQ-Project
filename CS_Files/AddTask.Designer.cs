namespace EntityFrameWork_LINQ_Project
{
    partial class AddTask
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
            button1 = new Button();
            label1 = new Label();
            user = new TextBox();
            add_task = new Button();
            priority = new ComboBox();
            describtion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Statuss = new ComboBox();
            titeel = new TextBox();
            label8 = new Label();
            category = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(user);
            groupBox1.Controls.Add(add_task);
            groupBox1.Controls.Add(priority);
            groupBox1.Controls.Add(describtion);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(Statuss);
            groupBox1.Controls.Add(titeel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(category);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(688, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 806);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(89, 694);
            button1.Name = "button1";
            button1.Size = new Size(133, 53);
            button1.TabIndex = 30;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(217, 41);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 29;
            label1.Text = "Add Task";
            // 
            // user
            // 
            user.BackColor = SystemColors.InactiveCaption;
            user.ForeColor = SystemColors.WindowFrame;
            user.Location = new Point(88, 148);
            user.Name = "user";
            user.Size = new Size(418, 32);
            user.TabIndex = 26;
            user.TextChanged += textBox3_TextChanged;
            // 
            // add_task
            // 
            add_task.BackColor = Color.CornflowerBlue;
            add_task.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_task.ForeColor = Color.Transparent;
            add_task.Location = new Point(378, 692);
            add_task.Name = "add_task";
            add_task.Size = new Size(139, 56);
            add_task.TabIndex = 27;
            add_task.Text = "Add Task";
            add_task.UseVisualStyleBackColor = false;
            add_task.Click += add_task_Click;
            // 
            // priority
            // 
            priority.BackColor = SystemColors.InactiveCaption;
            priority.FormattingEnabled = true;
            priority.Location = new Point(89, 369);
            priority.Name = "priority";
            priority.Size = new Size(418, 32);
            priority.TabIndex = 28;
            // 
            // describtion
            // 
            describtion.BackColor = SystemColors.InactiveCaption;
            describtion.Location = new Point(89, 542);
            describtion.Name = "describtion";
            describtion.Size = new Size(418, 32);
            describtion.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(89, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(418, 32);
            dateTimePicker1.TabIndex = 12;
            // 
            // Statuss
            // 
            Statuss.BackColor = SystemColors.InactiveCaption;
            Statuss.FormattingEnabled = true;
            Statuss.Location = new Point(89, 455);
            Statuss.Name = "Statuss";
            Statuss.Size = new Size(418, 32);
            Statuss.TabIndex = 8;
            // 
            // titeel
            // 
            titeel.BackColor = SystemColors.InactiveCaption;
            titeel.Location = new Point(88, 210);
            titeel.Name = "titeel";
            titeel.Size = new Size(418, 32);
            titeel.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 594);
            label8.Name = "label8";
            label8.Size = new Size(103, 24);
            label8.TabIndex = 21;
            label8.Text = "Category : ";
            // 
            // category
            // 
            category.BackColor = SystemColors.InactiveCaption;
            category.FormattingEnabled = true;
            category.Location = new Point(89, 632);
            category.Name = "category";
            category.Size = new Size(418, 32);
            category.TabIndex = 19;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 183);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
            label3.TabIndex = 14;
            label3.Text = "Title :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 342);
            label6.Name = "label6";
            label6.Size = new Size(85, 24);
            label6.TabIndex = 17;
            label6.Text = "Priority :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 419);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 13;
            label2.Text = "Status :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 121);
            label7.Name = "label7";
            label7.Size = new Size(63, 24);
            label7.TabIndex = 20;
            label7.Text = "User  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 254);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 16;
            label5.Text = "Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 501);
            label4.Name = "label4";
            label4.Size = new Size(119, 24);
            label4.TabIndex = 15;
            label4.Text = "Description :";
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1843, 1055);
            Controls.Add(groupBox1);
            Name = "AddTask";
            Text = "AddTask";
            Load += AddTask_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public TextBox user;
        private Button add_task;
        private ComboBox priority;
        private TextBox describtion;
        private DateTimePicker dateTimePicker1;
        private ComboBox Statuss;
        private TextBox titeel;
        private Label label8;
        public ComboBox category;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label1;
    }
}