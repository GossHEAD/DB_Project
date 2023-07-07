using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox.Text;
            this.Hide();
            bool checkUser = Authorization(loginUser);
            MainForm newForm = new MainForm(checkUser);
            newForm.Show();
        }

        private bool Authorization(string login)
        {
            if(login.ToLower() == "admin")
            {
                return true;
            }
            return false;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.LineFeed)
            {
                e.Handled = true;
            }
        }
    }
}
