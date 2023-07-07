using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DB_Project.GeneralFunction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DB_Project
{
    public partial class FilterWindow : Form
    {

        DataGridView data;
        public FilterWindow(DataGridView dgv)
        {
            InitializeComponent();
            data = dgv;
        }

        private void FilterWindow_Load(object sender, EventArgs e)
        {
            typeBox.Enabled = false;
            subtypeBox.Enabled = false;
            db dataBase = new db();
            string cmd = "SELECT * FROM `ExtractorGroup`";
            addItemToComboBox(cmd, groupBox, 0, 1);

            cmd = "SELECT * FROM `Manufacturer`";
            addItemToComboBox(cmd, manufacturerBox, 0, 1);
            manufacturerBox.Items.Add(new MyItem(-1, ""));
            
            cmd = "SELECT * FROM `OperatingMode`";
            addItemToComboBox(cmd, operatingModeBox, 0, 1);
            operatingModeBox.Items.Add(new MyItem(-1, ""));

            cmd = "SELECT * FROM `CaseType`";
            addItemToComboBox(cmd, housingTypeBox, 0, 1);
            housingTypeBox.Items.Add(new MyItem(-1, ""));

            cmd = "SELECT * FROM `HousingLocation`";
            addItemToComboBox(cmd, housingLocationBox, 0, 1);
            housingLocationBox.Items.Add(new MyItem(-1, ""));

            cmd = "SELECT * FROM `TypeOfMixing`";
            addItemToComboBox(cmd, typeOfMixingBox, 0, 1);
            typeOfMixingBox.Items.Add(new MyItem(-1, ""));

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string nameManufacturer = ((MyItem)(manufacturerBox.SelectedItem)).Name;
            db dataBase = new db();

            int idManufacturer = ((MyItem)(manufacturerBox.SelectedItem)).Id;
            int idSubtype = ((MyItem)(subtypeBox.SelectedItem)).Id;
            int idOperatingMode = ((MyItem)(operatingModeBox.SelectedItem)).Id;
            int idCaseType = ((MyItem)(housingTypeBox.SelectedItem)).Id;
            int idHousingLocation = ((MyItem)(housingLocationBox.SelectedItem)).Id;
            int idTypeOfMixing = ((MyItem)(typeOfMixingBox.SelectedItem)).Id;

            string mainCmd = "SELECT Extractor.ID_Extractor as `ID_Экстрактора`, " +
                " Extractor.Name as 'Модель', " +
                " Manufacturer.Name as `Производитель`, " +
                " ExtractorSubtype.Name as `Подтип`, " +
                " Extractor.Price as `Цена`, " +
                " Extractor.Info as `Информация` " +
                "FROM Extractor " +
                "JOIN Manufacturer ON Extractor.ID_Manufacturer = Manufacturer.ID_Manufacturer " +
                "JOIN ExtractorSubtype ON Extractor.ID_Subtype = ExtractorSubtype.ID_Subtype ";

            string conditionCmd = "WHERE ";

            if(idManufacturer != -1)
            {
                conditionCmd += $"Manufacturer.Name = '{nameManufacturer}' AND ";
            }
            if (idSubtype != -1)
            {
                conditionCmd += $"Extractor.ID_Subtype = {idSubtype} AND ";
            }

            if(idManufacturer != -1 || idSubtype != -1)
            {
                mainCmd += conditionCmd;
            }

            string propertiesCmd = "ID_Extractor IN (" +
                "SELECT ID_Extractor " +
                "FROM Properties WHERE ";

            if(idOperatingMode != -1)
            {
                propertiesCmd += $" ID_OperatingMode = {idOperatingMode} AND ";
            }
            if (idCaseType != -1)
            {
                propertiesCmd += $" ID_CaseType = {idCaseType} AND ";
            }
            if (idHousingLocation != -1)
            {
                propertiesCmd += $" ID_HousingLocation = {idHousingLocation} AND ";
            }
            if (idTypeOfMixing != -1)
            {
                propertiesCmd += $" ID_TypeOfMixing = {idTypeOfMixing} AND";
            }
            if (idOperatingMode != -1 || idCaseType != -1 || idHousingLocation != -1 || idTypeOfMixing != -1)
            {
                if(idManufacturer == -1 || idSubtype == -1)
                {
                    mainCmd += conditionCmd;
                }
                mainCmd += propertiesCmd;
                mainCmd = replaceLastOccurance(mainCmd, "AND", "");
                mainCmd += ")";
            }
            else if(idManufacturer != -1 || idSubtype != -1)
            {
                mainCmd = replaceLastOccurance(mainCmd, "AND", "");
            }

            /*if(strProperties != ""){
                conditionCmd = "WHERE Extractor.Name IN ( " +
                "SELECT DISTINCT Extractor.Name FROM `Extractor` " +
                "JOIN `Extractor_Char` ON Extractor.ID_Extractor = " +
                "Extractor_Char.ID_Extractor " +
                $"WHERE Extractor_Char.ID_Properties IN {strProperties} " +
                "GROUP BY `Name` " +
                $"HAVING COUNT(DISTINCT Extractor_Char.ID_Properties) >= {countNotNull}) ";
                if (idSubtype != -1)
                {
                    conditionCmd += $"AND Extractor.ID_Subtype = {idSubtype} ";
                }
                if (nameManufacturer != "")
                {
                    conditionCmd += $"AND Manufacturer.Name = '{nameManufacturer}' ";
                }
            }
            else if (idSubtype != -1)
            {
                conditionCmd += $"WHERE Extractor.ID_Subtype = {idSubtype} ";
                if (nameManufacturer != "")
                {
                    conditionCmd += $"AND Manufacturer.Name = '{nameManufacturer}' ";
                }
            }
            else if (nameManufacturer != "")
            {
                conditionCmd += $"WHERE Manufacturer.Name = '{nameManufacturer}' ";
            }

            mainCmd += conditionCmd;*/

            try
            {
                data.DataSource = dataBase.GetDataTable(mainCmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        } 
        public static string replaceLastOccurance(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find);
            if (place == -1)
                return source;
            return source.Remove(place, find.Length).Insert(place, replace);
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MyItem)(groupBox.SelectedItem)).Name == "")
            {
                typeBox.Enabled = false;
                subtypeBox.Enabled = false;
                return;
            }
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `ExtractorType` WHERE `ID_Group` = {idGroup}";
            addItemToComboBox(cmd, typeBox, 0, 1);
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MyItem)(typeBox.SelectedItem)).Name == "")
            {
                subtypeBox.Enabled = false;
                return;
            }
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            int idType = ((MyItem)(typeBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `ExtractorSubtype` WHERE `ID_Group` = {idGroup} AND `ID_Type` = {idType}";
            addItemToComboBox(cmd, subtypeBox, 0, 1);
        }


        private void comboBox_EnabledChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Enabled == false)
            {
                ((ComboBox)sender).Items.Clear();
            }
        }




        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ComboBox cb = (ComboBox)sender;
            string name = cb.Name;
            int id = ((MyItem)(cb.SelectedItem)).Id;
            if (properties.ContainsKey(name))
            {
                properties[name] = id;
                return;
            }
            properties.Add(name, id);*/
        }
    }
}
