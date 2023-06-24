using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = courseproject_db;");
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
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
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
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
}
