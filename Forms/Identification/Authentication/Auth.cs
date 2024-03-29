﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ASI.Forms.Identification.Authentication
{
    public partial class Auth : Form
    {
        private string _passUserDB;
        private int _errorCounter = 0;

        public Auth()
        {
            InitializeComponent();

        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
               
                //Чистим поле для вывода ошибок
                ErrorLabel.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (CheckPassBox.Checked)
                {
                    case (true):
                        PassTextBox.UseSystemPasswordChar = false;
                        break;
                    case (false):
                        PassTextBox.UseSystemPasswordChar = true;
                        break;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.ConnectionForMySQL.DB.Server = Properties.Settings.Default.Server;
                DataBase.ConnectionForMySQL.DB.Port = Properties.Settings.Default.Port;
                DataBase.ConnectionForMySQL.DB.Username = Properties.Settings.Default.Username;
                DataBase.ConnectionForMySQL.DB.Password = Properties.Settings.Default.Password;
                DataBase.ConnectionForMySQL.DB.Database = Properties.Settings.Default.Database;
                //Инициализируем классы
                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                //Проверка есть ли такой пользователь или нет
                MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser, db.getConnection()); //Сравниваем значения из БД с теми что ввел пользователь
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Function.SHA256.hash(PassTextBox.Text);

                adapter.SelectCommand = command; //вспомощью адаптера делаем запрос в бд
                adapter.Fill(table);  // вспомощью адаптера заполняем виртуальную таблицу

                if (table.Rows.Count > 0)
                {
                    db.openConnection();
                    //Заносим пароль в переменную passUserDB
                    MySqlCommand _passUsers = new MySqlCommand
                    {
                        CommandText = DataBase.Scripts.ScriptMySql.script_SelectUserPassDB //Делаем выборку из БД, берем пароль из таблицы users, где login будет идентичен с тем что ввел пользователь
                    };
                    _passUsers.Parameters.Add("@uPL", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                    _passUsers.Connection = db.getConnection();

                    var PassUsersDB = _passUsers.ExecuteReader();
                    while (PassUsersDB.Read()) { _passUserDB = PassUsersDB.GetString(0); }; //Перебираем все значения
                    db.closeConnection();

                    //DataBase.Entity.Identification.DB_Auth.PasswordAuth = PassUsersDB;

                    //Сравниваем пароли, из БД с тем что ввели
                    if (Function.SHA256.hash(PassTextBox.Text) == _passUserDB)
                    {
                        _errorCounter = 0;
                        AuthButton.Enabled = true;

                        //Заносим эл. почту в глобальную переменную авторизированного пользователя
                        DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers = LoginTextBox.Text;

                        // Внести поправки для значения null в цикле (выдает ошибку что нельзя записать)

                        //Заносим профиль пользователя в переменную role
                        db.openConnection();
                        var _roleUsers = new MySqlCommand();
                        _roleUsers.CommandText = DataBase.Scripts.ScriptMySql.script_SelectUserRole; //Делаем выборку из БД, берем роль из таблицы users, где login будет идентичен с тем что ввел пользователь
                        _roleUsers.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginTextBox.Text;
                        _roleUsers.Connection = db.getConnection();

                        var RoleUsersDB = _roleUsers.ExecuteReader();
                        while (RoleUsersDB.Read()) { DataBase.Entity.Identification.DB_Users.RoleUsersForRole = RoleUsersDB.GetString(0); }; //Перебираем все значения
                        db.closeConnection();

                        //MessageBox.Show("Ваш уровень доступа: " + DataBase.Entity.Identification.DB_Users.RoleUsersForRole);


                        //Переход на главную форму
                        Main.ASI asi = new Main.ASI();
                        this.Hide();
                        asi.ShowDialog();
                        this.Close();

                    }
                    else //Если пароль неверный, больше 5 раз, блокируем вход
                    {
                        ErrorLabel.Text = "Неправильный логин или пароль";
                        _errorCounter++;
                        if (_errorCounter >= 5) { AuthButton.Enabled = false; ErrorLabel.Text = "ПРЕВЫШЕН ЛИМИТ ПОПЫТОК"; MessageBox.Show("Вы превысили лимит попыток! Вход заблокирован, обратитесь к системному администратору."); }
                    }

                }
                else if ((LoginTextBox.Text == "") || (PassTextBox.Text == ""))
                {
                    ErrorLabel.Text = "Введите логин и пароль";
                }
                else //Если логин неверный, больше 5 раз, блокируем вход
                {
                    ErrorLabel.Text = "Неправильный логин или пароль";
                    _errorCounter++;
                    if (_errorCounter >= 5) { AuthButton.Enabled = false; ErrorLabel.Text = "ПРЕВЫШЕН ЛИМИТ ПОПЫТОК"; MessageBox.Show("Вы превысили лимит попыток! Вход заблокирован, обратитесь к системному администратору."); }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RegsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Registration.Regs regs = new Registration.Regs();
                regs.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ForgotPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // MessageBox.Show("Данная функция находится в разработке!\n" + "При возникновении проблемы обратитесь к системному администратору!");
                Forms.Connection.ConnDB connDB = new Connection.ConnDB();
                connDB.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
