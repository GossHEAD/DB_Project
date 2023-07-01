//using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class SpecialWindow : Form
    {
        public SpecialWindow()
        {
            InitializeComponent();
            FillBoxes();
        }

        private void FillBoxes()
        {
            string connectionString = "Data Source=practise_bd_re.db";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // Получаем все записи из таблицы Extr_Prop
                string query = "SELECT Name FROM Extractor_Prop";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string propertyName = reader["Name"].ToString();

                            // Добавляем имя свойства в ComboBox

                            comboBoxPropEx.Items.Add(propertyName);
                        }
                    }
                }
                string query1 = "SELECT Name FROM Extractor_type";
                using (SQLiteCommand command = new SQLiteCommand(query1, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string propertyName = reader["Name"].ToString();

                            // Добавляем имя свойства в ComboBox
                            
                            comboBoxTypeAdd.Items.Add(propertyName);
                        }
                    }
                }
                string query2 = "SELECT Name FROM Extractor_Subtype";
                using (SQLiteCommand command = new SQLiteCommand(query2, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string propertyName = reader["Name"].ToString();

                            // Добавляем имя свойства в ComboBox

                            comboBoxSybTypeAdd.Items.Add(propertyName);
                        }
                    }
                }
            }
        }
        
    

    }
    
}
