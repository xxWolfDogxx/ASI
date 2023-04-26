﻿using ASI.DataBase.ConnectionForMySQL;
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


            //Проверка на успешную отправку запроса
            db.openConnection();
            if (AddCom.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка добавлена");
                //Если все хорошо, открывает главную форму для дальнейшего взаймодействия с ней
                Hide();
                Main.ASI inMain = new Main.ASI();
                inMain.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            db.closeConnection(); //Закрываем подключение к БД
        }

        private void ModPrinter_Load(object sender, EventArgs e)
        {
            DB db = new DB();
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

        }
    }
}
