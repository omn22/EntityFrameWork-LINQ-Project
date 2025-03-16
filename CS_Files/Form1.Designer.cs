namespace EntityFrameWork_LINQ_Project
{
    partial class Form1 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            button2 = new Button();
            statusecompobox = new ComboBox();
            sortbyduedate = new Button();
            label1 = new Label();
            label9 = new Label();
            updatetask = new Button();
            delete = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button5 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(660, 688);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(873, 17);
            button1.Name = "button1";
            button1.Size = new Size(153, 52);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(466, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(13, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(24, 27);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MediumBlue;
            label10.Location = new Point(466, 10);
            label10.Name = "label10";
            label10.Size = new Size(365, 22);
            label10.TabIndex = 25;
            label10.Text = "Enter Titile ID or Description to search about : ";
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(217, 906);
            button2.Name = "button2";
            button2.Size = new Size(160, 58);
            button2.TabIndex = 27;
            button2.Text = "Add  Category";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // statusecompobox
            // 
            statusecompobox.BackColor = SystemColors.ActiveCaption;
            statusecompobox.FormattingEnabled = true;
            statusecompobox.Location = new Point(1152, 30);
            statusecompobox.Name = "statusecompobox";
            statusecompobox.Size = new Size(161, 31);
            statusecompobox.TabIndex = 31;
            statusecompobox.SelectedIndexChanged += statusecompobox_SelectedIndexChanged;
            // 
            // sortbyduedate
            // 
            sortbyduedate.BackColor = Color.CornflowerBlue;
            sortbyduedate.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            sortbyduedate.ForeColor = Color.Transparent;
            sortbyduedate.Location = new Point(1333, 14);
            sortbyduedate.Name = "sortbyduedate";
            sortbyduedate.Size = new Size(143, 51);
            sortbyduedate.TabIndex = 32;
            sortbyduedate.Text = "Sort";
            sortbyduedate.UseVisualStyleBackColor = false;
            sortbyduedate.Click += sortbyduedate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Dubai", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 57);
            label1.TabIndex = 34;
            label1.Text = "Task Manager";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(1152, 6);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 36;
            label9.Text = "Statues";
            // 
            // updatetask
            // 
            updatetask.BackColor = Color.CornflowerBlue;
            updatetask.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatetask.Location = new Point(1892, 1068);
            updatetask.Name = "updatetask";
            updatetask.Size = new Size(138, 54);
            updatetask.TabIndex = 37;
            updatetask.Text = "Update";
            updatetask.UseVisualStyleBackColor = false;
            updatetask.Click += updatetask_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 128, 128);
            delete.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(1730, 1068);
            delete.Name = "delete";
            delete.Size = new Size(138, 54);
            delete.TabIndex = 38;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.RosyBrown;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(678, 201);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(683, 688);
            dataGridView2.TabIndex = 39;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.IndianRed;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(1367, 201);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(545, 688);
            dataGridView3.TabIndex = 40;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(302, 17);
            button4.Name = "button4";
            button4.Size = new Size(147, 58);
            button4.TabIndex = 41;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1585, 12);
            button6.Name = "button6";
            button6.Size = new Size(158, 53);
            button6.TabIndex = 42;
            button6.Text = "Report";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // button7
            // 
            button7.ForeColor = Color.MediumBlue;
            button7.Location = new Point(30, 909);
            button7.Name = "button7";
            button7.Size = new Size(160, 55);
            button7.TabIndex = 43;
            button7.Text = "ADD TASK";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(330, 175);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 44;
            label2.Text = "LOW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(1636, 175);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 45;
            label3.Text = "HIGH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(1002, 175);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 46;
            label4.Text = "MID";
            // 
            // button3
            // 
            button3.ForeColor = Color.MediumBlue;
            button3.Location = new Point(1775, 911);
            button3.Name = "button3";
            button3.Size = new Size(137, 53);
            button3.TabIndex = 47;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.ForeColor = Color.MediumBlue;
            button5.Location = new Point(1623, 911);
            button5.Name = "button5";
            button5.Size = new Size(131, 53);
            button5.TabIndex = 48;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.CornflowerBlue;
            button8.ForeColor = Color.White;
            button8.Location = new Point(1790, 14);
            button8.Name = "button8";
            button8.Size = new Size(122, 52);
            button8.TabIndex = 49;
            button8.Text = "LOG OUT";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(delete);
            Controls.Add(updatetask);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(statusecompobox);
            Controls.Add(sortbyduedate);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
        private Button button2;
        private ComboBox statusecompobox;
        private Button sortbyduedate;
        private Label label1;
        private Label label9;
        private Button updatetask;
        private Button delete;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button5;
        private Button button8;
    }
}
