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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
        TaskMangerDB tasks = new TaskMangerDB();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIGN_UP sIGN_UP = new SIGN_UP();
            sIGN_UP.Show();
            this.Hide();

        }
        private void button1_click(object sender, EventArgs e)
        {
            User user = new User();
            var pass = tasks.Users.Where(s => s.Password == textBox1.Text).Select(s => s.Id).FirstOrDefault().ToString();
            int.TryParse(pass, out int id);
            var email = textBox2.Text;
            var validuser = tasks.Users.Where(s => s.Id == id && s.Email == email).FirstOrDefault();
            if (validuser != null)
            {

                Form1 form = new Form1(id);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid Password or Email", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
