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

namespace ASI.Forms.Modification.Printer
{
    public partial class ModPrinter : Form
    {
        internal static string PrinterInven;
        internal static string PrinterInvenDB;
        
        public ModPrinter()
        {
           
            InitializeComponent();
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

            // Проверка на повторного пользователя
            if (Function.isPrinterExists.isPrinExists())
            {
                return;
            }
            else
            {
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
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRoom, db.getConnection());            
            mySql_dataAdapter.Fill(tableRoom);

            //ModelComBox insert iteam
            mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel, db.getConnection());
            mySql_dataAdapter.Fill(tableModel);

            //Source for ComBox
            RoomComBox.DataSource=tableRoom;
            ModelComBox.DataSource=tableModel;
           
            //Отбираем все значения что хотим показать и те что хотим скрыть
            RoomComBox.DisplayMember = "name";
            RoomComBox.ValueMember = "id";
            ModelComBox.DisplayMember = "name";
            ModelComBox.ValueMember = "id";

            //Блокируем ввод от руки в ComBox
            RoomComBox.DropDownStyle = ComboBoxStyle.DropDownList;      
            ModelComBox.DropDownStyle = ComboBoxStyle.DropDownList;


            //
            //Заносим в поля данные
            //
            IdPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Id.ToString();
            NamePrinterTextBox.Text = DataBase.Entity.Printer.Printer.Name;
            InventoryPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Inventory;
            RoomComBox.SelectedItem = DataBase.Entity.Printer.Printer.Id_room;
            NoteTextBox.Text = DataBase.Entity.Printer.Printer.Note;
            ModelComBox.SelectedItem = DataBase.Entity.Printer.Printer.Id_model;

        }

        private void ModPrinterBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var PrinterDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            PrinterDBCom.CommandText = "Select Inventory From printer Where id = @idPrinter"; // Запрос на какие либо даные
            PrinterDBCom.Connection = db.getConnection(); //Отправляем запрос
            PrinterDBCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;

            var printerDB = PrinterDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printerDB.Read()) { PrinterInvenDB=(printerDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdatePrinter_ModPrinter, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;
            AddCom.Parameters.Add("@namePrinter", MySqlDbType.VarChar).Value = NamePrinterTextBox.Text;
            AddCom.Parameters.Add("@inventoryPtinter", MySqlDbType.VarChar).Value = InventoryPrinterTextBox.Text;
            AddCom.Parameters.Add("@roomPtinter", MySqlDbType.Int32).Value = RoomComBox.SelectedValue;
            AddCom.Parameters.Add("@notePrinter", MySqlDbType.VarChar).Value = NoteTextBox.Text;
            AddCom.Parameters.Add("@modelPrinter", MySqlDbType.Int32).Value = ModelComBox.SelectedValue;
            db.closeConnection(); //Закрываем подключение к БД

            PrinterInven = InventoryPrinterTextBox.Text;

            db.openConnection();
            if (Function.isPrinterExists.isPrinExists() == true)
            {
                return;
            }
            else if (Function.isPrinterExists.isPrinExists() == false)
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
