using EntityFrameWork_LINQ_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TaskStatus = EntityFrameWork_LINQ_Project.Models.TaskStatus;

namespace EntityFrameWork_LINQ_Project
{
    public partial class AddTask : Form
    {
        TaskMangerDB DBCONTEXT = new TaskMangerDB();

        public int IdOfUser { get; set; }
        public AddTask(int id)
        {
            InitializeComponent();
            LODE();
            this.WindowState = FormWindowState.Maximized;
            this.IdOfUser = id;
            user.Text = DBCONTEXT.Users.Where(s => s.Id == IdOfUser).Select(s => s.Name).FirstOrDefault();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(IdOfUser);
            form1.Show();
        }
        private void add_task_Click(object sender, EventArgs e)
        {
            try
            {

                TaskItem task = new TaskItem();
                task.Title = titeel.Text;
                task.Description = describtion.Text;
                task.Priority = priority.SelectedItem.ToString();
                task.Status = (TaskStatus)Statuss.SelectedItem;
                task.DueDate = dateTimePicker1.Value;
                var cattext = category.SelectedItem;
                var categ = DBCONTEXT.Categories.Where(s => s.Name == cattext ).Select(s => s.Id).FirstOrDefault();
                task.categoryId = categ;
                task.userId = IdOfUser;
                var titel = DBCONTEXT.TaskItems.Where(s => s.Title == titeel.Text ).Select(s => s.Title).FirstOrDefault();
                
                if (titeel.Text == string.Empty)
                    MessageBox.Show("Please enter task title.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (titeel.Text == titel )
                    MessageBox.Show("Please anthor Title ,alrady.exist in same name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    DBCONTEXT.TaskItems.Add(task);
                    DBCONTEXT.SaveChanges();
                    Form1 form1 = new Form1(IdOfUser);
                    form1.Show();
                    RESAT();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid task .", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void RESAT()
        {
            describtion.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            titeel.Text = "";
            category.SelectedItem = "programing";
            Statuss.SelectedItem = "Pending";
            priority.SelectedItem = "Low";

        }
        public void LODE()
        {
            List<string> prioritys = new List<string>() { "Low", "Medium", "High" };
            priority.DataSource = prioritys;
            Statuss.DataSource = Enum.GetValues(typeof(TaskStatus)).Cast<TaskStatus>().ToList();

            List<string> cate = new List<string>();
            cate = DBCONTEXT.Categories.Select(c => c.Name).Distinct().ToList();
            category.DataSource = cate;
            
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }
    }
}
