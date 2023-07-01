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
    /*
    public class Role: db
    {
        db a = new db();
        MySqlDataAdapter b = new MySqlDataAdapter();
        DataSet1 DataSet1 = new DataSet1();
        DataSet1.рольDataTable DataTable1 = new DataSet1.рольDataTable();
        List<string> list = new List<string>();
        public void OpenConnection()
        {
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `роль`", a.getConnection());
            b.SelectCommand = command1;
            b.Fill(DataTable1);

            for (int i = 0; i < DataTable1.Rows.Count; i++)
            {
                list.Add(DataTable1.Rows[i]["id_роль"].ToString());
            }
        }
    }
    */
}
