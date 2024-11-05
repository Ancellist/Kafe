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
    public partial class FormWaiter : Form
    {
        public FormWaiter()
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

        private void FormWaiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Show();
            }
        }

        private void FormWaiter_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Orders`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;
        }

        private void buttonRegNewOrder_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            string numberTable = textBoxNumberTable.Text;
            string countGuests = textBoxCountGuests.Text;
            string food = textBoxFood.Text;
            string drinks = textBoxDrinks.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `orders`(`numberTable`,`countGuests`,`food`,`drinks`,`dateTime`) VALUES(@nTable,@cGuests,@f,@d,@dTime) ", db.getConnection());
            command.Parameters.Add("@nTable", MySqlDbType.Int32).Value = int.Parse(numberTable);
            command.Parameters.Add("@cGuests", MySqlDbType.Int32).Value = int.Parse(countGuests);
            command.Parameters.Add("@f", MySqlDbType.VarChar).Value = food;
            command.Parameters.Add("@d", MySqlDbType.VarChar).Value = drinks;
            command.Parameters.Add("@dTime", MySqlDbType.DateTime).Value = dateNow;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
        }
    }
}
