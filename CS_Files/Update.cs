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
    public partial class Update : Form
    {
        public int IdOfUser { get; set; }


        public Update()
        {
            InitializeComponent();
           

        }
        TaskMangerDB DBCONTEXT = new TaskMangerDB();
        public void LODED()
        {
            Titile.Enabled = false;
            List<string> prioritys = new List<string>() { "Low", "Medium", "High" };
            priority.DataSource = prioritys;
            statues.DataSource = Enum.GetValues(typeof(TaskStatus)).Cast<TaskStatus>().ToList();
            var statuses = new List<string> { "" }; // First item is empty
            statuses.AddRange(Enum.GetNames(typeof(TaskStatus))); // Add enum names
            statues.DataSource = statuses;
            statues.SelectedIndex = -1;
            List<string> cate = new List<string>();
            cate = DBCONTEXT.Categories.Select(c => c.Name).Distinct().ToList();
            category.DataSource = cate;
        }
        public Update(string desc, string titile, string cate, string prior, string statuse,int id)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            LODED();
            Titile.Text = titile;
            descraption.Text = cate;
            priority.SelectedItem = prior;
            statues.SelectedItem = statuse;
            category.SelectedItem = category;
            IdOfUser = id;
        }

        private void Edite_Click(object sender, EventArgs e)
        {
            try
            {
                var task = DBCONTEXT.TaskItems.Where(s => s.Title == Titile.Text).FirstOrDefault();
                int taskuserid = (int)DBCONTEXT.TaskItems.Where(s => s.Title == Titile.Text).Select(s => s.userId).FirstOrDefault();
                task.Title = Titile.Text;
                task.Description = descraption.Text;
                task.Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), statues.SelectedItem.ToString()); ;
                task.Priority = priority.SelectedItem.ToString();
                var categ = DBCONTEXT.Categories.Where(s => s.Name == category.SelectedItem).Select(s => s.Id).FirstOrDefault();
                task.categoryId = categ;
                DBCONTEXT.SaveChanges();
                Form1 form1 = new Form1(taskuserid);
                form1.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Please enter Valid data.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var name=DBCONTEXT.Users.Where(s=>s.Name == ).Select(s=>s.Id).FirstOrDefault();
            //var id = DBCONTEXT.TaskItems.Where(s=>s.userId == ).Select(s=>s.userId).FirstOrDefault();
            Form1 form1 = new Form1(IdOfUser);
            form1.Show();
            this.Hide();
        }
    }
}
