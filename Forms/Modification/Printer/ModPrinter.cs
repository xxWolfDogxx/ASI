using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ASI.Forms.Modification.Printer
{
    public partial class ModPrinter : Form
    {
        internal static string PrinterInven;
        internal static string PrinterName;
        internal static string PrinterInvenDB;
        internal static string PrinterNameDB;

        public ModPrinter()
        {
           
            InitializeComponent();

            //
            //Блокируем ввод от руки в combox
            //
            RoomComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModPrinter_Load(object sender, EventArgs e)
        {
            DB db = new DB();

            //Hide button option
            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение принтера";
                    AddPrinterBut.Visible = false;
                    ModPrinterBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление принтера";
                    AddPrinterBut.Visible = true;
                    ModPrinterBut.Visible = false;
                    break;
            }

            //
            //Задаем первичные значения для ComBox
            //
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter();
            DataTable tableRoom = new DataTable();
            DataTable tableModel = new DataTable();

            //RoomComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRoom_ModPrinter, db.getConnection());
            mySql_dataAdapter.Fill(tableRoom);

            //ModelComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel_ModPrinter, db.getConnection());
            mySql_dataAdapter.Fill(tableModel);

            //Source for ComBox
            RoomComBox.DataSource = tableRoom;
            ModelComBox.DataSource = tableModel;

            //Отбираем все значения что хотим показать и те что хотим скрыть
            RoomComBox.DisplayMember = "name_room";
            RoomComBox.ValueMember = "id_room";
            ModelComBox.DisplayMember = "name_model";
            ModelComBox.ValueMember = "id_model";


            //
            //Заносим в поля данные
            //
            IdPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Id.ToString();
            NamePrinterTextBox.Text = DataBase.Entity.Printer.Printer.Name;
            InventoryPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Inventory;
            RoomComBox.SelectedValue = DataBase.Entity.Printer.Printer.Id_room;
            NoteTextBox.Text = DataBase.Entity.Printer.Printer.Note;
            ModelComBox.SelectedValue = DataBase.Entity.Printer.Printer.Id_model;

        }
 
        private void AddPrinterBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_ADDPrinter_ModPrinter, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@namePrinter", MySqlDbType.VarChar).Value = NamePrinterTextBox.Text;
            AddCom.Parameters.Add("@inventoryPtinter", MySqlDbType.VarChar).Value = InventoryPrinterTextBox.Text;
            AddCom.Parameters.Add("@roomPtinter", MySqlDbType.Int32).Value = RoomComBox.SelectedValue;
            AddCom.Parameters.Add("@notePrinter", MySqlDbType.VarChar).Value = NoteTextBox.Text;
            AddCom.Parameters.Add("@modelPrinter", MySqlDbType.Int32).Value = ModelComBox.SelectedValue;
            db.closeConnection(); //Закрываем подключение к БД

            PrinterInven = InventoryPrinterTextBox.Text;
            PrinterName = NamePrinterTextBox.Text;

            db.openConnection();
            if (Function.isPrinterExists.isPrinExists() == true)
            {
                return;
            }
            else if (Function.isPrinterExists.isPrinExists() == false)
            {
                if (AddCom.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Принтер добавлен");
                    //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                    Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else { MessageBox.Show("Поправить - разработчику\nModPrinter, проверка на повторы при добавление записи"); }
            db.closeConnection();
        }
        
        private void ModPrinterBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //
            //Заносим во временные переменные данные, для проверки от повторений
            //
            db.openConnection(); // Открываем подключение к БД
            var PrinterInventDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            PrinterInventDBCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectPrinterInventDB_ModPrinter; // Запрос на какие либо даные
            PrinterInventDBCom.Connection = db.getConnection(); //Отправляем запроса
            PrinterInventDBCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;

            var printerInventDB = PrinterInventDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printerInventDB.Read()) { PrinterInvenDB=(printerInventDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            db.openConnection(); // Открываем подключение к БД
            var PrinterNameDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            PrinterNameDBCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectPrinterNameDB_ModPrinter; // Запрос на какие либо даные
            PrinterNameDBCom.Connection = db.getConnection(); //Отправляем запрос
            PrinterNameDBCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;

            var printerNameDB = PrinterNameDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printerNameDB.Read()) { PrinterNameDB = (printerNameDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 



            MySqlCommand ModCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdatePrinter_ModPrinter, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            ModCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;
            ModCom.Parameters.Add("@namePrinter", MySqlDbType.VarChar).Value = NamePrinterTextBox.Text;
            ModCom.Parameters.Add("@inventoryPtinter", MySqlDbType.VarChar).Value = InventoryPrinterTextBox.Text;
            ModCom.Parameters.Add("@roomPtinter", MySqlDbType.Int32).Value = RoomComBox.SelectedValue;
            ModCom.Parameters.Add("@notePrinter", MySqlDbType.VarChar).Value = NoteTextBox.Text;
            ModCom.Parameters.Add("@modelPrinter", MySqlDbType.Int32).Value = ModelComBox.SelectedValue;
            db.closeConnection(); //Закрываем подключение к БД

            PrinterInven = InventoryPrinterTextBox.Text;
            PrinterName = NamePrinterTextBox.Text;

            db.openConnection();
            if (Function.isPrinterExists.isPrinExists() == true)
            {
                return;
            }
            else if (Function.isPrinterExists.isPrinExists() == false)
            {
                if (ModCom.ExecuteNonQuery() == 1)
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
            else { MessageBox.Show("Поправить - разработчику\nModPrinter, проверка на повторы при изменении записи"); }
            db.closeConnection();

        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            
            Hide();
            this.Close();
        }
    }
}
