using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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

            //
            //Блокируем ввод от руки в combox
            //
            ReadyConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RoomConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WriteoffConsumableComBox.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void ModCartrige_Load(object sender, EventArgs e)
        {
            try
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
                mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRoom_ModConsumable, db.getConnection());
                mySql_dataAdapter.Fill(tableRoom);

                //ModelComBox insert iteam
                mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel_ModConsumable, db.getConnection());
                mySql_dataAdapter.Fill(tableModel);

                //ModelComBox insert iteam
                mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrigeType_ModConsumable, db.getConnection());
                mySql_dataAdapter.Fill(tableType);

                //Source for ComBox
                RoomConsumableComBox.DataSource = tableRoom;
                ModelConsumableComBox.DataSource = tableModel;
                TypeConsumableComBox.DataSource = tableType;

                //Отбираем все значения что хотим показать и те что хотим скрыть
                RoomConsumableComBox.DisplayMember = "name_room";
                RoomConsumableComBox.ValueMember = "id_room";

                ModelConsumableComBox.DisplayMember = "name_model";
                ModelConsumableComBox.ValueMember = "id_model";

                TypeConsumableComBox.DisplayMember = "name_type";
                TypeConsumableComBox.ValueMember = "id_type";

                WriteoffConsumableComBox.Items.Add("Да");
                WriteoffConsumableComBox.Items.Add("Нет");

                ReadyConsumableComBox.Items.Add("Да");
                ReadyConsumableComBox.Items.Add("Нет");

                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        LogoLabel.Text = "Изменение расходника";
                        AddCartrigeBut.Visible = false;
                        ModCartrigeBut.Visible = true;

                        label1.Visible= false;
                        label2.Visible= false;
                        label3.Visible= false;

                        Code00ConsumTextBox.Visible = false;
                        Code99ConsumTextBox.Visible = false;

                        WriteoffGr.Visible = true;
                        ReadyGr.Visible = true;
                        this.Width = 600;
                        this.Height = 937;

                        //
                        //Заносим в поля данные
                        //
                        IdСonsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Id.ToString();
                        NameСonsumableTextBox.Text = DataBase.Entity.Consumable.Consumable.Name;
                        CodeAAConsumTextBox.Text = DataBase.Entity.Consumable.Consumable.Code;
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

                        WriteoffGr.Visible = false;
                        ReadyGr.Visible = false;

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;

                        Code00ConsumTextBox.Visible = true;
                        Code99ConsumTextBox.Visible = true;

                        this.Width = 600;
                        this.Height = 800;

                        //
                        //Заносим в поля данные
                        //
                        IdСonsumableTextBox.Text = null;
                        NameСonsumableTextBox.Text = null;
                        CodeAAConsumTextBox.Text = null;
                        RoomConsumableComBox.SelectedValue = 0;
                        NoteConsumableTextBox.Text = null;
                        ModelConsumableComBox.SelectedValue = 0;
                        TypeConsumableComBox.SelectedValue = 0;

                        break;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddCartrigeBut_Click(object sender, EventArgs e)
        {

            try
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


                db.openConnection();
                //----------------------------------------------------------------------------------------------------------------------------
                var _codeAA = CodeAAConsumTextBox.Text;
                int _code00 = Convert.ToInt32(Code00ConsumTextBox.Text);
                int _code99 = 0;
                if (Code99ConsumTextBox.MaskFull)
                {
                    MessageBox.Show("fffff");

                    _code99 = Convert.ToInt32(Code99ConsumTextBox.Text);
                }
                else
                {
                    _code99 = 0;
                }

                if (_code99 != 0)
                {
                    while (_code00 <= _code99)
                    {
                        MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertConsumable_ModConsumable, db.getConnection());

                        //Заносим данные в запрос
                        AddCom.Parameters.Add("@nameConsumable", MySqlDbType.VarChar).Value = NameСonsumableTextBox.Text;

                        AddCom.Parameters.Add("@codeConsumable", MySqlDbType.VarChar).Value = CodeAAConsumTextBox.Text.ToUpper() + "-" + _code00;
                        _code00++;

                        AddCom.Parameters.Add("@buy_dateConsumable", MySqlDbType.Date).Value = DateConsumableDatePicker.Value;
                        //AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = writeoffBool;
                        AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                        AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
                        //AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = readyBool;
                        AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                        AddCom.Parameters.Add("@setupConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                        AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedValue);
                        AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedValue);
                        AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedValue);

                        db.closeConnection(); //Закрываем подключение к БД


                        numCartrige = CodeAAConsumTextBox.Text;

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
                                //MessageBox.Show("Расходник добавлен");
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

                }
                else
                {
                                MessageBox.Show("ffffgggghhhh");

                    MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertConsumable_ModConsumable, db.getConnection());

                    //Заносим данные в запрос
                    AddCom.Parameters.Add("@nameConsumable", MySqlDbType.VarChar).Value = NameСonsumableTextBox.Text;
                    AddCom.Parameters.Add("@codeConsumable", MySqlDbType.VarChar).Value = CodeAAConsumTextBox.Text.ToUpper() + "-" + _code00;                
                    AddCom.Parameters.Add("@buy_dateConsumable", MySqlDbType.Date).Value = DateConsumableDatePicker.Value;
                    //AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = writeoffBool;
                    AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                    AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
                    //AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = readyBool;
                    AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                    AddCom.Parameters.Add("@setupConsumable", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                    AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedValue);
                    AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedValue);
                    AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedValue);

                    db.closeConnection(); //Закрываем подключение к БД


                    numCartrige = CodeAAConsumTextBox.Text;

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
                            //MessageBox.Show("Расходник добавлен");
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
                //----------------------------------------------------------------------------------------------------------------------------

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ModCartrigeBut_Click(object sender, EventArgs e)
        {
            try
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
                ConsumableDBCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectConsumableDB_ModConsumable; // Запрос на какие либо даные
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
                AddCom.Parameters.Add("@codeConsumable", MySqlDbType.VarChar).Value = CodeAAConsumTextBox.Text;
                AddCom.Parameters.Add("@buy_dateConsumable", MySqlDbType.Date).Value = DateConsumableDatePicker.Value;
                AddCom.Parameters.Add("@writeoffConsumable", MySqlDbType.UByte).Value = writeoffBool;
                AddCom.Parameters.Add("@noteConsumable", MySqlDbType.VarChar).Value = NoteConsumableTextBox.Text;
                AddCom.Parameters.Add("@readyConsumable", MySqlDbType.UByte).Value = readyBool;
                AddCom.Parameters.Add("@typeConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(TypeConsumableComBox.SelectedValue);
                AddCom.Parameters.Add("@roomConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(RoomConsumableComBox.SelectedValue);
                AddCom.Parameters.Add("@modelConsumable", MySqlDbType.Int32).Value = Convert.ToInt32(ModelConsumableComBox.SelectedValue);

                db.closeConnection(); //Закрываем подключение к БД

                numCartrige = CodeAAConsumTextBox.Text;

                db.openConnection();
                if (Function.isCartrigeExists.isCarExists() == true)
                {
                    return;
                }
                else if (Function.isCartrigeExists.isCarExists() == false)
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
                else { MessageBox.Show("Поправить - разработчику\nModCartrige, проверка на повторы при изменении записи"); }
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

    }
}
