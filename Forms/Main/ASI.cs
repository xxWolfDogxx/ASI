﻿using MySql.Data.MySqlClient;
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
using ASI.DataBase.ConnectionForMySQL;

namespace ASI.Forms.Main
{
    public partial class ASI : Form
    {
        internal static string Modif;

        public ASI()
        {
            InitializeComponent();


            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.AllowUserToAddRows = false;
            treeView1.ExpandAll();

        }

        private void ASI_Load(object sender, EventArgs e)
        {

            switch (DataBase.Entity.Identification.DB_Users.RoleUsersForRole)
            {
                case ("ROLE_ROOT"):
                    treeView1.Nodes[0].Nodes[1].Remove();
                    treeView1.Nodes[0].Nodes[2].Remove();

                    Sep2.Visible = true;
                    Sep3.Visible = true;
                    Sep4.Visible = true;
                    AddToolBut.Visible = true;
                    ModToolBut.Visible = true;
                    DelToolBut.Visible = true;
                    SetupToolBut.Visible = true;

                    break;

                case ("ROLE_ADMIN"):
                    treeView1.Nodes[0].Remove();

                    Sep2.Visible = true;
                    Sep3.Visible = true;
                    Sep4.Visible = true;
                    AddToolBut.Visible = true;
                    ModToolBut.Visible = true;
                    DelToolBut.Visible = true;
                    SetupToolBut.Visible = true;

                    break;

                case ("ROLE_USER"):
                    treeView1.Nodes[0].Remove();

                    Sep2.Visible = false;
                    Sep3.Visible = false;
                    Sep4.Visible = false;
                    AddToolBut.Visible = false;
                    ModToolBut.Visible = false;
                    DelToolBut.Visible = false;
                    SetupToolBut.Visible = false;

                    break;
            }

            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
            treeView1.Focus();

        }

