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

namespace DB_Project.Forms
{
    public partial class UpdateForm : Form
    {
        int id;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

            db dataBase = new db();

            idBox.Text = id.ToString();

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

            cmd = $"SELECT BodyLength FROM Properties WHERE ID_Extractor = {id}";
            bodyLengthBox.Text = dataBase.GetFirstValue(cmd).ToString(); 

            cmd = $"SELECT CaseWidth FROM Properties WHERE ID_Extractor = {id}";
            caseWidthBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Efficiency FROM Properties WHERE ID_Extractor = {id}";
            efficiencyBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Info FROM Extractor WHERE ID_Extractor = {id}";
            informationTextBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Name FROM Extractor WHERE ID_Extractor = {id}";
            nameBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT Price FROM Extractor WHERE ID_Extractor = {id}";
            priceBox.Text = dataBase.GetFirstValue(cmd).ToString();

            cmd = $"SELECT ID_Manufacturer FROM Extractor WHERE ID_Extractor = {id}";
            selectIndex(manufactureBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Group FROM ExtractorSubtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Extractor WHERE ID_Extractor = {id})";
            selectIndex(groupBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Type FROM ExtractorSubtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Extractor WHERE ID_Extractor = {id})";
            selectIndex(typeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_Subtype FROM ExtractorSubtype WHERE ID_Subtype =" +
                $" (SELECT ID_Subtype FROM Extractor WHERE ID_Extractor = {id})";
            selectIndex(subtypeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_OperatingMode FROM Properties WHERE ID_Extractor = {id}";
            selectIndex(operatingModeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_CaseType FROM Properties WHERE ID_Extractor = {id}";
            selectIndex(housingTypeBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_HousingLocation FROM Properties WHERE ID_Extractor = {id}";
            selectIndex(housingLocationBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT ID_TypeOfMixing FROM Properties WHERE ID_Extractor = {id}";
            selectIndex(typeOfMixingBox, Int32.Parse(dataBase.GetFirstValue(cmd)));

            cmd = $"SELECT pathToPhoto FROM Extractor WHERE ID_Extractor = {id}";
            pathToFileBox.Text = dataBase.GetFirstValue(cmd);

        }

        void selectIndex(ComboBox comboBox, int id)
        {
            var items = comboBox.Items;
            for(int i = 0; i < items.Count; i++)
            {
                if (((MyItem)items[i]).Id == id)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
        /*
          db db = new db();
            using (var connection = new SQLiteConnection(db.getConnection()))
            {
                connection.Open();
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
         */

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (priceBox.Text == "")
            {
                priceBox.Text = "NULL";
            }
            db dataBase = new db();
            string cmd = $"UPDATE Extractor SET Name = '{nameBox.Text}'," +
                $" Price = {priceBox.Text}, ID_Manufacturer = {getIdFromMyItem(manufactureBox)}," +
                $" ID_Subtype = {getIdFromMyItem(subtypeBox)}," +
                $" Info = '{informationTextBox.Text}', " +
                $" pathToPhoto = '{pathToFileBox.Text}'" +
                $"WHERE ID_Extractor = {idBox.Text}";
            dataBase.executeCmd(cmd);
            cmd = "UPDATE Properties SET " +
                $"BodyLength = {bodyLengthBox.Text}, " +
                $"CaseWidth = {caseWidthBox.Text}, " +
                $"Efficiency = {efficiencyBox.Text}, " +
                $"ID_OperatingMode = {getIdFromMyItem(operatingModeBox)}, " +
                $"ID_CaseType = {getIdFromMyItem(housingTypeBox)}, " +
                $"ID_HousingLocation = {getIdFromMyItem(housingLocationBox)}, " +
                $"ID_TypeOfMixing = {getIdFromMyItem(typeOfMixingBox)} " +
                $"WHERE ID_Extractor = {idBox.Text}";
            dataBase.executeCmd(cmd);
            MessageBox.Show("Данные обновлены");
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

        private void escapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pathToFileBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path == "")
            {
                pathToFileBox.Text = "DEFAULT";
                return;
            }
            pathToFileBox.Text = path;
        }
    }
}
