using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data.SQLite;
using System.Drawing.Text;
using System.IO;
using System.Data.Entity;
using MySqlX.XDevAPI.Common;
using DB_Project.Forms;
using DB_Project.Forms.AdminPanel;

namespace DB_Project
{
    public partial class MainForm : Form
    {
        db dataBase = new db();

        //DataTable table = new DataTable();
        //public int role_ID;

        //Конструкторы
        public MainForm()
        {
            InitializeComponent();
            dataExtractor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin == false)
            {
                adminPanel.Visible = false; 
            }
        }


        //Кнопки выбора таблиц
        private void buttonExtractor_Click(object sender, EventArgs e)
        {

            string cmd =
                "SELECT Extractor.ID_Extractor as `ID_Экстрактора`, Extractor.Name as 'Модель', Manufacturer.Name as `Производитель`, ExtractorSubtype.Name as `Подтип`, " +
                "Extractor.Price as `Цена`, Extractor.Info as `Информация` " +
                "FROM Extractor " +
                "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                "JOIN ExtractorSubtype ON Extractor.ID_Subtype = ExtractorSubtype.ID_Subtype ";

            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            adminButton(true);
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT ExtractorSubtype.ID_Subtype as `ID_Подтипа`, " +
                "ExtractorGroup.Name as `Группа`, " +
                "ExtractorType.Name as `Тип`, " +
                "ExtractorSubtype.Name as `Подтип` " +
                "FROM ExtractorSubtype " +
                "JOIN ExtractorGroup ON ExtractorSubtype.ID_Group = ExtractorGroup.ID_Group " +
                "JOIN ExtractorType ON ExtractorSubtype.ID_Type = ExtractorType.ID_Type;";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            adminButton(false);

        }

        private void buttonChar_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT Properties.ID_Extractor as `ID_Экстрактора`, " +
                "OperatingMode.Name as `Режим работы`, " +
                "CaseType.Name as `Тип корпуса`, " +
                "HousingLocation.Name as `Расположение корпуса`, " +
                "TypeOfMixing.Name as `Тип перемешивания`, " +
                "Properties.BodyLength as `Длина корпуса, мм`, " +
                "Properties.CaseWidth as `Ширина корпуса, мм`, " +
                "Properties.Efficiency as `Производительность, л/ч` " +
                "FROM Properties " +
                "JOIN OperatingMode ON Properties.ID_OperatingMode = OperatingMode.ID_OperatingMode " +
                "JOIN CaseType ON Properties.ID_CaseType = CaseType.ID_CaseType " +
                "JOIN HousingLocation ON Properties.ID_HousingLocation = HousingLocation.ID_HousingLocation " +
                "JOIN TypeOfMixing ON Properties.ID_TypeOfMixing = TypeOfMixing.ID_TypeOfMixing";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            adminButton(false);

        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {
            string cmd = "select ID_Manufacturer as `ID_Компании`, " +
                         "Name as `Название` from Manufacturer";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            adminButton(false);
        }



