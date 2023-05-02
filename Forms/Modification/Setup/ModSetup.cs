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



            PrinterSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CartrigeSetupComBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddSetupBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertSetup, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@printerSetup", MySqlDbType.Int32).Value =Convert.ToInt32(PrinterSetupComBox.SelectedItem);
            AddCom.Parameters.Add("@cartrigeSetup", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedItem);
            AddCom.Parameters.Add("@dataStartSetup", MySqlDbType.Date).Value =Convert.ToDateTime(value: DateStartDatePicker.Value);
            AddCom.Parameters.Add("@dataEndSetup", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateEndDatePicker.Value);
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
            AddCom.Parameters.Add("@printerSetup", MySqlDbType.Int32).Value = Convert.ToInt32(PrinterSetupComBox.SelectedItem);
            AddCom.Parameters.Add("@cartrigeSetup", MySqlDbType.Int32).Value = Convert.ToInt32(CartrigeSetupComBox.SelectedItem);
            AddCom.Parameters.Add("@dataStartSetup", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateStartDatePicker.Value);
            AddCom.Parameters.Add("@dataEndSetup", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateEndDatePicker.Value);
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
    }
}
