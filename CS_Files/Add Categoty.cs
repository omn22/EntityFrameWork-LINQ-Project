using EntityFrameWork_LINQ_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork_LINQ_Project
{
   
    public partial class Add_Categoty : Form
    {
        TaskMangerDB DBCONTEXT = new TaskMangerDB();
        public int IdOfUser;
        public Add_Categoty(int idOfUser)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            IdOfUser = idOfUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category catego = new Category();
            catego.Name = textBox2.Text;
            if (DBCONTEXT.Categories.Where(s => s.Name == textBox2.Text.ToLower()).Select(s => s.Name.ToLower()).FirstOrDefault() != null)
            {
                MessageBox.Show("Category Already Exist", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                DBCONTEXT.Categories.Add(catego);
                DBCONTEXT.SaveChanges();
                AddTask addTaskForm = (AddTask)Application.OpenForms["AddTask"];
                if (addTaskForm != null)
                {
                    addTaskForm.category.DataSource = DBCONTEXT.Categories
                        .Select(s => s.Name)
                        .Distinct()
                        .ToList();
                }
                Form1 form1 = new Form1(IdOfUser);
                form1.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(IdOfUser);
            form1.Show();
        }
    }
}