        private void UpdateTable()
        {
            bool visibleColum = true;

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
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectAllUsers_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме



                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;
                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;
                    break;

                case ("TreeNode: Администратор"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_Admin_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;
                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;
                    break;

                case ("TreeNode: Пользователь"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_User_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["FullName"].HeaderText = "ФИО";
                    GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                    GridView.Columns["Phone"].HeaderText = "Номер телефона";
                    GridView.Columns["Email"].HeaderText = "Эл. почта";
                    GridView.Columns["Password"].Visible = false;
                    GridView.Columns["Role"].HeaderText = "Роль";

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;
                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;
                    break;

                case ("TreeNode: Роли"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRole_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["role"].HeaderText = "Роли";

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;
                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;
                    break;

                case ("TreeNode: Принтер"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectPrinter_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме                 

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["ID"].Visible = visibleColum;
                    GridView.Columns["id_room"].Visible = false;
                    GridView.Columns["id_model"].Visible = false;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;
                     

                    break;

                case ("TreeNode: Расходники"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrige_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["ID"].Visible = visibleColum;
                    GridView.Columns["id_type"].Visible = false;
                    GridView.Columns["id_room"].Visible = false;
                    GridView.Columns["id_model"].Visible = false;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = true;
                    WriteoffToolBut.Visible = true;
                    Ser5.Visible = true;

                    StoryToolBut.Visible = true;
                    Ser6.Visible = true;

                    break;

                case ("TreeNode: Аудитория"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectRoom_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["ID"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;

                    break;

                case ("TreeNode: Установки"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectSetup_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["id"].Visible = visibleColum;
                    GridView.Columns["id_printer"].Visible = false;
                    GridView.Columns["id_cartrige"].Visible = false;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;

                    break;

                case ("TreeNode: Перезаправлен"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectFill_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["id"].Visible = visibleColum;
                    GridView.Columns["id_cartrige"].Visible = false;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;

                    break;

                case ("TreeNode: Тип расходника"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrigeType_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;

                    break;

                case ("TreeNode: Модели"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel_ASI, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["ID"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    SetupToolBut.Visible = false;
                    WriteoffToolBut.Visible = false;
                    Ser5.Visible = false;

                    StoryToolBut.Visible = false;
                    Ser6.Visible = false;


                    break;
                default:

                    break;

            }
            db.closeConnection();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateTable();
        }

        private void AddToolBut_Click(object sender, EventArgs e)
        {

            TreeNode CurrentNode = treeView1.SelectedNode;

            Modif = "Добавить";

            switch (Convert.ToString(CurrentNode))
            {
                case ("TreeNode: Все"):


                    break;

                case ("TreeNode: Администратор"):


                    break;

                case ("TreeNode: Пользователь"):


                    break;

                case ("TreeNode: Роли"):


                    break;

                case ("TreeNode: Принтер"):
                    Modification.Printer.ModPrinter modPrinter = new Modification.Printer.ModPrinter(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Printer.Printer.Id = Convert.ToInt32(null);
                    DataBase.Entity.Printer.Printer.Name = null;
                    DataBase.Entity.Printer.Printer.Inventory = null;
                    DataBase.Entity.Printer.Printer.Id_room = Convert.ToInt32(null);
                    DataBase.Entity.Printer.Printer.Note = null;
                    DataBase.Entity.Printer.Printer.Id_model = Convert.ToInt32(null);

                    modPrinter.ShowDialog();
                    UpdateTable();
                    break;

                case ("TreeNode: Расходники"):

                    Modification.Consumable.ModConsumable modConsumable = new Modification.Consumable.ModConsumable(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Consumable.Consumable.Id = Convert.ToInt32(null);
                    DataBase.Entity.Consumable.Consumable.Name = null;
                    DataBase.Entity.Consumable.Consumable.Code = null;
                    DataBase.Entity.Consumable.Consumable.Bay_date = Convert.ToDateTime(DateTime.Today);
                    DataBase.Entity.Consumable.Consumable.Writeoff = Convert.ToBoolean(null);
                    DataBase.Entity.Consumable.Consumable.Note = null;
                    DataBase.Entity.Consumable.Consumable.Ready = Convert.ToBoolean(null);
                    DataBase.Entity.Consumable.Consumable.Id_cartrige_type = Convert.ToString(null);
                    DataBase.Entity.Consumable.Consumable.Id_room = Convert.ToString(null);
                    DataBase.Entity.Consumable.Consumable.Id_model = Convert.ToString(null);

                    modConsumable.ShowDialog();
                    UpdateTable();
                    break;

                case ("TreeNode: Аудитория"):

                    Modification.Room.ModRoom modAudit = new Modification.Room.ModRoom(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Audit.Audiences.Id = Convert.ToInt32(null);
                    DataBase.Entity.Audit.Audiences.Name = null;

                    modAudit.ShowDialog();
                    UpdateTable();

                    break;

                case ("TreeNode: Установки"):
                    Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Setup.Setup.Id = Convert.ToInt32(null);
                    DataBase.Entity.Setup.Setup.Id_printer = Convert.ToInt32(null);
                    DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(null);
                    DataBase.Entity.Setup.Setup.Start = null;
                    DataBase.Entity.Setup.Setup.End = null;
                    DataBase.Entity.Setup.Setup.Note = null;

                    modSetup.ShowDialog();
                    UpdateTable();
                    break;

                case ("TreeNode: Перезаправлен"):
                    Modification.Fill.ModFill modFill = new Modification.Fill.ModFill(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Fill.Fill.Id = Convert.ToInt32(null);
                    DataBase.Entity.Fill.Fill.Id_cartrige = Convert.ToInt32(null);
                    DataBase.Entity.Fill.Fill.Date = Convert.ToString(null);
                    DataBase.Entity.Fill.Fill.Note = null;

                    modFill.ShowDialog();
                    UpdateTable();

                    break;

                case ("TreeNode: Тип расходника"):
                    Modification.CartrigeType.ModCartrigeType modCartrigeType = new Modification.CartrigeType.ModCartrigeType(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.CartrigeType.CartrigeType.Id = Convert.ToInt32(null);
                    DataBase.Entity.CartrigeType.CartrigeType.Name = null;
                    DataBase.Entity.CartrigeType.CartrigeType.Refill = Convert.ToBoolean(null);


                    modCartrigeType.ShowDialog();
                    UpdateTable();

                    break;

                case ("TreeNode: Модели"):
                    Modification.Model.ModModel modModel = new Modification.Model.ModModel(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Model.Model.Id = Convert.ToInt32(null);
                    DataBase.Entity.Model.Model.Name = null;

                    modModel.ShowDialog();
                    UpdateTable();

                    break;
                default:
                    break;

            }

        }

        private void ModToolBut_Click(object sender, EventArgs e)
        {

            TreeNode CurrentNode = treeView1.SelectedNode;

            Modif = "Изменить";

            switch (Convert.ToString(CurrentNode))
            {
                case ("TreeNode: Все"):


                    break;

                case ("TreeNode: Администратор"):


                    break;

                case ("TreeNode: Пользователь"):


                    break;

                case ("TreeNode: Роли"):


                    break;

                case ("TreeNode: Принтер"):

                    if (GridView.CurrentRow != null)
                    {
                        Modification.Printer.ModPrinter modPrinter = new Modification.Printer.ModPrinter(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Printer.Printer.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                        DataBase.Entity.Printer.Printer.Name = GridView.CurrentRow.Cells["Название"].Value.ToString();
                        DataBase.Entity.Printer.Printer.Inventory = GridView.CurrentRow.Cells["Инвентарный номер"].Value.ToString();
                        DataBase.Entity.Printer.Printer.Id_room = Convert.ToInt32(GridView.CurrentRow.Cells["id_room"].Value);
                        DataBase.Entity.Printer.Printer.Note = GridView.CurrentRow.Cells["Заметки"].Value.ToString();
                        DataBase.Entity.Printer.Printer.Id_model = Convert.ToInt32(GridView.CurrentRow.Cells["id_model"].Value);

                        modPrinter.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }


                    break;

                case ("TreeNode: Расходники"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Consumable.ModConsumable modConsumable = new Modification.Consumable.ModConsumable(); //объявляем форму, которую желаем открыть

                        //modConsumable.IdСonsumableTextBox = Convert.ToString(GridView.CurrentRow.Cells["i"].Value.ToString());

                        DataBase.Entity.Consumable.Consumable.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                        DataBase.Entity.Consumable.Consumable.Name = GridView.CurrentRow.Cells["Название"].Value.ToString();
                        DataBase.Entity.Consumable.Consumable.Code = GridView.CurrentRow.Cells["Уникальный номер"].Value.ToString();
                        DataBase.Entity.Consumable.Consumable.Bay_date = Convert.ToDateTime(GridView.CurrentRow.Cells["Дата покупки"].Value);
                        DataBase.Entity.Consumable.Consumable.Writeoff = Convert.ToBoolean(GridView.CurrentRow.Cells["Списанный"].Value);
                        DataBase.Entity.Consumable.Consumable.Note = GridView.CurrentRow.Cells["Заметки"].Value.ToString();
                        DataBase.Entity.Consumable.Consumable.Ready = Convert.ToBoolean(GridView.CurrentRow.Cells["Готовность"].Value);
                        DataBase.Entity.Consumable.Consumable.Id_cartrige_type = Convert.ToString(GridView.CurrentRow.Cells["id_type"].Value);
                        DataBase.Entity.Consumable.Consumable.Id_room = Convert.ToString(GridView.CurrentRow.Cells["id_room"].Value);
                        DataBase.Entity.Consumable.Consumable.Id_model = Convert.ToString(GridView.CurrentRow.Cells["id_model"].Value);

                        modConsumable.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }


                    break;

                case ("TreeNode: Аудитория"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Room.ModRoom modAudit = new Modification.Room.ModRoom(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Audit.Audiences.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                        DataBase.Entity.Audit.Audiences.Name = GridView.CurrentRow.Cells["Название"].Value.ToString();

                        modAudit.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }


                    break;

                case ("TreeNode: Установки"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Setup.Setup.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                        DataBase.Entity.Setup.Setup.Id_printer = Convert.ToInt32(GridView.CurrentRow.Cells["id_printer"].Value);
                        DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["id_cartrige"].Value);
                        DataBase.Entity.Setup.Setup.Start = GridView.CurrentRow.Cells["Дата установки"].Value.ToString();
                        DataBase.Entity.Setup.Setup.End = GridView.CurrentRow.Cells["Дата снятия"].Value.ToString();
                        DataBase.Entity.Setup.Setup.Note = GridView.CurrentRow.Cells["Заметки"].Value.ToString();

                        modSetup.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }

                    break;

                case ("TreeNode: Перезаправлен"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Fill.ModFill modFill = new Modification.Fill.ModFill(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Fill.Fill.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                        DataBase.Entity.Fill.Fill.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["id_cartrige"].Value);
                        DataBase.Entity.Fill.Fill.Date = GridView.CurrentRow.Cells["Дата заправки"].Value.ToString();
                        DataBase.Entity.Fill.Fill.Note = GridView.CurrentRow.Cells["Заметки"].Value.ToString();

                        modFill.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }
                    break;

                case ("TreeNode: Тип расходника"):
                    Modification.CartrigeType.ModCartrigeType modCartrigeType = new Modification.CartrigeType.ModCartrigeType(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.CartrigeType.CartrigeType.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value.ToString());
                    DataBase.Entity.CartrigeType.CartrigeType.Name = GridView.CurrentRow.Cells["Название"].Value.ToString();
                    DataBase.Entity.CartrigeType.CartrigeType.Refill = Convert.ToBoolean(GridView.CurrentRow.Cells["Доступна перезапрака"].Value.ToString());

                    modCartrigeType.ShowDialog();
                    UpdateTable();

                    break;

                case ("TreeNode: Модели"):
                    Modification.Model.ModModel modModel = new Modification.Model.ModModel(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Model.Model.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value.ToString());
                    DataBase.Entity.Model.Model.Name = GridView.CurrentRow.Cells["Название"].Value.ToString();

                    modModel.ShowDialog();
                    UpdateTable();

                    break;
                default:
                    break;

            }
        }

        private void UpdateToolBut_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void SetupToolBut_Click(object sender, EventArgs e)
        {
            TreeNode CurrentNode = treeView1.SelectedNode;
            DB db = new DB();
            //Modif = "Установка";

            db.openConnection();
            switch (Convert.ToString(CurrentNode))
            {
                case ("TreeNode: Принтер"):


                    break;

                case ("TreeNode: Расходники"):
                    if (GridView.CurrentRow != null)
                    {
                        if (GridView.CurrentRow.Cells["Списанный"].Value.ToString() == "False")
                        {
                            if (GridView.CurrentRow.Cells["Готовность"].Value.ToString() == "True")
                            {
                                Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть
                                                                                                          //MessageBox.Show(GridView.CurrentRow.Cells["Установлен"].Value.ToString());
                                if (GridView.CurrentRow.Cells["Установлен"].Value.ToString() == "False")
                                {
                                    Modif = "Установка";

                                    //MessageBox.Show("Не установлен");
                                    DataBase.Entity.Setup.Setup.Id = Convert.ToInt32(null);
                                    DataBase.Entity.Setup.Setup.Id_printer = Convert.ToInt32(null);
                                    DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["Id"].Value);
                                    DataBase.Entity.Consumable.Consumable.Id_model = Convert.ToString(GridView.CurrentRow.Cells["id_model"].Value);
                                    DataBase.Entity.Setup.Setup.Start = null;
                                    DataBase.Entity.Setup.Setup.End = null;
                                    DataBase.Entity.Setup.Setup.Note = null;

                                }
                                else if (GridView.CurrentRow.Cells["Установлен"].Value.ToString() == "True")
                                {
                                    Modif = "Снятие";

                                    //MessageBox.Show("Установлен");
                                    DataBase.Entity.Setup.Setup.Id = Convert.ToInt32(null);
                                    DataBase.Entity.Setup.Setup.Id_printer = Convert.ToInt32(null);
                                    DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["Id"].Value);
                                    DataBase.Entity.Consumable.Consumable.Id_model = Convert.ToString(GridView.CurrentRow.Cells["id_model"].Value);

                                    DataBase.Entity.Setup.Setup.Start = null;
                                    DataBase.Entity.Setup.Setup.End = null;
                                    DataBase.Entity.Setup.Setup.Note = null;
                                }

                                modSetup.ShowDialog();
                                UpdateTable();
                            }else { MessageBox.Show("Данный расходник не готов для установки"); }
                        }else { MessageBox.Show("Расходник списан!"); return; }
                    }else { MessageBox.Show("Выделите строчку для редактирования"); }

                    break;
            }
            db.closeConnection();

        }

        private void DelToolBut_Click(object sender, EventArgs e)
        {
            TreeNode CurrentNode = treeView1.SelectedNode;
            DB db = new DB();
            if (GridView.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту запись: " +
                    "ID = " +
                    GridView.CurrentRow.Cells[0].Value.ToString() + "\nДанные после удаления, вернуть будет невозможно!",
                    "Подтвердите удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign
                    );

                db.openConnection();
                switch (Convert.ToString(CurrentNode))
                {
                    case ("TreeNode: Все"):


                        break;

                    case ("TreeNode: Администратор"):


                        break;

                    case ("TreeNode: Пользователь"):


                        break;

                    case ("TreeNode: Роли"):


                        break;

                    case ("TreeNode: Принтер"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM printer WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }

                        break;

                    case ("TreeNode: Расходники"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM cartrige WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }

                        break;

                    case ("TreeNode: Аудитория"):


                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM room WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }

                        break;

                    case ("TreeNode: Установки"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM setup WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }

                        break;

                    case ("TreeNode: Перезаправлен"):
                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM fill WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }

                        break;

                    case ("TreeNode: Тип расходника"):
                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM cartrige_type WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }
                        break;

                    case ("TreeNode: Модели"):
                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand DelCom = new MySqlCommand("DELETE FROM model WHERE `id` = @id", db.getConnection());
                            DelCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;

                            DelCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {

                        }
                        break;

                    default:
                        break;

                }
                db.closeConnection(); //Закрываем подключение к БД

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Выделите строку для удаления");
            }
        }

        private void WriteoffToolBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            if (GridView.CurrentRow != null)
            {
                if (GridView.CurrentRow.Cells["Списанный"].Value.ToString() == "False")
                {
                    DialogResult result = MessageBox.Show(
                        "Вы уверены, что хотите удалить эту запись: " +
                        "ID = " +
                        GridView.CurrentRow.Cells[0].Value.ToString() + "\nДанные после удаления, вернуть будет невозможно!",
                        "Подтвердите удаление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );
                    if (result == DialogResult.Yes)
                    {

                        db.openConnection();
                        MySqlCommand WriteoffCom = new MySqlCommand("UPDATE cartrige SET writeoff = @writeoff, ready = @ready, setup = @setup WHERE id = @idCartrige", db.getConnection());
                        WriteoffCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells["ID"].Value;
                        WriteoffCom.Parameters.Add("@writeoff", MySqlDbType.Int32).Value = Convert.ToBoolean(true);
                        WriteoffCom.Parameters.Add("@ready", MySqlDbType.Int32).Value = Convert.ToBoolean(false);
                        WriteoffCom.Parameters.Add("@setup", MySqlDbType.Int32).Value = Convert.ToBoolean(false);

                        WriteoffCom.ExecuteNonQuery();
                        MessageBox.Show("Расходник списан!");
                        UpdateTable();
                        db.closeConnection();
                    }
                }
                else { MessageBox.Show("Данный расходник уже списан!"); }
            }
            else { MessageBox.Show("Выделите строку для удаления"); }


        }

        private void StoryToolBut_Click(object sender, EventArgs e)
        {

            if (GridView.CurrentRow != null)
            {
                DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                DataBase.Entity.Fill.Fill.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);

                Forms.Modification.Story.ModStory modStory = new Modification.Story.ModStory();
                modStory.ShowDialog();

            }else { MessageBox.Show("Выделите строчку для редактирования"); }

        }

        private void Search()
        {


            if (GridView.RowCount != 0)
            {
                for (int i = GridView.CurrentCell.RowIndex + 1; i < GridView.RowCount; i++)
                {
                    string text = searchTextBox.Text.ToUpper();
                    for (int j = 0; j < GridView.ColumnCount; j++)
                        if (GridView.Rows[i].Cells[j].Value.ToString().ToUpper().Contains(text))
                        {
                            GridView.CurrentCell = GridView[0, i];
                            return;
                        }

                }
                MessageBox.Show(this, "Достигнут конец, больше совпадений не найдено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridView.CurrentCell = GridView[0, 0];
            }
            else
            {
                MessageBox.Show(this, "В таблице нет данных!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void обАккаунтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertGlobalVar_Users();
            /* DialogResult result = MessageBox.Show(
                text,
                "Об аккаунте",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );*/
        }

        private void InsertGlobalVar_Users()
        {
            DB db = new DB();
            db.openConnection();
            /* MySqlCommand idCom = new MySqlCommand("Select id From users WHERE Email = @email", db.getConnection());
             idCom.Parameters.Add("@email", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers;
             idCom.ExecuteNonQuery();
             MySqlDataReader reader = idCom.ExecuteReader();
             while (reader.Read()) { Convert.ToString(DataBase.Entity.Identification.DB_Users.IdUsers)= Convert.ToString(reader); };
             MessageBox.Show(Convert.ToString(DataBase.Entity.Identification.DB_Users.IdUsers));

             /* MySqlCommand fullnameCom = new MySqlCommand("Select fullname From users WHERE Email = @email", db.getConnection());
              fullnameCom.Parameters.Add("@email", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers;

              MySqlCommand dateCom = new MySqlCommand("Select DateOfBirth From users WHERE Email = @email", db.getConnection());
              dateCom.Parameters.Add("@email", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers;


              MySqlCommand phoneCom = new MySqlCommand("Select Phone From users WHERE Email = @email", db.getConnection());
              phoneCom.Parameters.Add("@email", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers;*/


            db.closeConnection();
        }

        private void ASI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотели бы выйти из профиля?",
                "Выход",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );

            if (result == DialogResult.Yes)
            {
                Forms.Identification.Authentication.Auth auth = new Forms.Identification.Authentication.Auth();
                this.Hide();
                auth.ShowDialog();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
        }


    }
}