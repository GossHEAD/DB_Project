using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DB_Project.GeneralFunction;

namespace DB_Project.Forms.AdminPanel
{
    public partial class NewExtractorForm : Form
    {
        public NewExtractorForm()
        {
            InitializeComponent();
        }

        private void NewExtractorForm_Load(object sender, EventArgs e)
        {
            db dataBase = new db();

            string cmd = "SELECT * FROM `ExtractorGroup`";
            addItemToComboBox(cmd, groupBox, 0, 1);

            cmd = "SELECT * FROM `Manufacturer`";
            addItemToComboBox(cmd, manufactureBox, 0, 1);

            cmd = "SELECT * FROM `OperatingMode`";
            addItemToComboBox(cmd, operatingModeBox, 0, 1);

            cmd = "SELECT * FROM `CaseType`";
            addItemToComboBox(cmd, housingTypeBox, 0, 1);

            cmd = "SELECT * FROM `HousingLocation`";
            addItemToComboBox(cmd, housingLocationBox, 0, 1);

            cmd = "SELECT * FROM `TypeOfMixing`";
            addItemToComboBox(cmd, typeOfMixingBox, 0, 1);
        }

        private void escapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `ExtractorType` WHERE `ID_Group` = {idGroup}";
            addItemToComboBox(cmd, typeBox, 0, 1);
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db dataBase = new db();
            int idGroup = ((MyItem)(groupBox.SelectedItem)).Id;
            int idType = ((MyItem)(typeBox.SelectedItem)).Id;
            string cmd = $"SELECT * FROM `ExtractorSubtype` WHERE `ID_Group` = {idGroup} AND `ID_Type` = {idType}";
            addItemToComboBox(cmd, subtypeBox, 0, 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            db dataBase = new db();
            Int32.TryParse(priceBox.Text, out int price);
            Int32.TryParse(bodyLengthBox.Text, out int bodyLength);
            Int32.TryParse(caseWidthBox.Text, out int caseWidth);
            Int32.TryParse(efficiencyBox.Text, out int efficiency);
            if(price == 0 || bodyLength == 0 || caseWidth == 0 || efficiency == 0)
            {
                MessageBox.Show("Введите положительные числа в полях цены, высоты, ширины и эффективности.");
                return;
            }
            if(nameBox.Text == "")
            {
                MessageBox.Show("Введите название экстрактора.");
                return;
            }

            string cmd = "INSERT INTO Extractor(Name, Price, ID_Manufacturer, ID_Subtype, Info, pathToPhoto) " +
                        $"VALUES ('{nameBox.Text}', {price}, {getIdFromMyItem(manufactureBox)}, " +
                        $"{getIdFromMyItem(subtypeBox)}, '{informationTextBox.Text}', " +
                        $"'{pathToFileBox.Text}')";
            dataBase.executeCmd(cmd);
            cmd = "SELECT ID_Extractor FROM Extractor " +
                "WHERE ID_Extractor NOT IN (SELECT Properties.ID_Extractor FROM Properties)";

            int id = Int32.Parse(dataBase.GetFirstValue(cmd));

            cmd = "INSERT INTO Properties(ID_Extractor, BodyLength,CaseWidth," +
                " Efficiency, ID_OperatingMode, ID_CaseType," +
                " ID_HousingLocation, ID_TypeOfMixing) VALUES " +
                $"({id}, {bodyLength}, {caseWidth}, " +
                $"{efficiency}, {getIdFromMyItem(operatingModeBox)}, " +
                $"{getIdFromMyItem(housingTypeBox)}, {getIdFromMyItem(housingLocationBox)}, " +
                $"{getIdFromMyItem(typeOfMixingBox)})";
            dataBase.executeCmd(cmd);

            MessageBox.Show("Данные введены.");
            this.Close();
        }

        private void pathToFileBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if(path == "")
            {
                pathToFileBox.Text = "DEFAULT";

            }
        }


    }
}