        //Фукнции формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd =
                 "SELECT Extractor.ID_Extractor as `ID_Экстрактора`, Extractor.Name as 'Модель', Manufacturer.Name as `Производитель`, ExtractorSubtype.Name as `Подтип`, " +
                 "Extractor.Price as `Цена`, Extractor.Info as `Информация` " +
                 "FROM Extractor " +
                 "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                 "JOIN ExtractorSubtype ON Extractor.ID_Subtype = ExtractorSubtype.ID_Subtype ";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            for(int i = 0; i < forms.Count; i++)
            {
                if (forms[i].Visible)
                    forms[i].Close();
                else
                    forms[i].Show();

            }       
        }

        //Функция, которая собирает свойства передаваемого id экстрактора и записывает в textbox
        public void GetExtractorProp(int idExtr, RichTextBox textBox)
        {
            db dataBase = new db();
            List<string> strings = new List<string>() 
            { "Режим работы - ",
              "Тип корпуса - ",
              "Расположение корпуса - ",
              "Тип перемешивания - ",
              "Длина корпуса, мм - ",
              "Ширина корпуса, мм - ",
              "Производительность, л/ч - "};
            string cmd = "SELECT " +
                "OperatingMode.Name, " +
                "CaseType.Name, " +
                "HousingLocation.Name, " +
                "TypeOfMixing.Name, " +
                "Properties.BodyLength, " +
                "Properties.CaseWidth, " +
                "Properties.Efficiency " +
                "FROM Properties " +
                "JOIN OperatingMode ON Properties.ID_OperatingMode = OperatingMode.ID_OperatingMode " +
                "JOIN CaseType ON Properties.ID_CaseType = CaseType.ID_CaseType " +
                "JOIN HousingLocation ON Properties.ID_HousingLocation = HousingLocation.ID_HousingLocation " +
                "JOIN TypeOfMixing ON Properties.ID_TypeOfMixing = TypeOfMixing.ID_TypeOfMixing " +
               $"WHERE Properties.ID_Extractor = {idExtr};";
           
            List<string> result = dataBase.GetTable(cmd)[0];
            for(int i = 0; i < result.Count; i++)
                strings[i] += result[i];
            textBoxProp.Text = String.Join("\n", strings.ToArray());
            cmd = "SELECT Info " +
                    "FROM Extractor " +
                    $"WHERE ID_Extractor = {idExtr}";
            result = dataBase.GetTable(cmd)[0];
            textBoxInfo.Text = String.Join("\n", result.ToArray());

            cmd = $"SELECT pathToPhoto FROM Extractor WHERE ID_Extractor = {idExtr}";
            string file = dataBase.GetFirstValue(cmd);
            ShowImage(file);
            
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


        private void filterButton_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach(Form frm in fc)
            {
                if(frm.Name == "FilterWindow")
                {
                    frm.Focus();
                    return;
                }
            }
            FilterWindow form = new FilterWindow(dataExtractor);
            form.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idExtractor = GetSelectedExtrId(dataExtractor);
            string cmd = $"DELETE FROM Properties WHERE ID_Extractor = {idExtractor}";
            dataBase.executeCmd(cmd);
            cmd = $"DELETE FROM Extractor WHERE ID_Extractor = {idExtractor}";
            dataBase.executeCmd(cmd);
            MessageBox.Show("Данные удалены.");
        }

        //Вывод данных о экстракторе на панельки
        private void dataExtractor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int idExtractor = GetSelectedExtrId(dataExtractor);
            if (idExtractor != -1)
            {
                GetExtractorProp(idExtractor, textBoxProp);
                return;
            }
            textBoxInfo.Text = "";
            textBoxProp.Text = "";


        }

        public int GetSelectedExtrId(DataGridView dataExtractor)
        {
            int selectedRow = dataExtractor.CurrentCell.RowIndex;
            int extrId = -1;
            try
            {
                extrId = Convert.ToInt32(dataExtractor.Rows[selectedRow].Cells["ID_Экстрактора"].Value);
            }
            catch (Exception ex)
            {
                return extrId;
            }
            return extrId;
        }

        //Кнопки админа
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "NewExtractorForm")
                {
                    frm.Focus();
                    return;
                }
            }          
            NewExtractorForm form = new NewExtractorForm();
            form.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "UpdateForm")
                {
                    frm.Focus();
                    return;
                }
            }
            int idExtractor = GetSelectedExtrId(dataExtractor);
            UpdateForm form = new UpdateForm(idExtractor);
            form.Show();
        }



        private void searchForName_button_Click(object sender, EventArgs e)
        {
            string str = searchTextBox.Text;
            if (str == "Поиск по названию")
            {
                MessageBox.Show("Введите название!");
                return;
            }
            db dataBase = new db();
            string cmd = "SELECT Extractor.ID_Extractor AS `ID_Экстрактора`, " +
               " Extractor.Name AS `Модель`, " +
               " Manufacturer.Name AS `Производитель`, " +
               " ExtractorSubtype.Name AS `Подтип` , " +
               " Extractor.Price AS `Цена` ," + 
               " Extractor.Info AS `Информация` " +
               "FROM Extractor " +
               "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
               "JOIN ExtractorSubtype ON Extractor.ID_Subtype = ExtractorSubtype.ID_Subtype " +
               $"WHERE Extractor.Name LIKE '{str}%'";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Поиск по названию";
            }
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "FilterWindow")
                {
                    frm.Focus();
                    return;
                }
            }
            FilterWindow form = new FilterWindow(dataExtractor);
            form.Show();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Поиск по названию")
                searchTextBox.Clear();
        }

        private void adminButton(bool value)
        {
            buttonUpdate.Enabled = value;
            buttonDelete.Enabled = value;
            buttonAdd.Enabled = value;
        }

        private void MainFrom_Activated(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd =
                 "SELECT Extractor.ID_Extractor as `ID_Экстрактора`, Extractor.Name as 'Модель', Manufacturer.Name as `Производитель`, ExtractorSubtype.Name as `Подтип`, " +
                 "Extractor.Price as `Цена`, Extractor.Info as `Информация` " +
                 "FROM Extractor " +
                 "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                 "JOIN ExtractorSubtype ON Extractor.ID_Subtype = ExtractorSubtype.ID_Subtype ";
            try
            {
                dataExtractor.DataSource = dataBase.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
