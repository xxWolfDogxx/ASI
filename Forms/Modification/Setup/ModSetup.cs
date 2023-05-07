using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ASI.Forms.Modification.Setup
{
    public partial class ModSetup : Form
    {
        public ModSetup()
        {
            InitializeComponent();
        }

        private void ModSetup_Load(object sender, EventArgs e)
        {
            DB db = new DB(); //Объявляем подключение к классу "Подключения БД"

            //
            //Задаем первичные значения для ComBox
            //
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter();
            DataTable tablePrinter = new DataTable();
            DataTable tableCartrige = new DataTable();

            //RoomComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectPrinter_ModSetup, db.getConnection());
            mySql_dataAdapter.Fill(tablePrinter);

            //ModelComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrige_ModSetup, db.getConnection());
            mySql_dataAdapter.Fill(tableCartrige);

            //Source for ComBox
            PrinterSetupComBox.DataSource = tablePrinter;
            CartrigeSetupComBox.DataSource = tableCartrige;

            //Отбираем все значения что хотим показать и те что хотим скрыть
            PrinterSetupComBox.DisplayMember = "name";
            PrinterSetupComBox.ValueMember = "id";
            CartrigeSetupComBox.DisplayMember = "code";
            CartrigeSetupComBox.ValueMember = "id";

            //Блокируем ввод от руки в ComBox
            PrinterSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CartrigeSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение записи";
                    AddSetupBut.Visible = false;
                    ModSetupBut.Visible = true;
                    CartrigeSetupComBox.Enabled = true;
                    endGB.Visible = true;
                    //
                    //Заносим в поля данные
                    //
                    IdSetupTextBox.Text = DataBase.Entity.Setup.Setup.Id.ToString();
                    PrinterSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_printer);
                    CartrigeSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_cartrige);
                    DateStartDatePicker.Text = DataBase.Entity.Setup.Setup.Start;
                    DateEndDatePicker.Text = DataBase.Entity.Setup.Setup.End;
                    NoteSetupTextBox.Text = DataBase.Entity.Setup.Setup.Note;

                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление записи";
                    AddSetupBut.Visible = true;
                    ModSetupBut.Visible = false;
                    CartrigeSetupComBox.Enabled = true;
                    endGB.Visible = false;
                    //
                    //Заносим в поля данные
                    //
                    IdSetupTextBox.Text = DataBase.Entity.Setup.Setup.Id.ToString();
                    PrinterSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_printer);
                    CartrigeSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_cartrige);
                    DateStartDatePicker.Text = DataBase.Entity.Setup.Setup.Start;
                    DateEndDatePicker.Text = DataBase.Entity.Setup.Setup.End;
                    NoteSetupTextBox.Text = DataBase.Entity.Setup.Setup.Note;

                    break;
                case ("Установка"):
                    LogoLabel.Text = "Добавление записи";

                    AddSetupBut.Visible = true;
                    ModSetupBut.Visible = false;

                    //
                    //Заносим в поля данные
                    //
                    IdSetupTextBox.Text = DataBase.Entity.Setup.Setup.Id.ToString();
                    CartrigeSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_cartrige);
                    PrinterSetupComBox.SelectedValue = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_printer);
                    DateStartDatePicker.Text = DataBase.Entity.Setup.Setup.Start;
                    DateEndDatePicker.Text = DataBase.Entity.Setup.Setup.End;
                    NoteSetupTextBox.Text = DataBase.Entity.Setup.Setup.Note;

                    CartrigeSetupComBox.Enabled = false;

                    endGB.Visible = false;

                    break;
                case ("Снятие"):
                    LogoLabel.Text = "Изменение записи";
                    string id_DB = "";
                    string id_printer_DB = "";
                    string id_cartrige_DB = "";
                    string start_DB = "";
                    string end_DB = "";
                    string note_DB = "";

                    AddSetupBut.Visible = false;
                    ModSetupBut.Visible = true;

                    db.openConnection();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `setup` WHERE `id_cartrige` =@idCartrige && `end` is null;", db.getConnection());
                    mySqlCommand.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(DataBase.Entity.Setup.Setup.Id_cartrige);

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable setup = new DataTable();
                    mySqlDataAdapter.Fill(setup);

                    foreach (DataRow row in setup.Rows)
                    {
                        id_DB = row["id"].ToString();
                        id_printer_DB = row["id_printer"].ToString();
                        id_cartrige_DB = row["id_cartrige"].ToString();
                        start_DB = row["start"].ToString();
                        end_DB = row["end"].ToString();
                        note_DB = row["note"].ToString();
                    }

                    if (setup.Rows.Count == 1)
                    {
                        //  
                        //Заносим в поля данные
                        //
                        IdSetupTextBox.Text = id_DB;
                        CartrigeSetupComBox.SelectedValue = id_cartrige_DB;
                        PrinterSetupComBox.SelectedValue = id_printer_DB;
                        DateStartDatePicker.Text = start_DB;
                        DateEndDatePicker.Text = end_DB;
                        NoteSetupTextBox.Text = note_DB;

                        endGB.Visible = true;

                        IdSetupTextBox.Enabled = false;
                        CartrigeSetupComBox.Enabled = false;
                        PrinterSetupComBox.Enabled = false;
                        DateStartDatePicker.Enabled = false;
                        DateEndDatePicker.Enabled = true;
                        NoteSetupTextBox.Enabled = true;

                    }
                    else if (setup.Rows.Count > 1)
                    {
                        MessageBox.Show("Этот картридж установлен одновременно более одного раза\n" +
                            "Произведите поправку в истории установок вручную");
                        this.Close();
                    }
                    else MessageBox.Show("ModSetup Error");
                    db.closeConnection();
                    break;

                default:
                    break;

            }


        }

        private void AddSetupBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertSetup, db.getConnection());
            //Заносим данные в запрос
            AddCom.Parameters.Add("@printerSetup", MySqlDbType.Int32).Value = Convert.ToInt32(PrinterSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@cartrigeSetup", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@dataStartSetup", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateStartDatePicker.Value);
            AddCom.Parameters.Add("@noteSetup", MySqlDbType.VarChar).Value = NoteSetupTextBox.Text;

            MySqlCommand AddCheckSetupCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateSetupCheck_Cartrige, db.getConnection());
            AddCheckSetupCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);

            if (DateEndDatePicker.Checked == false)
            {
                AddCheckSetupCom.Parameters.Add("@setupCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                AddCom.Parameters.AddWithValue("@dataEndSetup", DBNull.Value);

            }
            else
            {
                AddCom.Parameters.AddWithValue("@dataEndSetup", DateEndDatePicker.Value);
                AddCheckSetupCom.Parameters.Add("@setupCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
            }


            db.closeConnection(); //Закрываем подключение к БД


            //Проверка на успешную отправку запроса
            db.openConnection();
            if (AddCom.ExecuteNonQuery() == 1 && AddCheckSetupCom.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Установлен");
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

        private void ModSetupBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateSetup, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@idSetup", MySqlDbType.Int32).Value = Convert.ToInt32(IdSetupTextBox.Text);
            AddCom.Parameters.Add("@printerSetup", MySqlDbType.Int32).Value = Convert.ToInt32(PrinterSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@cartrigeSetup", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@dataStartSetup", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateStartDatePicker.Value);
            AddCom.Parameters.Add("@noteSetup", MySqlDbType.VarChar).Value = NoteSetupTextBox.Text;

            /* MySqlCommand AddCheckSetupCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateSetupCheck_Cartrige, db.getConnection());
             AddCheckSetupCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);*/

            MySqlCommand AddCheckReadyCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateReadyCheck_Cartrige, db.getConnection());
            AddCheckReadyCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);

            if (DateEndDatePicker.Checked == false)
            {
                AddCheckReadyCom.Parameters.Add("@setupCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                AddCheckReadyCom.Parameters.Add("@readyCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                AddCheckReadyCom.Parameters.AddWithValue("@note", DBNull.Value);

                AddCom.Parameters.AddWithValue("@dataEndSetup", DBNull.Value);

            }
            else
            {
                AddCom.Parameters.AddWithValue("@dataEndSetup", DateEndDatePicker.Value);
                AddCheckReadyCom.Parameters.Add("@setupCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                AddCheckReadyCom.Parameters.Add("@readyCheck", MySqlDbType.UByte).Value = Convert.ToBoolean(false);
                AddCheckReadyCom.Parameters.Add("@note", MySqlDbType.VarChar).Value = "Ожидает перезаправку или списание";

            }



            db.closeConnection(); //Закрываем подключение к БД


            //Проверка на успешную отправку запроса
            db.openConnection();
            if ((AddCom.ExecuteNonQuery() == 1) && (AddCheckReadyCom.ExecuteNonQuery() == 1))
            {
                MessageBox.Show("Снято");
                //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show("Заполните все поля ппп");
            }
            db.closeConnection(); //Закрываем подключение к БД
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void DateEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            if (!dtp.ShowCheckBox || dtp.Checked)
                dtp.CustomFormat = "dd.MM.yyyy";
            else
                dtp.CustomFormat = null;
        }

        private void CartrigeSetupComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* DB dB = new DB();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table
            mySqlDataAdapter.SelectCommand = new MySqlCommand("", dB.getConnection());*/


        }
    }
}
