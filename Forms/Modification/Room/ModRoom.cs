﻿using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ASI.Forms.Modification.Room
{
    public partial class ModRoom : Form
    {

        internal static string Room;
        internal static string RoomDB;
        public ModRoom()
        {
            InitializeComponent();
            RoomTextBox.Focus();
        }

        private void ModAudit_Load(object sender, EventArgs e)
        {

            try
            {
                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        LogoLabel.Text = "Изменение аудитории";
                        AddAuditBut.Visible = false;
                        ModAuditBut.Visible = true;
                        break;
                    case ("Добавить"):
                        LogoLabel.Text = "Добавление аудитории";

                        AddAuditBut.Visible = true;
                        ModAuditBut.Visible = false;
                        break;
                }

                IdRoomTextBox.Text = Convert.ToString(DataBase.Entity.Audit.Audiences.Id);
                RoomTextBox.Text = DataBase.Entity.Audit.Audiences.Name;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddAuditBut_Click(object sender, EventArgs e)
        {
            try
            {
                Room = RoomTextBox.Text;
                RoomDB = null;

                DB db = new DB();

                MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertRoom_ModRoom, db.getConnection());
                AddCom.Parameters.Add("@room", MySqlDbType.VarChar).Value = RoomTextBox.Text;

                // Проверка на повторную аудиторию
                if (Function.isAudiencesExists.isAuditExists())
                {
                    return;
                }
                else
                {
                    db.openConnection();
                    if (AddCom.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Аудитория добавлена");
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

        private void ModAuditBut_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                //Заносим в 
                db.openConnection(); // Открываем подключение к БД
                var RoomDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
                RoomDBCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectRoomDB_ModRoom; // Запрос на какие либо даные
                RoomDBCom.Connection = db.getConnection(); //Отправляем запрос
                RoomDBCom.Parameters.Add("@idRoom", MySqlDbType.Int32).Value = IdRoomTextBox.Text;

                var roomDB = RoomDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
                while (roomDB.Read()) { RoomDB = (roomDB.GetString(0)); }; // Перебираем данные занося их в переменную
                db.closeConnection(); // Закрываем подключение к БД

                MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateRoom_ModRoom, db.getConnection());
                AddCom.Parameters.Add("@idRoom", MySqlDbType.VarChar).Value = IdRoomTextBox.Text;
                AddCom.Parameters.Add("@room", MySqlDbType.VarChar).Value = RoomTextBox.Text;

                Room = RoomTextBox.Text;

                db.openConnection();
                if (Function.isAudiencesExists.isAuditExists() == true)
                {
                    return;
                }
                else if (Function.isAudiencesExists.isAuditExists() == false)
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
                else { MessageBox.Show("Поправить - разработчику\nModRoom, проверка на повторы при изменении записи"); }
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

        private void ModRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
