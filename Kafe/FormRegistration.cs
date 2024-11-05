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
    public partial class FormRegistrationUser : Form
    {
        public FormRegistrationUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegUser_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLoginUser.Text;
            string passUser = textBoxPasswordUser.Text;
            string nameUser = textBoxName.Text;
            string secondNameUser = textBoxSecondName.Text;
            string roleUser = comboBoxRoleUser.Text;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`,`password`,`name`,`secondName`,`role`) VALUES (@uLogin,@uPassword,@uName,@uSecondName,@uRole)", db.getConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPassword", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = nameUser;
            command.Parameters.Add("@uSecondName", MySqlDbType.VarChar).Value = secondNameUser;
            command.Parameters.Add("@uRole", MySqlDbType.VarChar).Value = roleUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            this.Close();
        }
    }
}
