using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Project.Data;
using System.Collections;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data.SQLite;
using System.Drawing.Text;
using System.IO;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        db db = new db();
        DataTable table = new DataTable();
        public int role_ID;
        
       //Конструкторы
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        }
        
        public Form1(bool a)
        {
            InitializeComponent();
            if (a == false)
            {
                adminPanel.Visible = false; 
            }
        }


        //Кнопки выбора таблиц
        private void buttonExtractor_Click(object sender, EventArgs e)
        {
            
            string cmd = @"select * from Extractor";
            string cmd1 = "SELECT Extractor.ID_Extractor, Extractor.Name, Manufacturer.Name as Manufacturer, Extractor_Subtype.Name as Type, \n" +
                "Extractor.Price, Extractor.Information\n" +
                "FROM Extractor\n" +
                "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer\n" +
                "JOIN Extractor_Subtype ON Extractor.ID_Subtype = Extractor_Subtype.ID_Subtype";
            try
            {
                using (var connection = new SQLiteConnection (db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd1, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from Extractor_type";
            try
            {
                using (var connection = new SQLiteConnection(db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void buttonTrait_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from Extractor_Prop";
            try
            {
                using (var connection = new SQLiteConnection(db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void buttonChar_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from Extractor_char";
            try
            {
                using (var connection = new SQLiteConnection(db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from Manufacturer";
            try
            {
                using (var connection = new SQLiteConnection(db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void buttonSubType_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from Extractor_Subtype";
            try
            {
                using (var connection = new SQLiteConnection(db.getConnection()))
                {
                    connection.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }



        //Фукнции формы
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //db.CloseConnection();
            Application.Exit();
        }        

        //Функция, которая собирает свойства передаваемого id экстрактора и записывает в textbox
        public void GetExtractorProp(int idExtr, RichTextBox textBox) 
        {
            //List<string> extractorProp = new List<string>();
            using (var connection = new SQLiteConnection(db.getConnection()))
            {
                connection.Open();
                /*
                string query = "SELECT p.Name, p.Value\n" +
                    "FROM Extractor_Properties p\n" +
                    "JOIN Extractor e ON p.ID_Extractor = e.ID_Extractor\n" +
                    "WHERE e.ID_Extractor = @idExtr";
                */
                string query = "SELECT p.Name, COALESCE(p.Value_prop, c.Value_char) AS PropertyValue\n" +
                    "FROM Extractor_Prop p\n" +
                    "LEFT JOIN Extractor_char c ON p.ID_Properties = c.ID_Properties \n" +
                    "WHERE c.ID_Extractor = @idExtr";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idExtr", idExtr);
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        
                        while (rdr.Read())
                        {
                            string propertyName = rdr["Name"].ToString();
                            string propertyPurpose = rdr["PropertyValue"].ToString();
                            sb.AppendLine($"{propertyName} - {propertyPurpose}");
                        }
                        textBoxProp.Text = sb.ToString();
                    }
                }
                
                string query1 = "SELECT Information\n" +
                    "FROM Extractor\n" +
                    "WHERE ID_Extractor = @idExtr";
                using (SQLiteCommand cmd = new SQLiteCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@idExtr", idExtr);
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        while (rdr.Read())
                        {
                            var information = rdr.GetString(0);
                            sb.AppendLine($"{information}");
                        }
                        textBoxInfo.Text = sb.ToString();
                    }
                }
                

            }
            string file ="";
            if (idExtr == 1)
            {
                file = "C:/Users/bagda/source/repos/DB_Project/DB_Project/Extractors_png/5_1.jpg";
                ShowImage(file);
            }
            else
            {
                ShowImage(file);
            }
            
        }
        //Вставка картинки в messabebox
        public void ShowImage(string fileToDisplay)
        {
            if(File.Exists(fileToDisplay))
            {
                try
                {
                    Image image = Image.FromFile(fileToDisplay);
                    pictureBoxExtractor.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxExtractor.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }
            else
            {
                pictureBoxExtractor.Image = null;
                MessageBox.Show("Файл изображения не найден.");
            }
        }
        //Получение id выбранного в таблице экстрактора
        public int GetSelectedExtrId(DataGridView dgv)
        {
            int selectedRow = dgv.CurrentCell.RowIndex;
            int extrId = Convert.ToInt32(dgv.Rows[selectedRow].Cells["ID_Extractor"].Value);
            return extrId;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            using (FilterWindow sw = new FilterWindow())
            {
                if (sw.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        //Вывод данных о экстракторе на панельки
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int g = GetSelectedExtrId(dataGridView1);
            GetExtractorProp(g, textBoxProp);
        }

        
        //Кнопки админа
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(SpecialWindow sw = new SpecialWindow())
            {
                if(sw.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();  
        }
    }
}
