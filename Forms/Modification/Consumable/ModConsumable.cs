using ASI.DataBase.ConnectionForMySQL;
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

namespace ASI.Forms.Modification.Consumable
{
    public partial class ModConsumable : Form
    {
        internal static string numCartrige;
        internal static string numCartrigeDB;
        private static bool writeoffBool;
        private static bool readyBool;
        public ModConsumable()
        {
            InitializeComponent();
        }

        private void AddCartrigeBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (Convert.ToString(WriteoffConsumableComBox.SelectedItem) == "Да") 
            { 
                var _convertStringToBoolWriteoff = true;
                writeoffBool = _convertStringToBoolWriteoff;

            }
            else
            {
                var _convertStringToBoolWriteoff = false;
                writeoffBool = _convertStringToBoolWriteoff;
            }

            if (Convert.ToString(ReadyConsumableComBox.SelectedItem) == "Установлен")
            {
                var _convertStringToBoolReady = true;
                readyBool = _convertStringToBoolReady;

            }
            else
            {
                var _convertStringToBoolReady = false;
                readyBool = _convertStringToBoolReady;
            }

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertConsumable_ModConsumable, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@nameConsumable", MySqlDbType.VarChar).Value = NameСonsumableTextBox.Text;
            AddCom.Parameters.Add("@codeConsumable", MySqlDbType.VarChar).Value = CodeСonsumableTextBox.Text;
            AddCom.Parameters.Add("@buy_dateConsumable", MySqlDbType.Date).Value = DateConsumableDatePicker.Value;
            AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.VarChar).Value = writeoffBool;
            AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
            AddCom.Parameters.Add("@readyConsumable", MySqlDbType.VarChar).Value = readyBool;
            AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedItem);
            AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedItem);
            AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedItem);

            db.closeConnection(); //Закрываем подключение к БД

            numCartrige = CodeСonsumableTextBox.Text;

            // Проверка на повторного пользователя
            if (Function.isCartrigeExists.isCarExists())
            {
                return;
            }
            else
            {
                db.openConnection();
                if (AddCom.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Заявка Добавлена");
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
    

        private void ModCartrige_Load(object sender, EventArgs e)
        {
            DB db = new DB(); //Объявляем подключение к классу "Подключения БД"

            WriteoffConsumableComBox.Items.Add("Да");
            WriteoffConsumableComBox.Items.Add("Нет");

            ReadyConsumableComBox.Items.Add("Свободен");
            ReadyConsumableComBox.Items.Add("Установлен");



            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение расходника";
                    AddCartrigeBut.Visible = false;
                    ModCartrigeBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление расходника";
                    AddCartrigeBut.Visible = true;
                    ModCartrigeBut.Visible = false;
                    break;
            }

            //
            //Блокируем ввод от руки в combox
            //
           ReadyConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           TypeConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           RoomConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           ModelConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           WriteoffConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;         

            
        }

        private void ModCartrigeBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (Convert.ToString(WriteoffConsumableComBox.SelectedItem) == "Да")
            {
                var _convertStringToBoolWriteoff = true;
                writeoffBool = _convertStringToBoolWriteoff;

            }
            else
            {
                var _convertStringToBoolWriteoff = false;
                writeoffBool = _convertStringToBoolWriteoff;
            }

            if (Convert.ToString(ReadyConsumableComBox.SelectedItem) == "Установлен")
            {
                var _convertStringToBoolReady = true;
                readyBool = _convertStringToBoolReady;

            }
            else
            {
                var _convertStringToBoolReady = false;
                readyBool = _convertStringToBoolReady;
            }

            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var ConsumableDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            ConsumableDBCom.CommandText = "Select code From cartrige Where id = @idConsumable"; // Запрос на какие либо даные
            ConsumableDBCom.Connection = db.getConnection(); //Отправляем запрос
            ConsumableDBCom.Parameters.Add("@idConsumable", MySqlDbType.Int32).Value = IdСonsumableTextBox.Text;

            var consumableDB = ConsumableDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (consumableDB.Read()) { numCartrigeDB = (consumableDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateConsumable_ModConsumable, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(IdСonsumableTextBox.Text);
            AddCom.Parameters.Add("@nameConsumable", MySqlDbType.VarChar).Value = NameСonsumableTextBox.Text;
            AddCom.Parameters.Add("@codeConsumable", MySqlDbType.VarChar).Value = CodeСonsumableTextBox.Text;
            AddCom.Parameters.Add("@buy_dateConsumable", MySqlDbType.Date).Value = DateConsumableDatePicker.Value;
            AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.VarChar).Value = writeoffBool;
            AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
            AddCom.Parameters.Add("@readyConsumable", MySqlDbType.VarChar).Value = readyBool;
            AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedItem);
            AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedItem);
            AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedItem);

            db.closeConnection(); //Закрываем подключение к БД

            numCartrige = CodeСonsumableTextBox.Text;

            db.openConnection();
            if (Function.isCartrigeExists.isCarExists() == true)
            {
                return;
            }
            else if (Function.isCartrigeExists.isCarExists() == false)
            {
                if (AddCom.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись изменина");
                    //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                    Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else { MessageBox.Show("Поправить - разработчику\nModCartrige, проверка на повторы при изменении записи"); }
            db.closeConnection();

        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
