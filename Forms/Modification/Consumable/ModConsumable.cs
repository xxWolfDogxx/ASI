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

            if (Convert.ToString(ReadyConsumableComBox.SelectedItem) == "Да")
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
            AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = writeoffBool;
            AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
            AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = readyBool;
            AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedValue);
            AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedValue);
            AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedValue);

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
                    MessageBox.Show("Расходник добавлен");
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


            //
            //Задаем первичные значения для ComBox
            //
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter();
            DataTable tableRoom = new DataTable();
            DataTable tableModel = new DataTable();
            DataTable tableType = new DataTable();

            //RoomComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRoom, db.getConnection());
            mySql_dataAdapter.Fill(tableRoom);

            //ModelComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel, db.getConnection());
            mySql_dataAdapter.Fill(tableModel);
            
            //ModelComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrigeType, db.getConnection());
            mySql_dataAdapter.Fill(tableType);

            //Source for ComBox
            RoomConsumableComBox.DataSource = tableRoom;
            ModelConsumableComBox.DataSource = tableModel;
            TypeConsumableComBox.DataSource = tableType;

            //Отбираем все значения что хотим показать и те что хотим скрыть
            RoomConsumableComBox.DisplayMember = "name";
            RoomConsumableComBox.ValueMember = "id";

            ModelConsumableComBox.DisplayMember = "name";
            ModelConsumableComBox.ValueMember = "id";
            
            TypeConsumableComBox.DisplayMember = "name";
            TypeConsumableComBox.ValueMember = "id";

            WriteoffConsumableComBox.Items.Add("Да");
            WriteoffConsumableComBox.Items.Add("Нет");

            ReadyConsumableComBox.Items.Add("Да");
            ReadyConsumableComBox.Items.Add("Нет");


            //
            //Блокируем ввод от руки в combox
            //
            ReadyConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           TypeConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           RoomConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           ModelConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
           WriteoffConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;


            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение расходника";
                    AddCartrigeBut.Visible = false;
                    ModCartrigeBut.Visible = true;

                    //
                    //Заносим в поля данные
                    //
                    IdСonsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Id.ToString();
                    NameСonsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Name;
                    CodeСonsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Code;
                    ///MessageBox.Show(DataBase.Entity.Consumable.Consumable.Bay_date.ToString());
                    DateConsumableDatePicker.Value = Convert.ToDateTime(DataBase.Entity.Consumable.Consumable.Bay_date);

                    if (DataBase.Entity.Consumable.Consumable.Writeoff == true)
                    {
                        WriteoffConsumableComBox.SelectedItem = "Да";
                    }
                    else if (DataBase.Entity.Consumable.Consumable.Writeoff == false)
                    {
                        WriteoffConsumableComBox.SelectedItem = "Нет";
                    }

                    RoomConsumableComBox.SelectedValue = DataBase.Entity.Consumable.Consumable.Id_room;
                    NoteConsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Note;

                    if (DataBase.Entity.Consumable.Consumable.Ready == true)
                    {
                        ReadyConsumableComBox.SelectedItem = "Да";
                    }
                    else if (DataBase.Entity.Consumable.Consumable.Ready == false)
                    {
                        ReadyConsumableComBox.SelectedItem = "Нет";
                    }
                    ModelConsumableComBox.SelectedValue = DataBase.Entity.Consumable.Consumable.Id_model;
                    TypeConsumableComBox.SelectedValue = DataBase.Entity.Consumable.Consumable.Id_cartrige_type;


                    break;


                case ("Добавить"):
                    LogoLabel.Text = "Добавление расходника";
                    AddCartrigeBut.Visible = true;
                    ModCartrigeBut.Visible = false;


                    //
                    //Заносим в поля данные
                    //
                    IdСonsumableTextBox.Text = null;
                    NameСonsumableTextBox.Text = null;
                    CodeСonsumableTextBox.Text = null;
                    //DateConsumableDatePicker.Value = ;
                    RoomConsumableComBox.SelectedValue = 0;
                    NoteConsumableTextBox.Text = null;
                    ModelConsumableComBox.SelectedValue = 0;
                    TypeConsumableComBox.SelectedValue = 0;


                    break;
            }
           
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

            if (Convert.ToString(ReadyConsumableComBox.SelectedItem) == "Да")
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
            AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = writeoffBool;
            AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
            AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = readyBool;
            AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedValue);
            AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedValue);
            AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedValue);

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
