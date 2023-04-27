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
using ASI.DataBase.Scripts;

namespace ASI.Forms.Main
{
    public partial class ASI : Form
    {
        public ASI()
        {
            InitializeComponent();
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.AllowUserToAddRows = false;
        }

        private void ASI_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Переход на форму для авторизации
            Forms.Identification.Authentication.Auth auth = new Forms.Identification.Authentication.Auth();
            Hide();
            auth.ShowDialog();            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

            DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
            MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(); //Через класс MySqlDataAdapter отправляем запрос в БД для получения данных
            DataTable table = new DataTable(); //Создаем класс DataTable для того чтоб занести данные из запроса в виртуальную таблицу          
            TreeNode CurrentNode = treeView1.SelectedNode; // Отслеживаем фокус иерархии. Общий вид вывода информации TreeNode: Принтер

            //
            //Заполняем таблицу данными с запросов
            //
            //-----------------------------------------------------------
            //Расставить выборку по ролям
            //-----------------------------------------------------------
            db.openConnection();
            switch (Convert.ToString(CurrentNode))
            {
                case ("TreeNode: Все"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectAllUsers, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";
               

                    break;

                case ("TreeNode: Администратор"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_Admin, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";

                    break;

                case ("TreeNode: Пользователь"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_User, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";

                    break;

                case ("TreeNode: Роли"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideRole, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["role"].HeaderText = "Роли";

                    break;

                case ("TreeNode: Принтер"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuidePrinters, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме                 
                    
                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Brand"].HeaderText = "Бренд";
                    GridView.Columns["Id"].Visible=false;
                    GridView.Columns["Model"].HeaderText = "Модель";
                    GridView.Columns["InventoryNumber"].HeaderText = "Инвентарный номер";
                    GridView.Columns["DoubleЫSided_Printing"].HeaderText = "Двусторонняя печать";
                    GridView.Columns["DrumUnit"].HeaderText = "Отдельный фотобарабан";

                   

                    //Центруем заголовки
                   // GridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    
                    break;

                case ("TreeNode: Картридж"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideCartrige, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Brand"].HeaderText = "Бренд";
                    GridView.Columns["Model"].HeaderText = "Модель";
                    GridView.Columns["Number"].HeaderText = "Уникальный номер";
                    GridView.Columns["Status"].HeaderText = "Статус картриджа";
                    GridView.Columns["Refill"].HeaderText = "Перезаправлен картридж";
                    GridView.Columns["Comment"].HeaderText = "Комментарий";

                    break;

                case ("TreeNode: Аудитория"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideAuditorium, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Auditorium"].HeaderText = "Корпус / Аудитория";
                    GridView.Columns["Comments"].HeaderText = "Комментарий";


                    break;

                case ("TreeNode: Установки"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectSetup, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id_printer"].HeaderText = "ID принтера";
                    GridView.Columns["Id_cartrige"].HeaderText = "ID картриджа";
                    GridView.Columns["Data_setup"].HeaderText = "Дата установки";
                    GridView.Columns["Data_setup"].DefaultCellStyle.Format = "yyyy-dd-MM";
                    GridView.Columns["Data_withdrawals"].HeaderText = "Дата снятия";
                    GridView.Columns["Id_user"].HeaderText = "Пользователь";

                    break;

                case ("TreeNode: Статус работоспобности"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideRefill, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Status"].HeaderText = "Рабочее состояние";

                    break;

            }
            db.closeConnection();
        }

        private void ASI_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // modPrinter.Text = "Редактирование принтера";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //скрывает нынешную форму

                                     //закрываем нынешную форму

            TreeNode CurrentNode = treeView1.SelectedNode;

            switch (Convert.ToString(CurrentNode))
            {
                case ("TreeNode: Все"):

                    MessageBox.Show("hhhh");
                    break;

                case ("TreeNode: Администратор"):
     

                    break;

                case ("TreeNode: Пользователь"):


                    break;

                case ("TreeNode: Роли"):
 

                    break;

                case ("TreeNode: Принтер"):
                    Modification.Printer.ModCartrige modPrinter = new Modification.Printer.ModPrinter(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Printer.Printer.Id = GridView.CurrentRow.Cells[0].Value.ToString();
                    DataBase.Entity.Printer.Printer.Brand1 = GridView.CurrentRow.Cells[1].Value.ToString();
                    DataBase.Entity.Printer.Printer.Model1 = GridView.CurrentRow.Cells[2].Value.ToString();
                    DataBase.Entity.Printer.Printer.Invent1 = GridView.CurrentRow.Cells[3].Value.ToString();
                    DataBase.Entity.Printer.Printer.Audit1 = GridView.CurrentRow.Cells[4].Value.ToString();
                    DataBase.Entity.Printer.Printer.Doubl1 = GridView.CurrentRow.Cells[5].Value.ToString();
                    DataBase.Entity.Printer.Printer.Drum1 = GridView.CurrentRow.Cells[6].Value.ToString();
                    DataBase.Entity.Printer.Printer.Color1 = GridView.CurrentRow.Cells[7].Value.ToString();
                    modPrinter.ShowDialog();

                    break;

                case ("TreeNode: Картридж"):
       

                    break;

                case ("TreeNode: Аудитория"):
            


                    break;

                case ("TreeNode: Установки"):
                  

                    break;

                case ("TreeNode: Статус работоспобности"):
                   

                    break;

            }
        }
    }
}
