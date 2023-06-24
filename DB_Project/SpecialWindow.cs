using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class SpecialWindow : Form
    {
        db db = new db();
        DataSet1 DataSet1 = new DataSet1();
        DataTable table = new DataTable();
        MySqlDataAdapter a = new MySqlDataAdapter();
        MySqlDataAdapter b = new MySqlDataAdapter();

        public SpecialWindow()
        {
            InitializeComponent();
        }

        public SpecialWindow(string s)
        {
            InitializeComponent();
            if (s == "Упр_Производством")
            {
                //Операции
                SpecialPanelDeliver.Visible = false;
                SpecialPanelPath.Visible = false;
                panelSpecialBuyer.Visible = false;
                panelSpecialSeller.Visible = false;
            }
            if (s == "Логист")
            {
                //Операции
                panelSpecialBuyer.Visible = false;
                panelSpecialSeller.Visible = false;
                specialPanelBoss.Visible = false;
                specialPanelOffs.Visible = false;
                //SpecialPanelPath.Visible = false;
                SpecialPanelDeliver.Visible = false;

            }
            if (s == "Кладовщик")
            {
                SpecialPanelPath.Visible = false;
                panelSpecialBuyer.Visible = false;
                panelSpecialSeller.Visible = false;
                specialPanelBoss.Visible = false;
                specialPanelOffs.Visible = false;
            }
            if (s == "Продавец")
            {
                specialPanelBoss.Visible = false;
                specialPanelOffs.Visible = false;
                SpecialPanelPath.Visible = false;
                panelSpecialBuyer.Visible = false;
                SpecialPanelDeliver.Visible = false;
            }

            if (s == "Закупщик")
            {
                specialPanelBoss.Visible = false;
                specialPanelOffs.Visible = false;
                SpecialPanelPath.Visible = false;
                panelSpecialSeller.Visible = false;
                SpecialPanelDeliver.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpecialWindow_Load(object sender, EventArgs e)
        {
            takeToFromPathId();
            takePathAndMatId();
            takeStageID();          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void takeToFromPathId()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            MySqlCommand command1 = new MySqlCommand("SELECT `id_склад` FROM `Склад`", db.getConnection());

            a.SelectCommand = command1;
            a.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list1.Add((table.Rows[i]["id_склад"]).ToString());
                list2.Add((table.Rows[i]["id_склад"]).ToString());
                list3.Add((table.Rows[i]["id_склад"]).ToString());
            }
            listBoxToPath.DataSource = list1;
            listBoxFromPath.DataSource = list2;
            listBoxTransit.DataSource = list3;
            listBoxStageBuyer.DataSource = list2;
        }
        private void takePathAndMatId()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            MySqlCommand command1 = new MySqlCommand("SELECT `id_mat`, `id_марш` FROM `Материал` CROSS JOIN `Маршрут`", db.getConnection());            

            a.SelectCommand = command1;
            a.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list1.Add(table.Rows[i]["id_mat"].ToString());
                list2.Add(table.Rows[i]["id_марш"].ToString());
            }
            list1 = list1.Distinct().ToList();
            list2 = list2.Distinct().ToList();

            listBoxDeliverMat.DataSource = list1;
            listBoxDeliverPath.DataSource = list2;

            MySqlCommand command2 = new MySqlCommand("SELECT `id_mat` FROM `Материал`", db.getConnection());
            b.SelectCommand = command2;
            table.Clear();
            b.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list3.Add(table.Rows[i]["id_mat"].ToString());
            }
            list3 = list3.Distinct().ToList();
            listBoxMatBuyer.DataSource = list3;
            listBoxMatBoss.DataSource = list3;
        }

        private void takeStageID()
        {
            List<string> listStage = new List<string>();
            MySqlCommand command1 = new MySqlCommand("SELECT `id_этап` FROM `Этап_производства`", db.getConnection());

            a.SelectCommand = command1;
            a.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                listStage.Add(table.Rows[i]["id_этап"].ToString());
                
            }

            //list1 = list1.Distinct().ToList();
            listBoxSellerStage.DataSource = listStage;
            listBoxStageBoss.DataSource = listStage;
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listMatValueChanged(object sender, EventArgs e)
        {
            DataTable dt_new = new DataTable();
            dt_new = checkStage(Convert.ToInt32(listBoxMatBoss.SelectedItem.ToString()));

            List<string> list1 = new List<string>();
            for (int i = 0; i < dt_new.Rows.Count; i++)
            {
                list1.Add((dt_new.Rows[i]["id_склад"]).ToString());
            }
            listBoxOffsStorage.DataSource = list1;
        }
        private DataTable checkStage(int id_mat)
        {
            string sqlexp1 = $"Select id_склад from `Запасы` where id_mat = {id_mat} ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexp1, db.getConnection());
            DataTable dt = new DataTable();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Fill(dt);

            return dt;
        }
    }
}
