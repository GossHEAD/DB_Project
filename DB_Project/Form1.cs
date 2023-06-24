using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using DB_Project.Data;
using System.Collections;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        db db = new db();
        DataSet1 DataSet1 = new DataSet1();
        DataTable table = new DataTable();
        public int role_ID;
        
       //Конструкторы
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(int role)
        {
            InitializeComponent();
            role_ID = role;
            labelRole.Text = takeRole();
            checkRole();
            Role check = new Role();
            check.OpenConnection();
        }
       //Проверка ролей
        private string takeRole()
        {
            int userId = role_ID;
            string check = "";
            db db = new db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
         
            MySqlCommand command = new MySqlCommand("SELECT роль.Название FROM пользователь INNER JOIN роль " +
                "ON пользователь.ID_Роль=роль.ID_Роль WHERE Пользователь.ID_Пользователь=@userId;", db.getConnection());

            command.Parameters.Add("@userId", MySqlDbType.Int64).Value = userId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            check = table.Rows[0]["Название"].ToString();
           
            return check;
        }
        private void checkRole()
        {
            string chech = takeRole();
            using (SpecialWindow sp = new SpecialWindow(chech))
            {
                if (chech == "Упр_Производством")
                {
                    //Таблицы
                    buttonDeliveries.Visible = false;
                    buttonOffs.Visible = false;
                    buttonPath.Visible = false;

                    //Операции
                    panelBuyer.Visible = false;
                    panelSeller.Visible = false;
                    panelStocks.Visible = false;
                    panelLogist.Visible = false;
                }
                if (chech == "Логист")
                {
                    //Таблицы
                    //buttonStocks.Visible = false;
                    buttonStage.Visible = false;
                    buttonMaterial.Visible = false;
                    buttonOrder.Visible = false;
                    buttonDeliveries.Visible = false;
                    buttonOffs.Visible = false;
                    buttonOutput.Visible = false;
                    //Операции
                    panelBoss.Visible = false;
                    panelBuyer.Visible = false;
                    panelSeller.Visible = false;
                    panelStocks.Visible = false;

                }
                if (chech == "Кладовщик")
                {
                    //Таблицы
                    buttonStage.Visible = false;
                    buttonMaterial.Visible = false;
                    buttonOrder.Visible = false;
                    buttonDeliveries.Visible = false;
                    buttonOffs.Visible = false;
                    buttonPath.Visible = false;

                    //Операции
                    panelBoss.Visible = false;
                    panelBuyer.Visible = false;
                    panelSeller.Visible = false;
                    panelLogist.Visible = false;
                }
                if (chech == "Продавец")
                {
                    //Таблицы
                    buttonStocks.Visible = false;
                    buttonStage.Visible = false;
                    buttonMaterial.Visible = false;
                    //buttonOrder.Visible = false;
                    buttonDeliveries.Visible = false;
                    buttonOffs.Visible = false;
                    //buttonOutput.Visible = false;
                    buttonPath.Visible = false;
                    buttonTravel.Visible = false;
                    buttonStorage.Visible = false;

                    //Операции
                    panelBoss.Visible = false;
                    panelBuyer.Visible = false;
                    //panelSeller.Visible = false;
                    panelStocks.Visible = false;
                    panelLogist.Visible = false;
                }

                if (chech == "Закупщик")
                {
                    //Таблицы
                    //buttonStocks.Visible = false;
                    buttonStage.Visible = false;
                    //buttonMaterial.Visible = false;
                    buttonOrder.Visible = false;
                    //buttonDeliveries.Visible = false;
                    buttonOffs.Visible = false;
                    buttonOutput.Visible = false;
                    buttonPath.Visible = false;
                    buttonTravel.Visible = false;

                    //Операции
                    panelBoss.Visible = false;

                    panelSeller.Visible = false;
                    panelStocks.Visible = false;

                    panelLogist.Visible = false;
                }
            }
        }       

        //Кнопки выбора таблиц
        private void buttonPath_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from маршрут";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonMaterial_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from материал";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void buttonTravel_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from перемещение";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonDeliveries_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from поступления";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from `производственный заказ`";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from выход_гп";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonStocks_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from запасы";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonStorage_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from склад";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonOffs_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from списание";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonStage_Click(object sender, EventArgs e)
        {
            string cmd = @"select * from этап_производства";
            try
            {
                using (var connection = db.getConnection())
                {
                    db.OpenConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataSet1BindingSource.DataSource = dt;
                    db.CloseConnection();
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
            db.CloseConnection();
            Application.Exit();
        }


        //Кнопки Логиста
       
        private void buttonAddDeliver_Click(object sender, EventArgs e)
        {
            using (SpecialWindow form2 = new SpecialWindow("Логист"))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    string sqlexp1 = "Select * from `Перемещение`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
                    List<string> list = new List<string>() { form2.textBoxDeliverCount.Text, form2.dateTimePickerDeliverCreated.Text, form2.dateTimePickerDeliverOffs.Text, 
                        form2.dateTimePickerDeliverTake.Text, form2.listBoxDeliverMat.Text, form2.listBoxDeliverPath.Text };
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    DataRow row1 = dt.NewRow();
                    ;
                    row1["Количество"] = Convert.ToInt64(list[0]);
                    row1["Дата"] = Convert.ToDateTime(list[1]);
                    row1["Отгрузка"] = DBNull.Value;//Convert.ToDateTime(list[2]);
                    row1["Выгрузка"] = DBNull.Value;//Convert.ToDateTime(list[3]);
                    row1["id_mat"] = Convert.ToInt64(list[4]);
                    row1["id_марш"] = Convert.ToInt64(list[5]);

                    dt.Rows.Add(row1);
                    adapter.Update(dt);
                }

            }
        }

        private void buttonAddPath_Click(object sender, EventArgs e)
        {
            
            using (SpecialWindow form2 = new SpecialWindow("Логист"))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    string sqlexp1 = "Select * from `маршрут`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
                    List<string> list = new List<string>() { form2.textBoxTimePath.Text, form2.listBoxToPath.SelectedItem.ToString(), form2.listBoxFromPath.SelectedItem.ToString(), form2.listBoxTransit.SelectedItem.ToString() };
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    DataRow row1 = dt.NewRow();
                    row1["Время"] = Convert.ToInt64(list[0]);
                    row1["id_склад_от"] = Convert.ToInt64(list[2]);
                    row1["id_склад_куда"] = Convert.ToInt64(list[1]);
                    row1["id_склад_транзит"] = Convert.ToInt64(list[3]);
                    dt.Rows.Add(row1);
                    adapter.Update(dt);
                }

            }
        }

        //Кнопки кладовщика
        private void buttonTakeBaggage_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            int row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.RowIndex == null) row = 0;
            string sqlexp1 = "Select * from `Перемещение`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
            DataTable dt = new DataTable();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Fill(dt);
            DataRow row1 = dt.Rows[row];

            using (SpecialWindow form2 = new SpecialWindow("Кладовщик"))
            {
                form2.textBoxDeliverCount.Text = row1["Количество"].ToString();
                form2.dateTimePickerDeliverCreated.Text = row1["Дата"].ToString();
                form2.dateTimePickerDeliverOffs.Text = row1["Отгрузка"].ToString();
                form2.dateTimePickerDeliverTake.Text = DBNull.Value.ToString();
                form2.listBoxDeliverMat.Text = row1["id_mat"].ToString();
                form2.listBoxDeliverPath.Text = row1["id_марш"].ToString();

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    List<string> list = new List<string>() { form2.textBoxDeliverCount.Text, form2.dateTimePickerDeliverCreated.Text, form2.dateTimePickerDeliverOffs.Text,
                        form2.dateTimePickerDeliverTake.Text, form2.listBoxDeliverMat.Text, form2.listBoxDeliverPath.Text };


                    string query = $"UPDATE Перемещение SET Выгрузка='{form2.dateTimePickerDeliverTake.Value.ToString("yyyy-MM-dd")}' WHERE id_пер={Convert.ToInt64(row1["id_пер"])}";
                    adapter = new MySqlDataAdapter(query, db.getConnection());
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    adapter.Update(dt);
                }

            }
        }

        private void buttonSendBaggage_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            int row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.RowIndex == null) row = 0;
            string sqlexp1 = "Select * from `Перемещение`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
            DataTable dt = new DataTable();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Fill(dt);
            DataRow row1 = dt.Rows[row];

            using (SpecialWindow form2 = new SpecialWindow("Кладовщик"))
            {
                form2.textBoxDeliverCount.Text = row1["Количество"].ToString();
                form2.dateTimePickerDeliverCreated.Text = row1["Дата"].ToString();
                form2.dateTimePickerDeliverOffs.Text = DBNull.Value.ToString();
                form2.dateTimePickerDeliverTake.Text = DBNull.Value.ToString();
                form2.listBoxDeliverMat.Text = row1["id_mat"].ToString();
                form2.listBoxDeliverPath.Text = row1["id_марш"].ToString();

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    List<string> list = new List<string>() { form2.textBoxDeliverCount.Text, form2.dateTimePickerDeliverCreated.Text, form2.dateTimePickerDeliverOffs.Text,
                        form2.dateTimePickerDeliverTake.Text, form2.listBoxDeliverMat.Text, form2.listBoxDeliverPath.Text };


                    string query = $"UPDATE Перемещение SET Отгрузка='{form2.dateTimePickerDeliverOffs.Value.ToString("yyyy-MM-dd")}' WHERE id_пер={Convert.ToInt64(row1["id_пер"])}";
                    adapter = new MySqlDataAdapter(query, db.getConnection());
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    adapter.Update(dt);
                }

            }
        }

        //Кнопка закупщика
        private void buttonCreateSupply_Click(object sender, EventArgs e)
        {
            using (SpecialWindow form2 = new SpecialWindow("Закупщик"))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    string sqlexp1 = "Select * from `Поступления`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
                    List<string> list = new List<string>() { form2.dateTimePickerBuyer.Text, form2.textBoxBuyer.Text, form2.listBoxMatBuyer.SelectedItem.ToString(), form2.listBoxStageBuyer.SelectedItem.ToString() };
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    DataRow row1 = dt.NewRow();
                    row1["Дата"] = Convert.ToDateTime(list[0]);
                    row1["Количество"] = Convert.ToInt64(list[1]);
                    row1["id_mat"] = Convert.ToInt64(list[2]);
                    row1["id_склад"] = Convert.ToInt64(list[3]);
                    dt.Rows.Add(row1);
                    adapter.Update(dt);
                }

            }
        }
        //Кнопки продавца
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            using (SpecialWindow form2 = new SpecialWindow("Продавец"))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    string sqlexp1 = "Select * from `Производственный заказ`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
                    List<string> list = new List<string>() { form2.dateTimePickerSellerOrder.Text, form2.textBoxSellerCount.Text, form2.listBoxStageBuyer.SelectedItem.ToString()};
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    DataRow row1 = dt.NewRow();
                    row1["Дата"] = Convert.ToDateTime(list[0]);
                    row1["Количество"] = Convert.ToInt64(list[1]);
                    row1["id_этап"] = Convert.ToInt64(list[2]);
                    row1["id_mat"] = DBNull.Value;
                    row1["id_спис"] = DBNull.Value;
                    dt.Rows.Add(row1);
                    adapter.Update(dt);
                }

            }
        }
        //Кнопки управляющего
        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            int row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.RowIndex == null) row = 0;

            string sqlexp1 = "Select * from `Производственный заказ`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
            DataTable dt = new DataTable();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

            adapter.Fill(dt);
            DataRow row1 = dt.Rows[row];
            using (SpecialWindow form2 = new SpecialWindow("Упр_Производством"))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    List<string> listProd = new List<string>() { form2.dateTimePickerBossOrder.Text, form2.listBoxStageBoss.SelectedItem.ToString(), form2.listBoxMatBoss.SelectedItem.ToString()};


                    string query = $"UPDATE `Производственный заказ` SET Дата='{form2.dateTimePickerBossOrder.Value.ToString("yyyy-MM-dd")}', id_этап = '{Convert.ToInt64(listProd[1])}', id_мат = {listProd[2]}  " +
                        $"WHERE id_прод={Convert.ToInt64(row1["id_прод"])}";


                    adapter = new MySqlDataAdapter(query, db.getConnection());
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    adapter.Update(dt);

                    string query1 = $"INSERT INTO `Списание`(Количество, id_mat, id_этап, id_склад) Values('{form2.textBoxOffsCount.Text}'," +
                        $"'{listProd[2]}','{listProd[1]}',{form2.listBoxOffsStorage.SelectedItem.ToString()})";
                    adapter = new MySqlDataAdapter(query1, db.getConnection());
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);
                    adapter.Update(dt);


                    string sqlexp2 = $"Select id_спис from `Списание` where id_mat = {listProd[2]} and id_этап = {listProd[1]}";
                    adapter = new MySqlDataAdapter(sqlexp2, db.getConnection());
                    dt = new DataTable();
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    adapter.Fill(dt);

                    query = $"UPDATE `Производственный заказ` SET id_спис={dt.Rows[0]["id_спис"]} ";
                    adapter = new MySqlDataAdapter(query, db.getConnection());
                    commandBuilder = new MySqlCommandBuilder(adapter);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    adapter.Update(dt);

                }

            }
        }

        private int FindPath(int idFrom, int idTo)
        {
            try
            {
                db.OpenConnection();
                string query = "Select id_марш from Маршрут where id_склад_от = @idFrom and id_склад_куда = @idTo";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.AddWithValue("@idFrom", idFrom);
                command.Parameters.AddWithValue("@idTo", idTo);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
                else
                {
                    throw new Exception(string.Format("Нет маршрута между складами {0} и {1}.", idFrom, idTo));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        private void CreateTransferOrder(int idFrom, int idTo)
        {


            db.OpenConnection();
            string query = "INSERT INTO перемещения (id_марш, Количество) VALUES (@routeId, 1)";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@routeId", FindPath(idFrom, idTo));
            command.ExecuteNonQuery();

        }
        public void OfferCompositePath(int idFrom, int idTo)
        {
            List<int> viaStorageList = new List<int>();
            db.OpenConnection();
            string query = "SELECT id_склад_от, id_склад_куда FROM Маршрут " +
            "WHERE id_склад_от = @idFrom OR id_склад_куда = @idTo " +
            "UNION " +
            "SELECT m1.id_склад_от, m2.id_склад_куда FROM маршруты m1 " +
            "JOIN Маршрут m2 ON m1.id_склад_куда = m2.id_склад_от " +
            "WHERE m1.id_склад_от = @idFrom AND m2.id_склад_куда = @idTo";
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@idFrom", idFrom);
            command.Parameters.AddWithValue("@idTo", idTo);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int warehouseIdFrom = reader.GetInt32(0);
                int warehouseIdTo = reader.GetInt32(1);
                if (warehouseIdFrom != idFrom)
                {
                    viaStorageList.Add(warehouseIdFrom);
                }
                if (warehouseIdTo != idTo)
                {
                    viaStorageList.Add(warehouseIdTo);
                }
            }
            reader.Close();

            
            // Если есть склады, через которые можно проехать, выводим сообщение с предложением составить маршрут
            if (viaStorageList.Count > 0)
            {
                string viaWarehouses = string.Join(", ", viaStorageList);
                string message = string.Format("Нет прямого маршрута между складами {0} и {1}. " +
                    "Однако, вы можете проехать через следующие склады: {2}. " +
                    "Хотите составить маршрут, проходящий через них?",
                    idFrom, idTo, viaWarehouses);
                DialogResult result = MessageBox.Show(message, "Предложение составить маршрут", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Создание заказов перемещения
                    foreach (int viaWarehouse in viaStorageList)
                    {
                        CreateTransferOrder(idFrom, viaWarehouse);
                        idFrom = viaWarehouse;
                    }
                    CreateTransferOrder(idFrom, idTo);
                }
            }
            else
            {
            MessageBox.Show("Между складами нет прямого маршрута и нет складов, через которые можно проехать.", "Ошибка");
            }
        }
    }
}
