﻿using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ASI.Forms.Modification.CartrigeType
{
    public partial class ModCartrigeType : Form
    {
        private static bool refillBool;
        internal static string type;
        internal static string typeDB;
        public ModCartrigeType()
        {
            InitializeComponent();

            RefillComBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void ModCartrigeType_Load(object sender, EventArgs e)
        {
            try
            {
                RefillComBox.Items.Add("Да");
                RefillComBox.Items.Add("Нет");

                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        LogoLabel.Text = "Изменение аудитории";
                        AddFillBut.Visible = false;
                        ModFillBut.Visible = true;
                        break;
                    case ("Добавить"):
                        LogoLabel.Text = "Добавление аудитории";

                        AddFillBut.Visible = true;
                        ModFillBut.Visible = false;
                        break;
                }

                IdTypeTextBox.Text = Convert.ToString(DataBase.Entity.CartrigeType.CartrigeType.Id);
                TypeTextBox.Text = DataBase.Entity.CartrigeType.CartrigeType.Name;

                if (DataBase.Entity.CartrigeType.CartrigeType.Refill == true)
                {
                    RefillComBox.SelectedItem = "Да";
                }
                else if (DataBase.Entity.CartrigeType.CartrigeType.Refill == false)
                {
                    RefillComBox.SelectedItem = "Нет";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddFillBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(RefillComBox.SelectedItem) == "Да")
                {
                    var _convertStringToBoolRefill = true;
                    refillBool = _convertStringToBoolRefill;

                }
                else if (Convert.ToString(RefillComBox.SelectedItem) == "Нет")
                {
                    var _convertStringToBoolRefill = false;
                    refillBool = _convertStringToBoolRefill;
                }

                DB db = new DB();

                MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertType_ModCartrigeType, db.getConnection());
                AddCom.Parameters.Add("@type", MySqlDbType.VarChar).Value = TypeTextBox.Text;
                AddCom.Parameters.Add("@refill", MySqlDbType.UByte).Value = refillBool;

                type = TypeTextBox.Text;

                // Проверка на повторного пользователя
                if (Function.isCartrigeType.isCartTypeExists())
                {
                    return;
                }
                else
                {
                    db.openConnection();
                    if (AddCom.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Заявка Добавлена");
                        //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                        Hide();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                    db.closeConnection(); //Закрываем подключение к БД
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ModFillBut_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToString(RefillComBox.SelectedItem) == "Да")
                {
                    var _convertStringToBoolRefill = true;
                    refillBool = _convertStringToBoolRefill;

                }
                else if (Convert.ToString(RefillComBox.SelectedItem) == "Нет")
                {
                    var _convertStringToBoolRefill = false;
                    refillBool = _convertStringToBoolRefill;
                }

                DB db = new DB();

                //Заносим в 
                db.openConnection(); // Открываем подключение к БД
                var ConsumableDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
                ConsumableDBCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectConsumableDB_ModCartrigeType; // Запрос на какие либо даные
                ConsumableDBCom.Connection = db.getConnection(); //Отправляем запрос
                ConsumableDBCom.Parameters.Add("@idType", MySqlDbType.Int32).Value = IdTypeTextBox.Text;

                var consumableDB = ConsumableDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
                while (consumableDB.Read()) { typeDB = (consumableDB.GetString(0)); }; // Перебираем данные занося их в переменную
                db.closeConnection(); // Закрываем подключение к БД 

                MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateType_ModCartrigeType, db.getConnection());
                AddCom.Parameters.Add("@idType", MySqlDbType.Int32).Value = Convert.ToInt32(IdTypeTextBox.Text);
                AddCom.Parameters.Add("@type", MySqlDbType.VarChar).Value = TypeTextBox.Text;
                AddCom.Parameters.Add("@refill", MySqlDbType.UByte).Value = refillBool;

                type = TypeTextBox.Text;

                // Проверка на повторного пользователя
                db.openConnection();
                if (Function.isCartrigeType.isCartTypeExists() == true)
                {
                    return;
                }
                else if (Function.isCartrigeType.isCartTypeExists() == false)
                {
                    if (AddCom.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Запись изменина");
                        //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                        Hide();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                }
                else { MessageBox.Show("Поправить - разработчику\nModCartrigeType, проверка на повторы при изменении записи"); }
                db.closeConnection();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void ModCartrigeType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
