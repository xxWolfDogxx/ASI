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
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_ADDPrinter, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@brandPrinter", MySqlDbType.VarChar).Value = BrandPrinterTextBox.Text;
            AddCom.Parameters.Add("@modelPrinter", MySqlDbType.VarChar).Value = ModelPrinterTextBox.Text;
            AddCom.Parameters.Add("@inventNumPtinter", MySqlDbType.VarChar).Value = InventTextBox.Text;
            AddCom.Parameters.Add("@auditPtinter", MySqlDbType.VarChar).Value = AuditComBox.SelectedItem;
            AddCom.Parameters.Add("@doubleSidedPrinter", MySqlDbType.VarChar).Value = DuplexPrintingComBox.SelectedItem;
            AddCom.Parameters.Add("@drumUnitPrinter", MySqlDbType.VarChar).Value = DrumUnitComBox.SelectedItem;
            AddCom.Parameters.Add("@colorPrinter", MySqlDbType.VarChar).Value = ColorComBox.SelectedItem;
            db.closeConnection(); //Закрываем подключение к БД

            PrinterInven = InventTextBox.Text;

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

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    AddPrinterBut.Visible = false;
                    ModPrinterBut.Visible = true;
                    break;
                case ("Добавить"):
                    AddPrinterBut.Visible = true;
                    ModPrinterBut.Visible = false;
                    break;
            }



            //---------------------------------------------------------------------------------------------------------------------------------------

            //Заносим в поле почты клиентов
            db.openConnection(); // Открываем подключение к БД
            var AuditCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            AuditCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectPtinter_Audit; // Запрос на какие либо даные
            AuditCom.Connection = db.getConnection(); //Отправляем запрос

            var audit = AuditCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (audit.Read()) { AuditComBox.Items.Add(audit.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 
            AuditComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            

            DuplexPrintingComBox.Items.Add("Есть");
            DuplexPrintingComBox.Items.Add("Отустсвует");
            DuplexPrintingComBox.DropDownStyle = ComboBoxStyle.DropDownList;

            DrumUnitComBox.Items.Add("Есть");
            DrumUnitComBox.Items.Add("Отустсвует");
            DrumUnitComBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ColorComBox.Items.Add("Есть");
            ColorComBox.Items.Add("Отустсвует");
            ColorComBox.DropDownStyle = ComboBoxStyle.DropDownList;

            IdPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Id;
            BrandPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Brand1;
            ModelPrinterTextBox.Text = DataBase.Entity.Printer.Printer.Model1;
            AuditComBox.Text = DataBase.Entity.Printer.Printer.Audit1;
            InventTextBox.Text = DataBase.Entity.Printer.Printer.Invent1;
            DuplexPrintingComBox.Text = DataBase.Entity.Printer.Printer.Doubl1;
            DrumUnitComBox.Text = DataBase.Entity.Printer.Printer.Drum1;
            ColorComBox.Text = DataBase.Entity.Printer.Printer.Color1;



        }

        private void ModPrinterBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var PrinterDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            PrinterDBCom.CommandText = "Select InventoryNumber From printers Where id = @idPrinter"; // Запрос на какие либо даные
            PrinterDBCom.Connection = db.getConnection(); //Отправляем запрос
            PrinterDBCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;

            var printerDB = PrinterDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printerDB.Read()) { PrinterInvenDB=(printerDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdatePrinter, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idPrinter", MySqlDbType.Int32).Value = IdPrinterTextBox.Text;
            AddCom.Parameters.Add("@brandPrinter", MySqlDbType.VarChar).Value = BrandPrinterTextBox.Text;
            AddCom.Parameters.Add("@modelPrinter", MySqlDbType.VarChar).Value = ModelPrinterTextBox.Text;
            AddCom.Parameters.Add("@inventNum", MySqlDbType.VarChar).Value = InventTextBox.Text;
            AddCom.Parameters.Add("@audit", MySqlDbType.VarChar).Value = AuditComBox.SelectedItem;
            AddCom.Parameters.Add("@doublPrinter", MySqlDbType.VarChar).Value = DuplexPrintingComBox.SelectedItem;
            AddCom.Parameters.Add("@drumPrinter", MySqlDbType.VarChar).Value = DrumUnitComBox.SelectedItem;
            AddCom.Parameters.Add("@colorPrinter", MySqlDbType.VarChar).Value = ColorComBox.SelectedItem;
            db.closeConnection(); //Закрываем подключение к БД

            PrinterInven = InventTextBox.Text;

            db.openConnection();
            if(PrinterInven == PrinterInvenDB)
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
            else if (Function.isPrinterExists.isPrinExists())
            {
                return;
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
