using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class FormCook : Form
    {
        public FormCook()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `orders`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = table;
        }

        private void FormCook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Show();
            }
        }

        private void FormCook_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `orders`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;

        }

        private void buttonChangeOrderStatus_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(textBoxIdOrder.Text);
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (comboBoxOrderStatus.Text =="Готовиться") {
                MySqlCommand command = new MySqlCommand("UPDATE `orders` SET `status`='Готовиться' WHERE `id_order`=@oId ", db.getConnection());
                command.Parameters.Add("@oId", MySqlDbType.Int32).Value = orderID;
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            if (comboBoxOrderStatus.Text == "Готов")
            {
                MySqlCommand command = new MySqlCommand("UPDATE `orders` SET `status`='Готов' WHERE `id_order`=@oId ", db.getConnection());
                command.Parameters.Add("@oId", MySqlDbType.Int32).Value = orderID;
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
        }
    }
}
