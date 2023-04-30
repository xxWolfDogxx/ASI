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
                    AddStatusWorkBut.Visible = false;
                    ModStatusWorkBut.Visible = true;
                    break;
                case ("Добавить"):
                    AddStatusWorkBut.Visible = true;
                    ModStatusWorkBut.Visible = false;
                    break;
            }

        }

        private void ModStatusWorkBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateStatusWork, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@idStatusWork", MySqlDbType.VarChar).Value = IdStatusWorkTextBox.Text;
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
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
