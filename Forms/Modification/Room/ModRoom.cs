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

namespace ASI.Forms.Modification.Room
{
    public partial class ModRoom : Form
    {
        internal static string Room;
        internal static string RoomDB;
        public ModRoom()
        {
            InitializeComponent();
            RoomTextBox.Focus();
        }

        private void ModAudit_Load(object sender, EventArgs e)
        {
            

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение аудитории";
                    AddAuditBut.Visible = false;
                    ModAuditBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление аудитории";

                    AddAuditBut.Visible = true;
                    ModAuditBut.Visible = false;
                    break;
            }

            IdRoomTextBox.Text = Convert.ToString( DataBase.Entity.Audit.Audiences.Id);
            RoomTextBox.Text = DataBase.Entity.Audit.Audiences.Name;
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void AddAuditBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertRoom_ModRoom, db.getConnection());
            Room = RoomTextBox.Text;
            RoomDB = null;
            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@room", MySqlDbType.VarChar).Value = RoomTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            // Проверка на повторного пользователя
            if (Function.isAudiencesExists.isAuditExists())
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

        private void ModAuditBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var RoomDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            RoomDBCom.CommandText = "Select name  From room Where id = @idRoom"; // Запрос на какие либо даные
            RoomDBCom.Connection = db.getConnection(); //Отправляем запрос
            RoomDBCom.Parameters.Add("@idRoom", MySqlDbType.Int32).Value = IdRoomTextBox.Text;            

            var roomDB = RoomDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (roomDB.Read()) { RoomDB = (roomDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД


            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateRoom_ModRoom, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idRoom", MySqlDbType.VarChar).Value = IdRoomTextBox.Text;
            AddCom.Parameters.Add("@room", MySqlDbType.VarChar).Value = RoomTextBox.Text;


            db.closeConnection(); //Закрываем подключение к БД

            Room = RoomTextBox.Text;

            db.openConnection();
            if (Function.isAudiencesExists.isAuditExists() == true)
            {
                return;
            }
            else if (Function.isAudiencesExists.isAuditExists() == false)
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
            else { MessageBox.Show("Поправить - разработчику\nModRoom, проверка на повторы при изменении записи"); }
            db.closeConnection();

        }

    }
}
