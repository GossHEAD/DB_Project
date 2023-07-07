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
using System.Data.Entity.Infrastructure;


namespace DB_Project
{
    public class db
    {
        private SQLiteConnection connection = new SQLiteConnection("Data Source= ../../DataBase/practice.db");
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
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SQLiteConnection getConnection()
        {
            return connection;
        }

        public DataTable GetDataTable(string cmd)
        {
            DataTable dt;
            OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, getConnection());
            dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }

        public List<List<string>> GetTable(string cmd)
        {
            DataTable dataTable = GetDataTable(cmd);
            var lists = dataTable.AsEnumerable().Select(data => data.ItemArray.Select(value => value.ToString()).ToList()).ToList();
            return lists;
        }

        public string GetFirstValue(string uCmd)
        {
            OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(uCmd, this.getConnection());
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                var value = reader.GetValue(0).ToString();
                reader.Close();
                CloseConnection();
                return value;
            }
            catch (Exception e)
            {
                reader.Close();
                CloseConnection();
                return "-1";
            }
        }
        
        public int executeCmd(string cmd)
        {
            OpenConnection();
            SQLiteCommand command = new SQLiteCommand(cmd, getConnection());
            int res = command.ExecuteNonQuery();
            CloseConnection();
            return res;
        }

    }
    
}
