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

namespace ASI.Forms.Modification.Model
{
    public partial class ModModel : Form
    {
        internal static string Model;
        internal static string ModelDB;
        public ModModel()
        {
            InitializeComponent();
        }

        private void ModModel_Load(object sender, EventArgs e)
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

            IdModelTextBox.Text = Convert.ToString(DataBase.Entity.Model.Model.Id);
            NameTextBox.Text = DataBase.Entity.Model.Model.Name;
        }

        private void AddAuditBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            Model = NameTextBox.Text;
            ModelDB = null;

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertModel_ModModel, db.getConnection());
            
            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@nameModel", MySqlDbType.VarChar).Value = NameTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            db.openConnection();
            if (Function.isModelExists.isModExists() == true)
            {
                return;
            }
            else if (Function.isModelExists.isModExists() == false)
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
            else { MessageBox.Show("Поправить - разработчику\nModModel, проверка на повторы при добавлении записи"); }
            db.closeConnection();

        }

        private void ModAuditBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();


            //Заносим в 
            db.openConnection(); // Открываем подключение к БД
            var ConsumableDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            ConsumableDBCom.CommandText = "Select name From model Where id = @idModel"; // Запрос на какие либо даные
            ConsumableDBCom.Connection = db.getConnection(); //Отправляем запрос
            ConsumableDBCom.Parameters.Add("@idModel", MySqlDbType.Int32).Value = IdModelTextBox.Text;

            var consumableDB = ConsumableDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (consumableDB.Read()) { ModelDB = (consumableDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertModel_ModModel, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idModel", MySqlDbType.Int32).Value =Convert.ToInt32(IdModelTextBox.Text);
            AddCom.Parameters.Add("@nameModel", MySqlDbType.VarChar).Value = NameTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            Model = NameTextBox.Text;

            db.openConnection();
            if (Function.isModelExists.isModExists() == true)
            {
                return;
            }
            else if (Function.isModelExists.isModExists() == false)
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
            else { MessageBox.Show("Поправить - разработчику\nModModel, проверка на повторы при изменении записи"); }
            db.closeConnection();
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
