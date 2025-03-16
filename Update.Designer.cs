namespace EntityFrameWork_LINQ_Project
{
    partial class Update
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
            groupBox3 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            Edite = new Button();
            descraption = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            priority = new ComboBox();
            Titile = new TextBox();
            statues = new ComboBox();
            category = new ComboBox();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(Edite);
            groupBox3.Controls.Add(descraption);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(priority);
            groupBox3.Controls.Add(Titile);
            groupBox3.Controls.Add(statues);
            groupBox3.Controls.Add(category);
            groupBox3.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.MediumBlue;
            groupBox3.Location = new Point(708, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(568, 597);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(233, 24);
            label6.Name = "label6";
            label6.Size = new Size(108, 36);
            label6.TabIndex = 52;
            label6.Text = "Update";
            // 
            // button1
            // 
            button1.Location = new Point(57, 498);
            button1.Name = "button1";
            button1.Size = new Size(121, 54);
            button1.TabIndex = 51;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Edite
            // 
            Edite.BackColor = Color.CornflowerBlue;
            Edite.ForeColor = Color.Transparent;
            Edite.Location = new Point(411, 498);
            Edite.Name = "Edite";
            Edite.Size = new Size(126, 54);
            Edite.TabIndex = 50;
            Edite.Text = "Update";
            Edite.UseVisualStyleBackColor = false;
            Edite.Click += Edite_Click;
            // 
            // descraption
            // 
            descraption.BackColor = SystemColors.ActiveCaption;
            descraption.Location = new Point(52, 207);
            descraption.Name = "descraption";
            descraption.Size = new Size(470, 28);
            descraption.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 181);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 45;
            label1.Text = "Descraotion : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 46;
            label2.Text = "Titile : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 269);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 47;
            label3.Text = "Category : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 342);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 48;
            label4.Text = "Statues : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 424);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 49;
            label5.Text = "Priority : ";
            // 
            // priority
            // 
            priority.BackColor = SystemColors.ActiveCaption;
            priority.FormattingEnabled = true;
            priority.Location = new Point(52, 450);
            priority.Name = "priority";
            priority.Size = new Size(470, 31);
            priority.TabIndex = 42;
            // 
            // Titile
            // 
            Titile.BackColor = SystemColors.ActiveCaption;
            Titile.Location = new Point(52, 134);
            Titile.Name = "Titile";
            Titile.Size = new Size(470, 28);
            Titile.TabIndex = 39;
            // 
            // statues
            // 
            statues.BackColor = SystemColors.ActiveCaption;
            statues.FormattingEnabled = true;
            statues.Location = new Point(52, 368);
            statues.Name = "statues";
            statues.Size = new Size(470, 31);
            statues.TabIndex = 40;
            // 
            // category
            // 
            category.BackColor = SystemColors.ActiveCaption;
            category.FormattingEnabled = true;
            category.Location = new Point(52, 295);
            category.Name = "category";
            category.Size = new Size(470, 31);
            category.TabIndex = 41;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1842, 1055);
            Controls.Add(groupBox3);
            Name = "Update";
            Text = "Update";
            Load += Update_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox descraption;
        private ComboBox priority;
        private TextBox Titile;
        private ComboBox statues;
        private ComboBox category;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Edite;
        private Button button1;
        private Label label6;
    }
}