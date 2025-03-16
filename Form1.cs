using EntityFrameWork_LINQ_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using TaskStatus = EntityFrameWork_LINQ_Project.Models.TaskStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace EntityFrameWork_LINQ_Project
{
    public partial class Form1 : Form
    {

        TaskMangerDB DBCONTEXT = new TaskMangerDB();
        public int IdOfUser { get; set; }

        public Form1(int _id)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            IdOfUser = _id;


        }

        public Form1(string password)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            var id = DBCONTEXT.Users.Where(s => s.Password == password).Select(s => s.Id).FirstOrDefault();
            IdOfUser = id;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = IdOfUser.ToString();
            textBox2.Visible = false;
            // groupBox2.Visible = false;
            LODED();

        }

        public void LODED()
        {

            var statuses = new List<string> { "" }; // First item is empty
            statuses.AddRange(Enum.GetNames(typeof(TaskStatus))); // Add enum names
            statusecompobox.DataSource = statuses;
            statusecompobox.SelectedIndex = -1;
            button3.Enabled = false;
            button5.Enabled = false;
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
            dataGridView3.ClearSelection();
            dataGridView3.CurrentCell = null;


        }


        public void ReadData(int id)
        {
            var tasks = DBCONTEXT.TaskItems
            .Where(s => s.userId == IdOfUser)
            .Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Priority = s.Priority,
                Status = s.Status,
                Category = s.category.Name,
                UserName = s.user.Name
            }).ToList();

            var lowPriorityTasks = tasks.Where(s => s.Priority == "Low").ToList();
            var mediumPriorityTasks = tasks.Where(s => s.Priority == "Medium").ToList();
            var highPriorityTasks = tasks.Where(s => s.Priority == "High").ToList();


            dataGridView1.DataSource = lowPriorityTasks.Any()
                ? lowPriorityTasks
                : new List<dynamic> { new { Message = "No Low Priority tasks" } };

            dataGridView2.DataSource = mediumPriorityTasks.Any()
                ? mediumPriorityTasks
                : new List<dynamic> { new { Message = "No Medium Priority tasks" } };

            dataGridView3.DataSource = highPriorityTasks.Any()
                ? highPriorityTasks
                : new List<dynamic> { new { Message = "No High Priority tasks" } };


        }
        Update update = new Update(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0);

        string titile = string.Empty;

        private void updatetask_Click(object sender, EventArgs e)
        {
            update.Show();
            this.Hide();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            var deletedtask = DBCONTEXT.TaskItems.Where(s => s.Title == titile).FirstOrDefault();
            DBCONTEXT.TaskItems.Remove(deletedtask);
            DBCONTEXT.SaveChanges();
            MessageBox.Show("Task Deleted Successful.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ReadData(IdOfUser);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaskMangerDB DBCONTEXT = new TaskMangerDB();
            var input = textBox1.Text.Trim(); // Remove spaces
            string pattern = @"^\d+$";

            if (string.IsNullOrWhiteSpace(input)) // Check if input is empty
            {
                MessageBox.Show("Please enter any word or char to search .", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!Regex.IsMatch(input, pattern)) // If input is ! a number==> title
            {
                if (statusecompobox.SelectedIndex == -1)
                {


                    var x = DBCONTEXT.TaskItems
                                            .Where(s => s.Title.ToLower().StartsWith(input) || s.Description.ToLower().Contains(input) && s.userId == IdOfUser)
                                            .Select(s => new
                                            {
                                                Title = s.Title,
                                                Description = s.Description,
                                                Priority = s.Priority,
                                                Status = s.Status,
                                                Category = s.category.Name,
                                                UserName = s.user.Name,
                                                Dudate = s.DueDate
                                            }).OrderBy(s => s.Dudate).ToList();

                    var lowPriorityTasks = x.Where(s => s.Priority == "Low").ToList();
                    var mediumPriorityTasks = x.Where(s => s.Priority == "Medium").ToList();
                    var highPriorityTasks = x.Where(s => s.Priority == "High").ToList();

                    // Assign filtered results to DataGridViews individually
                    dataGridView1.DataSource = lowPriorityTasks.Any()
                        ? lowPriorityTasks
                        : new List<dynamic> { new { Message = "No Low Priority tasks" } };

                    dataGridView2.DataSource = mediumPriorityTasks.Any()
                        ? mediumPriorityTasks
                        : new List<dynamic> { new { Message = "No Medium Priority tasks" } };

                    dataGridView3.DataSource = highPriorityTasks.Any()
                        ? highPriorityTasks
                        : new List<dynamic> { new { Message = "No High Priority tasks" } };

                    // Clear search input
                    textBox1.Text = "";


                }
                else
                {
                    var filteritem = statusecompobox.SelectedItem?.ToString()?.Trim().ToLower(); // Convert to lowercase string for comparison

                    var tasks = DBCONTEXT.TaskItems
                        .Where(s => s.Status.ToString().ToLower() == filteritem &&
                                   (s.Title.ToLower().StartsWith(input) || s.Description.ToLower().Contains(input)) && s.userId == IdOfUser)
                        .Select(s => new
                        {
                            Title = s.Title,
                            Description = s.Description,
                            Priority = s.Priority,
                            Status = s.Status,
                            Category = s.category.Name,
                            UserName = s.user.Name
                        })
                        .ToList();

                    var lowPriorityTasks = tasks.Where(s => s.Priority == "Low").ToList();
                    var mediumPriorityTasks = tasks.Where(s => s.Priority == "Medium").ToList();
                    var highPriorityTasks = tasks.Where(s => s.Priority == "High").ToList();

                    // Assign filtered results to DataGridViews individually
                    dataGridView1.DataSource = lowPriorityTasks.Any()
                        ? lowPriorityTasks
                        : new List<dynamic> { new { Message = "No Low Priority tasks" } };

                    dataGridView2.DataSource = mediumPriorityTasks.Any()
                        ? mediumPriorityTasks
                        : new List<dynamic> { new { Message = "No Medium Priority tasks" } };

                    dataGridView3.DataSource = highPriorityTasks.Any()
                        ? highPriorityTasks
                        : new List<dynamic> { new { Message = "No High Priority tasks" } };

                    // Clear search input
                    textBox1.Text = "";
                }



            }
            else // If input is a number, search by ID
            {
                if (int.TryParse(input, out int taskId))
                {

                    MessageBox.Show("Please enter a valid task title, not just numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


            var tasks = DBCONTEXT.TaskItems
                    .Where(s => s.userId == IdOfUser)
                    .Select(s => new
                    {
                        Title = s.Title,
                        Description = s.Description,
                        Priority = s.Priority,
                        Status = s.Status,
                        Category = s.category.Name,
                        UserName = s.user.Name
                    })
                    .ToList();
            if (tasks.Any())
            {
                dataGridView1.DataSource = tasks;
                textBox1.Text = "";
            }// If tasks are found, show them
            else
            {
                dataGridView1.DataSource = new List<dynamic>
                            {
                               new { Message = "No tasks exist" }
                            };
                textBox1.Text = "";
            }

        }

        private void add_task_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Categoty add_Categoty = new Add_Categoty(IdOfUser);
            add_Categoty.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {


        }
        public void StatuseCompoBox()
        {
            var filteritem = statusecompobox.SelectedItem;
            var tasks = DBCONTEXT.TaskItems.Where(s => s.Status.ToString() == filteritem && s.Priority == "Low" && s.userId == IdOfUser).Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Priority = s.Priority,
                Status = s.Status,
                Category = s.category.Name,
                UserName = s.user.Name
            }).ToList();
            dataGridView1.DataSource = tasks;
            var tasks2 = DBCONTEXT.TaskItems.Where(s => s.Status.ToString() == filteritem && s.Priority == "Medium" && s.userId == IdOfUser).Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Priority = s.Priority,
                Status = s.Status,
                Category = s.category.Name,
                UserName = s.user.Name
            }).ToList();
            dataGridView2.DataSource = tasks2;
            var tasks3 = DBCONTEXT.TaskItems.Where(s => s.Status.ToString() == filteritem && s.Priority == "High" && s.userId == IdOfUser).Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Priority = s.Priority,
                Status = s.Status,
                Category = s.category.Name,
                UserName = s.user.Name
            }).ToList();
            dataGridView3.DataSource = tasks3;

        }
        private void statusecompobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusecompobox.SelectedIndex == -1)
            {
                var id = int.Parse(textBox2.Text);
                ReadData(id);

            }
            else
            {
                StatuseCompoBox();
            }
        }
        private bool isclick = false;
        private void Show_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

            // addTask.user.Enabled = !string.IsNullOrWhiteSpace(textBox2.Text);

        }

        private void describtion_TextChanged(object sender, EventArgs e)
        {



        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void High_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void sortbyduedate_Click(object sender, EventArgs e)
        {
            isclick = true;
            if (statusecompobox.SelectedIndex == -1)
            {
                ReadData(IdOfUser);
            }
            else if (statusecompobox.SelectedItem != null)//&& (low.Text!=null|| button5.Text!=null|| medium.Text!=null)
            {

                FilterWithStatusandorder();

            }
        }
        private void filgroub_Enter(object sender, EventArgs e)
        {

        }


        public void FilterWithStatusandorder()
        {
            var filteritem = statusecompobox.SelectedItem;
            var tasks = DBCONTEXT.TaskItems.Where(s => s.Status.ToString() == filteritem && s.userId == IdOfUser).Select(s => new
            {
                Title = s.Title,
                Description = s.Description,
                Priority = s.Priority,
                Status = s.Status,
                Category = s.category.Name,
                UserName = s.user.Name,
                Dudate = s.DueDate
            }).OrderBy(s => s.Dudate).ToList();

            var lowPriorityTasks = tasks.Where(s => s.Priority == "Low").ToList();
            var mediumPriorityTasks = tasks.Where(s => s.Priority == "Medium").ToList();
            var highPriorityTasks = tasks.Where(s => s.Priority == "High").ToList();


            dataGridView1.DataSource = lowPriorityTasks.Any()
                ? lowPriorityTasks
                : new List<dynamic> { new { Message = "No Low Priority tasks" } };

            dataGridView2.DataSource = mediumPriorityTasks.Any()
                ? mediumPriorityTasks
                : new List<dynamic> { new { Message = "No Medium Priority tasks" } };

            dataGridView3.DataSource = highPriorityTasks.Any()
                ? highPriorityTasks
                : new List<dynamic> { new { Message = "No High Priority tasks" } };
        }


        private void low_Click(object sender, EventArgs e)
        {





        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string title = string.Empty;
        private void HandleSelectionChanged(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count == 0) return;

            // Get selected row index
            int rowIndex = dgv.SelectedCells[0].RowIndex;

            // Ensure the rowIndex is valid
            if (rowIndex < 0 || rowIndex >= dgv.Rows.Count)
                return;

            // Extract data safely (check for null values)
            title = dgv.Rows[rowIndex].Cells["Title"]?.Value?.ToString() ?? "N/A";
            string category = dgv.Rows[rowIndex].Cells["Category"]?.Value?.ToString() ?? "N/A";
            string description = dgv.Rows[rowIndex].Cells["Description"]?.Value?.ToString() ?? "N/A";
            string status = dgv.Rows[rowIndex].Cells["Status"]?.Value?.ToString() ?? "N/A";
            string priority = dgv.Rows[rowIndex].Cells["Priority"]?.Value?.ToString() ?? "N/A";

            // Enable update button
            button3.Enabled = true;
            button5.Enabled = true;
            // Create Update form instance with the selected row data
            update = new Update(description, title, category, priority, status, IdOfUser);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleSelectionChanged(dataGridView2);
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleSelectionChanged(dataGridView3);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleSelectionChanged(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadData(IdOfUser);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            report report = new report(IdOfUser);
            report.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(IdOfUser);

            addTask.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (update != null)
            {

                update.Show(); // Show the Update Form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (update != null)
            {

                var deletedtask = DBCONTEXT.TaskItems.Where(s => s.Title == title).FirstOrDefault();
                DBCONTEXT.TaskItems.Remove(deletedtask);
                DBCONTEXT.SaveChanges();
                MessageBox.Show("Task Deleted Successful.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReadData(IdOfUser);
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();  
            lOGIN.Show();
            this.Hide();

        }
    }
}
