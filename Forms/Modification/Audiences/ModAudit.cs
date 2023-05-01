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

namespace ASI.Forms.Modification.Audiences
{
    public partial class ModAudit : Form
    {
        internal static string Audit;
        internal static string AuditDB;
        public ModAudit()
        {
            InitializeComponent();
        }

        private void ModAudit_Load(object sender, EventArgs e)
        {
            IdAuditTextBox.Text = DataBase.Entity.Audit.Audiences.Id;
            AuditTextBox.Text = DataBase.Entity.Audit.Audiences.Auditorium1;
            CommentAuditTextBox.Text = DataBase.Entity.Audit.Audiences.Comments1;

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
        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void AddAuditBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertAudit, db.getConnection());
            Audit = AuditTextBox.Text;
            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@audit", MySqlDbType.VarChar).Value = AuditTextBox.Text;
            AddCom.Parameters.Add("@comAudit", MySqlDbType.VarChar).Value = CommentAuditTextBox.Text;

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
            var AuditDBCom = new MySqlCommand(); // Создаем переменную класса MySqlCommand
            AuditDBCom.CommandText = "Select 	Auditorium  From audiences Where id = @idAudit"; // Запрос на какие либо даные
            AuditDBCom.Connection = db.getConnection(); //Отправляем запрос
            AuditDBCom.Parameters.Add("@idAudit", MySqlDbType.Int32).Value = IdAuditTextBox.Text;

            

            var auditDB = AuditDBCom.ExecuteReader(); // Создаем переменную, в которую будем вносить по порядку все полученные данные из запроса
            while (auditDB.Read()) { AuditDB = (auditDB.GetString(0)); }; // Перебираем данные занося их в переменную
            db.closeConnection(); // Закрываем подключение к БД
            MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateAudit, db.getConnection());

            db.openConnection();
            //Заносим данные в запрос
            AddCom.Parameters.Add("@idAudit", MySqlDbType.VarChar).Value = IdAuditTextBox.Text;
            AddCom.Parameters.Add("@audit", MySqlDbType.VarChar).Value = AuditTextBox.Text;
            AddCom.Parameters.Add("@comAudit", MySqlDbType.VarChar).Value = CommentAuditTextBox.Text;

            db.closeConnection(); //Закрываем подключение к БД

            Audit = AuditTextBox.Text;

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
            else { MessageBox.Show("Поправить - разработчику\nModAudit, проверка на повторы при изменении записи"); }
            db.closeConnection();

        }

    }
}
