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
    public partial class FormWatchOrders : Form
    {
        public FormWatchOrders()
        {
            InitializeComponent();
        }

        private void FormWatchOrders_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `orders`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = table;
        }

        private void FormWatchOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
