using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Project
{
    internal class GeneralFunction
    {
        public class MyItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public MyItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"{Id} - {Name}";
            }
        }

        static public void InsertItemToComboBox(ComboBox CB, object[] objId, object[] objName)
        {
            CB.ValueMember = "Id";
            CB.DisplayMember = "Name";
            for (int i = 0; i < objId.Length; i++)
            {
                MyItem item = new MyItem(Convert.ToInt32(objId[i]), objName[i].ToString());
                CB.Items.Add(item);
            }
            if (objId.Length != 0)
                CB.SelectedIndex = 0;
        }

        static public void addItemToComboBox(in string cmd, ComboBox cb, in int idColumn, in int valueColumn)
        {
            db dataBase = new db();
            List<List<string>> table = dataBase.GetTable(cmd);
            cb.Items.Clear();
            InsertItemToComboBox(cb, GetThisColumn(table, idColumn), GetThisColumn(table, valueColumn));
            cb.Enabled = true;
        }

        static public void d(in DataTable data, ComboBox cb, in string idColumn, in string valueColumn)
        {
            foreach (DataRow row in data.Rows)
            {
                
            }
        }

        static public int getIdFromMyItem(ComboBox comboBox)
        {
            try
            {
                return ((MyItem)(comboBox.SelectedItem)).Id;
            }
            catch{
                return -1;
            }
        }

        static public object[] GetThisColumn(in List<List<string>> list, in int numberColumn)
        {
            object[] obj = new object[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                obj[i] = list[i][numberColumn];
            }
            return obj;
        }

        public int GetSelectedExtrId(DataGridView dataExtractor)
        {
            int selectedRow = dataExtractor.CurrentCell.RowIndex;
            int extrId = Convert.ToInt32(dataExtractor.Rows[selectedRow].Cells["ID_Extractor"].Value);
            return extrId;
        }

        public string GetTitileAndNameFromProperties(string tableName, string idProperty)
        {
            string result = "";
            string cmd = $"SELECT ID_{tableName}.Properties, " +
                $"{tableName}.Name, " +
                $"{tableName}.Title " +
                $"FROM Properties " +
                $"JOIN {tableName} ON Properties.ID_{tableName} = {tableName}.ID_{tableName};";

            return result;
        }

    }
}
