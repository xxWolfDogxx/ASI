using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ASI.Forms.Identification.Registration
{
    public partial class Regs : Form
    {

        internal static string numEmail;
        internal static string numEmailDB;
        internal static string numPhone;
        internal static string numPhoneDB;

        public Regs()
        {
            InitializeComponent();
        }

        private void CheckPassBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (CheckPassBox.Checked)
                {
                    case (true):
                        PassTextBox.UseSystemPasswordChar = false;
                        PassRepitTextBox.UseSystemPasswordChar = false;
                        break;
                    case (false):
                        PassTextBox.UseSystemPasswordChar = true;
                        PassRepitTextBox.UseSystemPasswordChar = true;
                        break;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Regs_Load(object sender, EventArgs e)
        {
            try
            {
                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter();
                DataTable tableRole = new DataTable();
                mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRole_ASI, db.getConnection());
                mySql_dataAdapter.Fill(tableRole);
                RoleComBox.DataSource = tableRole;
                RoleComBox.DisplayMember = "Роль";
                RoleComBox.ValueMember = "ID";



                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        LogoLabel.Text = "Изменение пользователя";
                        RegsBut.Text = "Внести изменения";

                        FIOTextBox.Text = DataBase.Entity.Identification.DB_Users.FullnameUsers;
                        DateOfBirthDateTimePicker.Text = DataBase.Entity.Identification.DB_Users.DateOfBirthUsers.ToString();
                        PhoneMaskTextBox.Text = DataBase.Entity.Identification.DB_Users.PhoneUsers;
                        EmailTextBox.Text = DataBase.Entity.Identification.DB_Users.EmailUsers;
                        PassTextBox.Text = DataBase.Entity.Identification.DB_Users.PassUser;
                        RoleComBox.SelectedValue = DataBase.Entity.Identification.DB_Users.RoleUsersForRole;
                        PassRepitTextBox.Text = DataBase.Entity.Identification.DB_Users.PassUser;



                        break;
                    case ("Добавить"):
                        LogoLabel.Text = "Добавление пользователя";
                        RegsBut.Text = "Добавить пользователя";

                        FIOTextBox.Text = null;
                        DateOfBirthDateTimePicker.Text = null;
                        PhoneMaskTextBox.Text = null;
                        EmailTextBox.Text = null;
                        PassTextBox.Text = null;
                        PassRepitTextBox.Text = null;

                        break;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegsBut_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();

                numEmail = EmailTextBox.Text;
                numPhone = PhoneMaskTextBox.Text;

                db.openConnection(); // Открываем подключение к БД
                var EmailDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
                EmailDBCom.CommandText = "SELECT email FROM users WHERE id = @idE"; // Запрос на какие либо даные
                EmailDBCom.Connection = db.getConnection(); //Отправляем запрос
                EmailDBCom.Parameters.Add("@idE", MySqlDbType.Int32).Value = DataBase.Entity.Identification.DB_Users.IdUsers;

                var emailDB = EmailDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
                while (emailDB.Read()) { numEmailDB = (emailDB.GetString(0)); }; // Перебираем данные занося их в переменную
                db.closeConnection(); // Закрываем подключение к БД 

                db.openConnection(); // Открываем подключение к БД
                var PhoneDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
                PhoneDBCom.CommandText = "SELECT phone FROM users WHERE id = @idP"; // Запрос на какие либо даные
                PhoneDBCom.Connection = db.getConnection(); //Отправляем запрос
                PhoneDBCom.Parameters.Add("@idP", MySqlDbType.Int32).Value = DataBase.Entity.Identification.DB_Users.IdUsers;

                var phoneDB = PhoneDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
                while (phoneDB.Read()) { numPhoneDB=(phoneDB.GetString(0)); }; // Перебираем данные занося их в переменную
                db.closeConnection(); // Закрываем подключение к БД 

                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        //Инициализируем классы

                        //Заносим эл. почту в глобальную переменную
                        DataBase.Entity.Identification.DB_Users.EmailUsers = EmailTextBox.Text;



                        if ((FIOTextBox.Text != "") && (PhoneMaskTextBox.Text != null) && (EmailTextBox.Text != ""))
                        {
                            // Проверка на повторного пользователя


                            //Заносим данные в таблицу users 
                            MySqlCommand commandUsers = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateUser, db.getConnection());
                            commandUsers.Parameters.Add("@id", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Users.IdUsers;
                            commandUsers.Parameters.Add("@fio", MySqlDbType.VarChar).Value = FIOTextBox.Text;
                            commandUsers.Parameters.Add("@dOb", MySqlDbType.Date).Value = DateOfBirthDateTimePicker.Value;
                            commandUsers.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneMaskTextBox.Text;
                            commandUsers.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailTextBox.Text;
                            commandUsers.Parameters.Add("@role", MySqlDbType.Int32).Value = RoleComBox.SelectedValue;

                            if (PassTextBox.Text == PassRepitTextBox.Text && PassTextBox.Text != "" && PassRepitTextBox.Text != "")
                            {
                                commandUsers.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Function.SHA256.hash(PassTextBox.Text);
                                if (Function.isUsersExists.IsUsersExist() == true)
                                {
                                    //MessageBox.Show("Пользователь с такой эл. почтой уже существует!");
                                    return;
                                }
                                else
                                {
                                    db.openConnection();
                                    if (commandUsers.ExecuteNonQuery() == 1)
                                    {
                                        //MessageBox.Show("Вы успешно зарегистрировались в системе. \n" + "Поздравляем!");
                                        PasswordGroupBox.BackColor = Color.Silver;
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы не смогли зарегистрироваться \n" + "Обратитесь к системному администратору!");
                                    }
                                    db.closeConnection();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Пароль не совпадает!");
                                PasswordGroupBox.BackColor = Color.Brown;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!");
                        }

                        break;
                    case ("Добавить"):

                        //Инициализируем классы

                        //Заносим эл. почту в глобальную переменную
                        DataBase.Entity.Identification.DB_Users.EmailUsers = EmailTextBox.Text;


                        if ((FIOTextBox.Text != "") && (PhoneMaskTextBox.Text != null) && (EmailTextBox.Text != ""))
                        {
                            // Проверка на повторного пользователя
                            if (Function.isUsersExists.IsUsersExist())
                            {
                                //MessageBox.Show("Пользователь с такой эл. почтой уже существует!");
                                return;
                            }
                            else
                            {
                                //Заносим данные в таблицу users 
                                MySqlCommand commandUsers = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertUser, db.getConnection());
                                commandUsers.Parameters.Add("@fio", MySqlDbType.VarChar).Value = FIOTextBox.Text;
                                commandUsers.Parameters.Add("@dOb", MySqlDbType.Date).Value = DateOfBirthDateTimePicker.Value;
                                commandUsers.Parameters.Add("@phone", MySqlDbType.VarChar).Value = PhoneMaskTextBox.Text;
                                commandUsers.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailTextBox.Text;
                                commandUsers.Parameters.Add("@role", MySqlDbType.Int32).Value = RoleComBox.SelectedValue;

                                if (PassTextBox.Text == PassRepitTextBox.Text && PassTextBox.Text != "" && PassRepitTextBox.Text != "")
                                {
                                    commandUsers.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Function.SHA256.hash(PassTextBox.Text);

                                    db.openConnection();
                                    if (commandUsers.ExecuteNonQuery() == 1)
                                    {
                                        //MessageBox.Show("Вы успешно зарегистрировались в системе. \n" + "Поздравляем!");
                                        PasswordGroupBox.BackColor = Color.Silver;
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы не смогли зарегистрироваться \n" + "Обратитесь к системному администратору!");
                                    }
                                    db.closeConnection();
                                }
                                else
                                {
                                    MessageBox.Show("Пароль не совпадает!");
                                    PasswordGroupBox.BackColor = Color.Brown;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!");
                        }

                        break;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FIOTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод только букв русского алфавита
            char l = e.KeyChar;
            if ((l < 'А' || l > 'Я') && (l < 'а' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод только букв английского алфавита
            char l = e.KeyChar;
            char number = e.KeyChar;
            if (((l < 'A' || l > 'Z') && (l < 'a' || l > 'z') && l != '\b' && l != '.' && l != '@') && (!Char.IsDigit(number) && number != 8 && number != 44))
            {
                e.Handled = true;
            }
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод только букв английского алфавита
            char l = e.KeyChar;
            char number = e.KeyChar;
            if (((l < 'A' || l > 'Z') && (l < 'a' || l > 'z') && l != '\b') && (!Char.IsDigit(number) && number != 8 && number != 44))
            {
                e.Handled = true;
            }
        }

        private void Regs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
