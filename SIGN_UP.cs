using EntityFrameWork_LINQ_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork_LINQ_Project
{
    public partial class SIGN_UP : Form
    {
        public SIGN_UP()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            TaskMangerDB taskMangerDB = new TaskMangerDB();
            string Namepattern = @"^[A-Za-z]+( [A-Za-z]+){0,2}$";
            string Emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var nameValue = textBox3.Text;
            var emailValue = textBox2.Text;
            var passvalue = textBox1.Text;
            var passConfiValu = textBox4.Text;
            var uservalidpass = taskMangerDB.Users.Where(s => s.Password == passvalue)
                                                  .Select(x => x.Password)
                                                  .FirstOrDefault();
            if (!Regex.IsMatch(nameValue, Namepattern))
            {
                MessageBox.Show("InValid Name.. No numbers or special characters", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!Regex.IsMatch(emailValue, Emailpattern))
            {
                MessageBox.Show("InValid Email..Please Enter email in this format user123@gmail.com", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (passConfiValu != passvalue)
            {
                MessageBox.Show("Password and Confirm Password not Matchs", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (passvalue == uservalidpass)
            {
                MessageBox.Show("Password Alredy Exist ,Peek another Password", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                user.Name = nameValue;
                user.Email = emailValue;
                user.Password = passvalue;
                taskMangerDB.Users.Add(user);
                taskMangerDB.SaveChanges();
                LOGIN LOG = new LOGIN();
                LOG.Show();
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void SIGN_UP_Load(object sender, EventArgs e)
        {

        }
    }
}
