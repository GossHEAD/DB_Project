//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Project
{
    public class db
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=practise_bd_re.db");
        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void CloseConnection()
        {
            //if (connection.State == ConnectionState.Open)
            //{
            //    connection.Close();
            //}
        }
        public SQLiteConnection getConnection()
        {
            return connection;
        }
    }
    
}
