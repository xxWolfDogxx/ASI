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

namespace ASI.Forms.Modification.StatusWork
{
    public partial class ModStatusWork : Form
    {
        internal static string statusWork;
        internal static string statusWorkDB;
        public ModStatusWork()
        {
            InitializeComponent();
        }

        private void AddStatusWorkBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertStatusWork, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@statusWork", MySqlDbType.VarChar).Value = StatusWorkTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            statusWork = StatusWorkTextBox.Text;

            // Проверка на повторного пользователя
            if (Function.isStatusWorkExists.isStatusExists())
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

        private void ModStatusWork_Load(object sender, EventArgs e)
        {
            IdStatusWorkTextBox.Text = DataBase.Entity.StatusWork.StatusWork.Id;
            StatusWorkTextBox.Text = DataBase.Entity.StatusWork.StatusWork.Status;

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение статуса";
                    AddStatusWorkBut.Visible = false;
                    ModStatusWorkBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление статуса";
                    AddStatusWorkBut.Visible = true;
                    ModStatusWorkBut.Visible = false;
                    break;
            }

        }

        private void ModStatusWorkBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var PrinterDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            PrinterDBCom.CommandText = "Select status From refill Where id = @idStatus"; // Запрос на какие либо даные
            PrinterDBCom.Connection = db.getConnection(); //Отправляем запрос
            PrinterDBCom.Parameters.Add("@idStatus", MySqlDbType.Int32).Value = IdStatusWorkTextBox.Text;

            var printerDB = PrinterDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (printerDB.Read()) { statusWorkDB = (printerDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateStatusWork, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@idStatusWork", MySqlDbType.VarChar).Value = IdStatusWorkTextBox.Text;
            AddCom.Parameters.Add("@statusWork", MySqlDbType.VarChar).Value = StatusWorkTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД


            statusWork = StatusWorkTextBox.Text;
            MessageBox.Show(statusWork + " ff " + statusWorkDB);

            db.openConnection();
            if (Function.isStatusWorkExists.isStatusExists() == true)
            {
                return;
            }
            else if (Function.isStatusWorkExists.isStatusExists() == false)
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
            else { MessageBox.Show("Поправить - разработчику\nModStatusWork, проверка на повторы при изменении записи"); }
            db.closeConnection();
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
