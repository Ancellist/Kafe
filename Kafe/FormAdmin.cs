using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Kafe
{
    public partial class FormAdmin : Form
    {
        FormRegistrationUser FormRegistrationUser = new FormRegistrationUser();
        FormWatchOrders FormWatchOrders = new FormWatchOrders();
        FormAppointmentToReplacement FormAppointmentToReplacement = new FormAppointmentToReplacement();
        public FormAdmin()
        {
            InitializeComponent();
            AddOwnedForm(FormRegistrationUser);
            AddOwnedForm(FormWatchOrders);
            AddOwnedForm(FormAppointmentToReplacement);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dataGridViewWorkers.DataSource = table;

        }

        private void buttonRegNewUser_Click(object sender, EventArgs e)
        {
            FormRegistrationUser.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridViewWorkers.DataSource = null;
            dataGridViewWorkers.DataSource = table;
        }

        private void buttonWatchAllOrders_Click(object sender, EventArgs e)
        {
            FormWatchOrders.Show();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Owner.Show();
            }
        }

        private void buttonExit_MouseMove(object sender, MouseEventArgs e)
        {
            buttonExit.BackColor = Color.Red;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.FromArgb(38,198,108);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {;
            Hide();
            Owner.Show();
        }

        private void buttonAppointmentToReplacement_Click(object sender, EventArgs e)
        {
            FormAppointmentToReplacement.ShowDialog();
        }

        private void buttonAppointmentToReplacement_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAppointmentToReplacement.BackColor = Color.FromArgb(26, 130, 71);
        }

        private void buttonAppointmentToReplacement_MouseLeave(object sender, EventArgs e)
        {
            buttonAppointmentToReplacement.BackColor = Color.FromArgb(38, 198, 108);
        }

        private void dataGridViewWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
