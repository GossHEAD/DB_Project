using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String loginUser = passfield_login.Text;
            String passUser = passfield_password.Text;
            db db = new db();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователь` where `Логин` = @userLog AND `Пароль` = @userPass", db.getConnection());
            command.Parameters.Add("@userLog", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MySqlCommand command1 = new MySqlCommand("SELECT ID_Пользователь FROM `пользователь` where `Логин` = @userLog AND `Пароль` = @userPass", db.getConnection());
                command1.Parameters.Add("@userLog", MySqlDbType.VarChar).Value = loginUser;
                command1.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = command1;
                adapter.Fill(table);
                role_id = (int)table.Rows[0]["ID_Пользователь"];
                Form1 form1 = new Form1(role_id);
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
    
        
    }
}
