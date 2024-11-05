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
    public partial class FormAppointmentToReplacement : Form
    {
        public FormAppointmentToReplacement()
        {
            InitializeComponent();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            var dataShift = dateTimePicker1.Value.Date;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `shifts` (`shiftDate`) VALUES (@dShift)",db.getConnection());
            command.Parameters.Add("@dShift", MySqlDbType.Date).Value = dataShift;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.Close();
          
        }

        private void FormAppointmentToReplacement_Load(object sender, EventArgs e)
        {
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
