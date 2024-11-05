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
    public partial class FormMain : Form
    {
        FormAdmin formAdmin = new FormAdmin();
        FormCook formCook = new FormCook();
        FormWaiter formWaiter = new FormWaiter();
        

        public FormMain()
        {
            InitializeComponent();
            AddOwnedForm(formAdmin);
            AddOwnedForm(formCook);
            AddOwnedForm(formWaiter);
        }

        private string getRole(string role,DataTable table)
        {
            var s = table.Rows[0]["role"];
            return s.ToString();
        }
        private char functionSwitch(string roleUser)
        {
            char s = ' ';
            if (roleUser == "Администратор") s = 'А';
            if (roleUser == "Повар") s = 'П';
            if (roleUser == "Официант") s = 'О';
            return s;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLoginUser.Text;
            string passUser = textBoxPassUser.Text;
            string roleUser = null;
            char forSwitch = ' ';
            DB db = new DB();

            DataTable table = new DataTable();
            //DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uLogin AND `password`=@uPass",db.getConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                roleUser = getRole(roleUser, table);
                forSwitch = functionSwitch(roleUser);
                switch (forSwitch) 
                {
                    case 'А':
                        formAdmin.Show();
                        this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                    break;
                    case 'П':
                        formCook.Show();
                        this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                        break;
                    case 'О':
                        formWaiter.Show();
                        this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                        break;
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void buttonEnterUser_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLoginUser.Text;
            string passUser = textBoxPassUser.Text;
            string roleUser = "";
            char forSwitch = ' ';
            DB db = new DB();

            DataTable table = new DataTable();
            //DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uLogin AND `password`=@uPass", db.getConnection());
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            roleUser = getRole(roleUser, table);
            forSwitch = functionSwitch(roleUser);

            if (table.Rows.Count > 0)
            {
                switch (forSwitch)
                {
                    case 'А':
                        formAdmin.Show();
                        this.Hide();
                        //this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                        break;
                    case 'П':
                        formCook.Show();
                        this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                        break;
                    case 'О':
                        formWaiter.Show();
                        this.Visible = false;
                        textBoxLoginUser.Text = "";
                        textBoxPassUser.Text = "";
                        break;
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
