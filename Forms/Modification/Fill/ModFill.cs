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

namespace ASI.Forms.Modification.Fill
{
    public partial class ModFill : Form
    {
        public ModFill()
        {
            InitializeComponent();
        }

        private void AddStatusWorkBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertFill_ModFill, db.getConnection());

            //Заносим данные в запрос
            AddCom.Parameters.Add("@cartrigeFill", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedItem);
            AddCom.Parameters.Add("@dateFill", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateFillDatePicker.Value);
            AddCom.Parameters.Add("@noteFill", MySqlDbType.VarChar).Value = NoteFillTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД
           // Проверка на повторного пользователя
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

        private void ModStatusWork_Load(object sender, EventArgs e)
        {


            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    LogoLabel.Text = "Изменение статуса";
                    AddFillBut.Visible = false;
                    ModFillBut.Visible = true;
                    break;
                case ("Добавить"):
                    LogoLabel.Text = "Добавление статуса";
                    AddFillBut.Visible = true;
                    ModFillBut.Visible = false;
                    break;
            }


            //
            //Блокируем ввод от руки в combox
            //
            RefillComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModStatusWorkBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection(); //Открываем подключение к БД
            //Запрос на вставку данных с формы в базу данных
            MySqlCommand ModCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateFill_ModFill, db.getConnection());

            //Заносим данные в запрос
            ModCom.Parameters.Add("@idFill", MySqlDbType.Int32).Value = Convert.ToInt32(IdTypeTextBox.Text);
            ModCom.Parameters.Add("@cartrigeFill", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedItem);
            ModCom.Parameters.Add("@dateFill", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateFillDatePicker.Value);
            ModCom.Parameters.Add("@noteFill", MySqlDbType.VarChar).Value = NoteFillTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            db.openConnection();

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

            db.closeConnection();
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
