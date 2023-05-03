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

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение записи";
                    AddSetupBut.Visible = false;
                    ModSetupBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление записи";
                    AddSetupBut.Visible = true;
                    ModSetupBut.Visible = false;
                    break;
            }

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
            PrinterSetupComBox.DisplayMember = "inventory";
            PrinterSetupComBox.ValueMember = "id";
            CartrigeSetupComBox.DisplayMember = "code";
            CartrigeSetupComBox.ValueMember = "id";

            //Блокируем ввод от руки в ComBox
            PrinterSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CartrigeSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;


            //
            //Заносим в поля данные
            //
            IdSetupTextBox.Text = DataBase.Entity.Setup.Setup.Id.ToString();
            PrinterSetupComBox.SelectedItem = DataBase.Entity.Setup.Setup.Id_printer;
            CartrigeSetupComBox.SelectedItem = DataBase.Entity.Setup.Setup.Id_cartrige;
            DateStartDatePicker.Text = DataBase.Entity.Setup.Setup.Start;
            DateEndDatePicker.Text = DataBase.Entity.Setup.Setup.End;
            NoteSetupTextBox.Text = DataBase.Entity.Setup.Setup.Note;


        }

        private void AddSetupBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertSetup, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@printerSetup", MySqlDbType.Int32).Value =Convert.ToInt32(PrinterSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@cartrigeSetup", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedValue);
            AddCom.Parameters.Add("@dataStartSetup", MySqlDbType.Date).Value =Convert.ToDateTime(value: DateStartDatePicker.Value);
           
            if (DateEndDatePicker.Checked)
                AddCom.Parameters.AddWithValue("@dataEndSetup", DateEndDatePicker.Value);
            else
                AddCom.Parameters.AddWithValue("@dataEndSetup", null);
           
            AddCom.Parameters.Add("@noteSetup", MySqlDbType.VarChar).Value = NoteSetupTextBox.Text;


            db.closeConnection(); //Закрываем подключение к БД


            //Проверка на успешную отправку запроса
            db.openConnection();
            if (AddCom.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись добавлена");
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

            if (DateEndDatePicker.Checked)
                AddCom.Parameters.AddWithValue("@dataEndSetup", DateEndDatePicker.Value);
            else
                AddCom.Parameters.AddWithValue("@dataEndSetup", null);

            AddCom.Parameters.Add("@noteSetup", MySqlDbType.VarChar).Value = NoteSetupTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД


            //Проверка на успешную отправку запроса
            db.openConnection();
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
    }
}
