using EntityFrameWork_LINQ_Project.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameWork_LINQ_Project
{
    public partial class report : Form
    {
        public int Id { get; set; }
        private RichTextBox progressLabel2;
        private ReportProirty lowProgressCircle, midProgressCircle, highProgressCircle;
        private Label progressLabel, totalTasksLabel, notyfiy;
        private Panel containerPanel; // Holds all UI elements

        public report(int id)
        {
            Id = id;
            InitializeComponent();
            InitializeCustomControls();
            LoadTaskCounts();
            this.Resize += Report_Resize;
        }

        #region Custom UI Components

        private void InitializeCustomControls()
        {
            // Container Panel for easier alignment
            containerPanel = new Panel
            {
                Size = new Size(400, 300), // Adjust size dynamically
                Location = new Point((this.ClientSize.Width - 400) / 2, 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            this.Controls.Add(containerPanel);

            // Total Tasks Label
            totalTasksLabel = new Label
            {
                Text = "Total Tasks: 0",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true
            };
            containerPanel.Controls.Add(totalTasksLabel);

            // Initialize Progress Circles for Low, Medium, and High Priority
            lowProgressCircle = CreateProgressCircle(Color.Green);
            midProgressCircle = CreateProgressCircle(Color.Orange);
            highProgressCircle = CreateProgressCircle(Color.Red);

            // Percentage Label (Centered Below Circles)
            progressLabel = new Label
            {
                Text = "0% | 0% | 0%",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                AutoSize = true
            };
            containerPanel.Controls.Add(progressLabel);
            progressLabel2 = new RichTextBox
            {
                ReadOnly = true,  // Prevent editing
                BorderStyle = BorderStyle.None,
                BackColor = this.BackColor, // Match background
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(15, 190),
                Width = 300,
                Height = 100
            };
            containerPanel.Controls.Add(progressLabel2);
            notyfiy = new Label
            {
                Text = " ",
                Font = new Font("Arial", 7, FontStyle.Bold),
                ForeColor = Color.Red,
                BackColor = Color.Transparent,
                AutoSize = true
            };
            containerPanel.Controls.Add(notyfiy);

            ArrangeControls(); // Arrange UI dynamically
        }

        private ReportProirty CreateProgressCircle(Color progressColor)
        {
            var circle = new ReportProirty
            {
                Size = new Size(100, 100),
                ProgressColor = progressColor,
                BackgroundColor = Color.LightGray,
                MaxValue = 100
            };
            containerPanel.Controls.Add(circle);
            return circle;
        }

        private void ArrangeControls()
        {
            int centerX = (containerPanel.Width - 100) / 2; // Center horizontally
            totalTasksLabel.Location = new Point((containerPanel.Width - totalTasksLabel.Width) / 2, 0);
            lowProgressCircle.Location = new Point(centerX - 140, 40);
            midProgressCircle.Location = new Point(centerX, 40);
            highProgressCircle.Location = new Point(centerX + 140, 40);
            progressLabel.Location = new Point(15, 160);
            progressLabel2.Location = new Point(0, 200);
            notyfiy.Location = new Point(10, 250);

        }

        #endregion

        #region Data Handling

        private void LoadTaskCounts()
        {
            using (TaskMangerDB DBCONTEXT = new TaskMangerDB())
            {
                int low = DBCONTEXT.TaskItems.Count(s => s.userId == Id && s.Priority == "Low");
                int mid = DBCONTEXT.TaskItems.Count(s => s.userId == Id && s.Priority == "Medium");
                int high = DBCONTEXT.TaskItems.Count(s => s.userId == Id && s.Priority == "High");


                int pending = DBCONTEXT.TaskItems.Where(s => s.userId == Id).Count(s => s.Status.ToString() == "Pending");
                int inprogress = DBCONTEXT.TaskItems.Where(s => s.userId == Id).Count(s => s.Status.ToString() == "In_Progress");
                int completed = DBCONTEXT.TaskItems.Where(s => s.userId == Id).Count(s => s.Status.ToString() == "Completed");

                int totalTasks = low + mid + high;

                if (totalTasks == 0)
                {
                    progressLabel.Text = "No Tasks";
                    return;
                }

                // Calculate percentages
                double lowPercent = (low / (double)totalTasks) * 100;
                double midPercent = (mid / (double)totalTasks) * 100;
                double highPercent = (high / (double)totalTasks) * 100;

                // Update Progress Circles
                lowProgressCircle.Value = (int)lowPercent;
                midProgressCircle.Value = (int)midPercent;
                highProgressCircle.Value = (int)highPercent;

                // Update Labels
                totalTasksLabel.Text = $"Total Tasks: {totalTasks}";
                progressLabel.Text = $"Low: {lowPercent:F1}%  |  Mid: {midPercent:F1}%  |  High: {highPercent:F1}%";
                progressLabel2.Text = "";  // Clear previous text
                progressLabel2.SelectionColor = Color.Red;
                progressLabel2.AppendText($"1- Pending: {pending} Task{Environment.NewLine}");


                progressLabel2.SelectionColor = Color.Blue;
                progressLabel2.AppendText($"2- In Progress: {inprogress} Task {Environment.NewLine}");


                progressLabel2.SelectionColor = Color.Green;
                progressLabel2.AppendText($"3- Completed: {completed} Task");

                var UN = DBCONTEXT.Users.Where(s => s.Id == Id).Select(s => s.Name).FirstOrDefault();
                if (completed < pending)
                {
                    progressLabel2.SelectionColor = Color.Red;

                    label1.Text = $"---YOU Need To keep Going {UN.ToUpper()} Your completed Tasks  less Than Pending---";
                }
                else
                    label1.Text = $"---YOU going Well {UN.ToUpper()} Keep Going---";

            }
        }


        private void report_Load(object sender, EventArgs e)
        {
            LoadTaskCounts(); // Ensure data loads when the form opens
        }

        #endregion

        #region Event Handlers

        private void Report_Resize(object sender, EventArgs e)
        {
            containerPanel.Location = new Point((this.ClientSize.Width - containerPanel.Width) / 2, 20);
            ArrangeControls(); // Reposition UI elements dynamically
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
