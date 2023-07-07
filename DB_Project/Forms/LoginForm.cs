using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DB_Project
{
    public partial class LoginForm : Form
    {
        public int role_id;
        public LoginForm()
        {
            InitializeComponent();
            this.passfield_password.Size = new Size(this.passfield_password.Width, 64);
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            string loginUser = passfield_login.Text;
            string passUser = passfield_password.Text;
            
            if (loginUser != null && passUser != null)
            {
                this.Hide();
                bool a = Autorization(loginUser, passUser);
                //MainForm form1 = new MainForm(role_id);
                MainFrom form1 = new MainFrom(a);
                form1.Show();
            }          
                
            else 
                MessageBox.Show("Такого пользователя не существует"); 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.X - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public bool Autorization(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else return false;
        }
    }
}
