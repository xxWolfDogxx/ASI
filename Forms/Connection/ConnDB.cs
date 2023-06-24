using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASI.Forms.Connection
{
    public partial class ConnDB : Form
    {
        private readonly string server   = Properties.Settings.Default.Server;
        private readonly string port     = Properties.Settings.Default.Port;
        private readonly string username = Properties.Settings.Default.Username;
        private readonly string password = Properties.Settings.Default.Password;
        private readonly string database = Properties.Settings.Default.Database;


        public ConnDB()
        {
            InitializeComponent();
            DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
        }

        private void ConnDB_Load(object sender, EventArgs e)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["asi"].ConnectionString;
            ServerTextBox.Text = server;
            PortTextBox.Text = port;
            LoginTextBox.Text = username;
            PassTextBox.Text = password;
            NameTextBox.Text = database;
        }

        private void SaveConnBut_Click(object sender, EventArgs e)
        {
            var temp = 0;

            if (ServerTextBox.Text != server)
            {
                Properties.Settings.Default.Server = ServerTextBox.Text;
                temp = 1;
            }
            if (PortTextBox.Text != port)
            {
                Properties.Settings.Default.Port = PortTextBox.Text;
                temp = 1;
            }
            if (LoginTextBox.Text != username)
            {
                Properties.Settings.Default.Username = LoginTextBox.Text;
                temp = 1;
            }
            if (PassTextBox.Text != password)
            {
                Properties.Settings.Default.Password = PassTextBox.Text;
                temp = 1;
            }
            if (NameTextBox.Text != database)
            {
                Properties.Settings.Default.Database = NameTextBox.Text;
                temp = 1;
            }

            if (temp == 1)
            {
                Properties.Settings.Default.Save();
                MessageBox.Show("Файл конфигурации обновлен!");

            }
            else //MessageBox.Show("Ничего не было сохранено, т.к. не было изменений");

            DataBase.ConnectionForMySQL.DB.Server = ServerTextBox.Text;
            DataBase.ConnectionForMySQL.DB.Port = PortTextBox.Text;
            DataBase.ConnectionForMySQL.DB.Database = NameTextBox.Text;
            DataBase.ConnectionForMySQL.DB.Username = LoginTextBox.Text;
            DataBase.ConnectionForMySQL.DB.Password = PassTextBox.Text;

        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
