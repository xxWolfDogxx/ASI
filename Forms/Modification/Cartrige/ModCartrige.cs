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

namespace ASI.Forms.Modification.Cartrige
{
    public partial class ModCartrige : Form
    {
        internal static string numCartrige;
        public ModCartrige()
        {
            InitializeComponent();
        }

        private void AddCartrigeBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertCartrige, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@brandCartrige", MySqlDbType.VarChar).Value = BrandCartrigeTextBox.Text;
            AddCom.Parameters.Add("@modelCartrige", MySqlDbType.VarChar).Value = ModelCartrigeTextBox.Text;
            AddCom.Parameters.Add("@numberCartrige", MySqlDbType.VarChar).Value = NumberCartrigeTextBox.Text;
            AddCom.Parameters.Add("@statusWorkCartrige", MySqlDbType.VarChar).Value = StatusCartrigeComBox.SelectedItem;
            AddCom.Parameters.Add("@refillCartrige", MySqlDbType.VarChar).Value = RefillCartrigeComBox.SelectedItem;
            AddCom.Parameters.Add("@comCartrige", MySqlDbType.VarChar).Value = CommentCartrigeTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            numCartrige = NumberCartrigeTextBox.Text;

            // Проверка на повторного пользователя
            if (Function.isCartrigeExists.isCarExists())
            {
                return;
            }
            else
            {
                db.openConnection();
                if (AddCom.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Заявка Добавлена");
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
    

        private void ModCartrige_Load(object sender, EventArgs e)
        {
            DB db = new DB(); //Объявляем подключение к классу "Подключения БД"

            switch (Forms.Main.ASI.Modif)
            {
                case ("Изменить"):
                    AddCartrigeBut.Visible = false;
                    ModCartrigeBut.Visible = true;
                    break;
                case ("Добавить"):
                    AddCartrigeBut.Visible = true;
                    ModCartrigeBut.Visible = false;
                    break;
            }

            //
            //Блокируем ввод от руки в combox
            //
            StatusCartrigeComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RefillCartrigeComBox.DropDownStyle = ComboBoxStyle.DropDownList;            

            //
            //Заносим в поле статус работоспособности
            //
            db.openConnection(); // Открываем подключение к БД
            var StatusWorkCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            StatusWorkCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectStatusWork; // Запрос на какие либо данные
            StatusWorkCom.Connection = db.getConnection(); //Отправляем запрос

            var _statusWork = StatusWorkCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (_statusWork.Read()) { StatusCartrigeComBox.Items.Add(_statusWork.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //
            //Заносим в поле статус работоспособности
            //
            db.openConnection(); // Открываем подключение к БД
            var StatusRefillCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            StatusRefillCom.CommandText = DataBase.Scripts.ScriptMySql.script_SelectRefill; // Запрос на какие либо данные
            StatusRefillCom.Connection = db.getConnection(); //Отправляем запрос

            var _statusRefill = StatusRefillCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (_statusRefill.Read()) { RefillCartrigeComBox.Items.Add(_statusRefill.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД 

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //
            //Для изменения строки
            //
            IdCartrigeTextBox.Text = DataBase.Entity.Cartrige.Cartrige.Id;
            BrandCartrigeTextBox.Text = DataBase.Entity.Cartrige.Cartrige.Brand1;
            ModelCartrigeTextBox.Text = DataBase.Entity.Cartrige.Cartrige.Model1;
            NumberCartrigeTextBox.Text = DataBase.Entity.Cartrige.Cartrige.Number1;
            StatusCartrigeComBox.Text = DataBase.Entity.Cartrige.Cartrige.Status1;
            RefillCartrigeComBox.Text = DataBase.Entity.Cartrige.Cartrige.Refill1;
            CommentCartrigeTextBox.Text = DataBase.Entity.Cartrige.Cartrige.Comment1;

        }

        private void ModCartrigeBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateCartrige, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = IdCartrigeTextBox.Text;
            AddCom.Parameters.Add("@brandCartrige", MySqlDbType.VarChar).Value = BrandCartrigeTextBox.Text;
            AddCom.Parameters.Add("@modelCartrige", MySqlDbType.VarChar).Value = ModelCartrigeTextBox.Text;
            AddCom.Parameters.Add("@numberCartrige", MySqlDbType.VarChar).Value = NumberCartrigeTextBox.Text;
            AddCom.Parameters.Add("@statusWorkCartrige", MySqlDbType.VarChar).Value = StatusCartrigeComBox.SelectedItem;
            AddCom.Parameters.Add("@refillCartrige", MySqlDbType.VarChar).Value = RefillCartrigeComBox.SelectedItem;
            AddCom.Parameters.Add("@comCartrige", MySqlDbType.VarChar).Value = CommentCartrigeTextBox.Text;
            
            db.closeConnection(); //Закрываем подключение к БД

            numCartrige = NumberCartrigeTextBox.Text;

            // Проверка на повторного пользователя
            if (Function.isCartrigeExists.isCarExists())
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
