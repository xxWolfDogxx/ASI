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
                    AddSetupBut.Visible = false;
                    ModSetupBut.Visible = true;
                    break;
                case ("Добавить"):
                    AddSetupBut.Visible = true;
                    ModSetupBut.Visible = false;
                    break;
            }

            //
            //Заносим в поле Инвентарный номер принтера
            //
            db.openConnection(); // Открываем подключение к БД
            var Printer_SetupCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            Printer_SetupCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectInventPrinter; // Запрос на какие либо данные
            Printer_SetupCom.Connection = db.getConnection(); //Отправляем запрос

            var printer = Printer_SetupCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printer.Read()) { InventPrinterSetupComBox.Items.Add(printer.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 
            //--------------------------------------------------------------------------------------------------------------------------------

            //
            //Заносим в поле Номер картриджа
            //
            db.openConnection(); // Открываем подключение к БД
            var Cartrige_SetupCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            Cartrige_SetupCom.CommandText =DataBase.Scripts.ScriptMySql.script_SelectNumberCartrige; // Запрос на какие либо данные
            Cartrige_SetupCom.Connection = db.getConnection(); //Отправляем запрос

            var cartrige = Cartrige_SetupCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (cartrige.Read()) { NumberCartrigeSetupComBox.Items.Add(cartrige.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 
                                  //--------------------------------------------------------------------------------------------------------------------------------

            IdSetupTextBox.Text = DataBase.Entity.Setup.Setup.Id;
            InventPrinterSetupComBox.Text = DataBase.Entity.Setup.Setup.IdPrinter;
            NumberCartrigeSetupComBox.Text = DataBase.Entity.Setup.Setup.IdCartrige;
            DateSetup.Text = DataBase.Entity.Setup.Setup.Data_setup;
            DateWithDrawal.Text = DataBase.Entity.Setup.Setup.Data_withdrawals;

            InventPrinterSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NumberCartrigeSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddSetupBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertSetup, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@inventPrinterSetup", MySqlDbType.VarChar).Value = InventPrinterSetupComBox.SelectedItem;
            AddCom.Parameters.Add("@numberCartrigeSetup", MySqlDbType.VarChar).Value = NumberCartrigeSetupComBox.SelectedItem;
            AddCom.Parameters.Add("@dataSetup", MySqlDbType.Date).Value = DateSetup.Value;
            AddCom.Parameters.Add("@dataWithDrawals", MySqlDbType.Date).Value = DateWithDrawal.Value;

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
            AddCom.Parameters.Add("@idSetup", MySqlDbType.VarChar).Value = IdSetupTextBox.Text;
            AddCom.Parameters.Add("@inventPrinterSetup", MySqlDbType.VarChar).Value = InventPrinterSetupComBox.SelectedItem;
            AddCom.Parameters.Add("@numberCartrigeSetup", MySqlDbType.VarChar).Value = NumberCartrigeSetupComBox.SelectedItem;
            AddCom.Parameters.Add("@dataSetup", MySqlDbType.Date).Value = DateSetup.Value;
            AddCom.Parameters.Add("@dataWithDrawals", MySqlDbType.Date).Value = DateWithDrawal.Value;

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
    }
}
