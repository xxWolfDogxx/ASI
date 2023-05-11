using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASI.Forms.Identification.Registration
{
    public partial class Regs : Form
    {
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
                //Инициализируем классы
                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();

                //Заносим эл. почту в глобальную переменную
                DataBase.Entity.Identification.DB_Users.EmailUsers = EmailTextBox.Text;


                if ((FIOTextBox.Text != "") && (PhoneMaskTextBox.Text != null) && (EmailTextBox.Text != ""))
                {
                    // Проверка на повторного пользователя
                    if (Function.isUsersExists.IsUsersExist())
                    {
                        MessageBox.Show("Пользователь с такой эл. почтой уже существует!");
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
                        commandUsers.Parameters.Add("@role", MySqlDbType.VarChar).Value = "ROLE_USER";

                        if (PassTextBox.Text == PassRepitTextBox.Text && PassTextBox.Text != "" && PassRepitTextBox.Text != "")
                        {
                            commandUsers.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Function.SHA256.hash(PassTextBox.Text);

                            db.openConnection();
                            if (commandUsers.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Вы успешно зарегистрировались в системе. \n" + "Поздравляем!");
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
