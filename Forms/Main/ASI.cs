using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

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
            FiltrPanel.Visible = false;
            //FilterUpdateTable();
        }

        private void ASI_Load(object sender, EventArgs e)
        {

            try
            {
                switch (DataBase.Entity.Identification.DB_Users.RoleUsersForRole)
                {
                    case ("ROLE_ROOT"):

                        Sep2.Visible = true;
                        Sep3.Visible = true;
                        Sep4.Visible = true;
                        Ser5.Visible = true;
                        Ser6.Visible = true;
                        AddToolBut.Visible = true;
                        ModToolBut.Visible = true;
                        FiltrToolBut.Visible = true;
                        SetupToolBut.Visible = true;


                        break;

                    case ("ROLE_ADMIN"):
                        treeView1.Nodes[3].Remove();

                        Sep2.Visible = true;
                        Sep3.Visible = true;
                        Sep4.Visible = true;
                        Ser5.Visible = true;
                        Ser6.Visible = true;
                        AddToolBut.Visible = true;
                        ModToolBut.Visible = true;
                        FiltrToolBut.Visible = true;
                        SetupToolBut.Visible = true;

                        break;

                    case ("ROLE_USER"):
                        treeView1.Nodes[3].Remove();

                        Sep2.Visible = false;
                        Sep3.Visible = false;
                        Sep4.Visible = true;
                        Ser5.Visible = false;
                        Ser6.Visible = false;
                        AddToolBut.Visible = false;
                        ModToolBut.Visible = false;
                        FiltrToolBut.Visible = false;
                        SetupToolBut.Visible = false;

                        break;
                }

                treeView1.SelectedNode = treeView1.Nodes[0];
                treeView1.Focus();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UpdateTable()
        {

            try
            {
                bool visibleColum = false;

                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(); //Через класс MySqlDataAdapter отправляем запрос в БД для получения данных
                DataTable table = new DataTable(); //Создаем класс DataTable для того чтоб занести данные из запроса в виртуальную таблицу          
                TreeNode CurrentNode = treeView1.SelectedNode; // Отслеживаем фокус иерархии. Общий вид вывода информации TreeNode: Принтер

                GridView.CurrentCell = null;
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
                        FiltrPanel.Visible = false;

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
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Администратор"):
                        FiltrPanel.Visible = false;

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
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Пользователь"):
                        FiltrPanel.Visible = false;

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
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Роли"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Оборудование"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;



                        break;

                    case ("TreeNode: Расходники"):
                        FiltrPanel.Visible = true;

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
                        FiltrToolBut.Visible = true;

                        MySqlDataAdapter filtAdap = new MySqlDataAdapter();

                        DataTable tableModel = new DataTable();
                        DataTable tableType = new DataTable();
                        


                        //ModelComBox insert iteam
                        filtAdap.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectModel_ModConsumable, db.getConnection());
                        filtAdap.Fill(tableModel);



                        //ModelComBox insert iteam
                        filtAdap.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectCartrigeType_ModConsumable, db.getConnection());
                        filtAdap.Fill(tableType);



                        //Source for ComBox
                        ModelConsumableComBox.DataSource = tableModel;

                        TypeConsumableComBox.DataSource = tableType;



                        //Отбираем все значения что хотим показать и те что хотим скрыть
                        ModelConsumableComBox.DisplayMember = "name_model";
                        ModelConsumableComBox.ValueMember = "id_model";

                        TypeConsumableComBox.DisplayMember = "name_type";
                        TypeConsumableComBox.ValueMember = "id_type";

                        DataRow dataRowModel = tableModel.NewRow();
                        dataRowModel["id_model"] = "0";
                        dataRowModel["name_model"] = "---";
                        tableModel.Rows.Add(dataRowModel);

                        DataRow dataRowType = tableType.NewRow();
                        dataRowType["id_type"] = "0";
                        dataRowType["name_type"] = "---";
                        tableType.Rows.Add(dataRowType);

                        ModelConsumableComBox.SelectedValue = 0;
                        TypeConsumableComBox.SelectedValue = 0;
                        WriteoffConsumableComBox.SelectedIndex = 0;
                        ReadyConsumableComBox.SelectedIndex = 0;
                        SetupConsumComBox.SelectedIndex = 0;



                        break;

                    case ("TreeNode: Местоположение"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Установки"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Перезаправлен"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Типы расходников"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Модели"):
                        FiltrPanel.Visible = false;

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
                        FiltrToolBut.Visible = false;

                        break;
                    default:

                        break;

                }


                db.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterUpdateTable()
        {
            try
            {
                string _and = "";
                string query = null;
                string filt_1;
                string filt_2;
                string filt_3;
                string filt_4;
                string filt_5;
                bool writeoffBool;
                bool readyBool;
                bool setupBool;



                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(); //Через класс MySqlDataAdapter отправляем запрос в БД для получения данных
                DataTable table = new DataTable(); //Создаем класс DataTable для того чтоб занести данные из запроса в виртуальную таблицу          
                TreeNode CurrentNode = treeView1.SelectedNode; // Отслеживаем фокус иерархии. Общий вид вывода информации TreeNode: Принтер

                GridView.CurrentCell = null;
                //
                //Заполняем таблицу данными с запросов
                //
                //-----------------------------------------------------------

                db.openConnection();

                query = DataBase.Scripts.ScriptMySql.script_SelectCartrige_ASI + " WHERE ";

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

                    case ("TreeNode: Оборудование"):




                        break;

                    case ("TreeNode: Расходники"):

                        if (Convert.ToString(WriteoffConsumableComBox.SelectedItem) == "Да")
                        {
                            var _convertStringToBoolWriteoff = true;
                            writeoffBool = _convertStringToBoolWriteoff;

                        }
                        else
                        {
                            var _convertStringToBoolWriteoff = false;
                            writeoffBool = _convertStringToBoolWriteoff;
                        }
                        
                        if (Convert.ToString(SetupConsumComBox.SelectedItem) == "Да")
                        {
                            var _convertStringToBoolSetup = true;
                            setupBool = _convertStringToBoolSetup;

                        }
                        else
                        {
                            var _convertStringToBoolSetup = false;
                            setupBool = _convertStringToBoolSetup;
                        }

                        if (Convert.ToString(ReadyConsumableComBox.SelectedItem) == "Да")
                        {
                            var _convertStringToBoolReady = true;
                            readyBool = _convertStringToBoolReady;

                        }
                        else
                        {
                            var _convertStringToBoolReady = false;
                            readyBool = _convertStringToBoolReady;
                        }

                        //-----------------------------------------------------------------------------------

                        if (ModelConsumableComBox.SelectedValue.ToString() != "0")
                        {
                            filt_1 = " id_model " + "=" + ModelConsumableComBox.SelectedValue.ToString();
                            query = query + _and + filt_1;
                            _and = " AND ";
                        }
                        else
                        {

                        }
                        if (TypeConsumableComBox.SelectedValue.ToString() != "0")
                        {
                            filt_2 = " id_cartrige_type " + "=" + TypeConsumableComBox.SelectedValue.ToString();
                            query = query + _and + filt_2;
                            _and = " AND ";
                        }
                        else
                        {

                        }
                        if (WriteoffConsumableComBox.SelectedIndex != 0)
                        {
                            filt_3 = " writeoff " + "=" + writeoffBool;
                            query = query + _and + filt_3;
                            _and = " AND ";
                        }
                        else
                        {

                        }
                        if (ReadyConsumableComBox.SelectedIndex != 0)
                        {
                            filt_4 = " ready " + "=" + readyBool;
                            query = query + _and + filt_4;
                            _and = " AND ";
                        }
                        else
                        {

                        }
                        if (SetupConsumComBox.SelectedIndex != 0)
                        {
                            filt_5 = " setup " + "=" + setupBool;
                            query = query + _and + filt_5;
                            _and = " AND ";
                        }
                        else
                        {


                        }

                        MessageBox.Show(query);
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand(query, db.getConnection());
                        mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                        GridView.DataSource = table; //Заполняем саму таблицу на форме                 

                        //Меняем название столбцов на руссифицированное
                        GridView.Columns["ID"].Visible = false;
                        GridView.Columns["id_room"].Visible = false;
                        GridView.Columns["id_model"].Visible = false;
                        GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;

                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = true;
                        break;

                    case ("TreeNode: Местоположение"):

                        break;

                    case ("TreeNode: Установки"):

                        break;

                    case ("TreeNode: Перезаправлен"):

                        break;

                    case ("TreeNode: Типы расходников"):

                        break;

                    case ("TreeNode: Модели"):


                        break;
                    default:
                        UpdateTable();
                        break;

                }


                db.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                UpdateTable();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToolBut_Click(object sender, EventArgs e)
        {

            try
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

                    case ("TreeNode: Оборудование"):
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

                    case ("TreeNode: Местоположение"):

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

                    case ("TreeNode: Типы расходников"):
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ModToolBut_Click(object sender, EventArgs e)
        {

            try
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

                    case ("TreeNode: Оборудование"):

                        if (GridView.CurrentRow != null)
                        {
                            Modification.Printer.ModPrinter modPrinter = new Modification.Printer.ModPrinter(); //объявляем форму, которую желаем открыть

                            DataBase.Entity.Printer.Printer.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                            DataBase.Entity.Printer.Printer.Name = GridView.CurrentRow.Cells["Имя"].Value.ToString();
                            DataBase.Entity.Printer.Printer.Inventory = GridView.CurrentRow.Cells["Инв. №"].Value.ToString();
                            DataBase.Entity.Printer.Printer.Id_room = Convert.ToInt32(GridView.CurrentRow.Cells["id_room"].Value);
                            DataBase.Entity.Printer.Printer.Note = GridView.CurrentRow.Cells["Примечание"].Value.ToString();
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
                            DataBase.Entity.Consumable.Consumable.Name = GridView.CurrentRow.Cells["Имя"].Value.ToString();
                            DataBase.Entity.Consumable.Consumable.Code = GridView.CurrentRow.Cells["Код"].Value.ToString();
                            DataBase.Entity.Consumable.Consumable.Bay_date = Convert.ToDateTime(GridView.CurrentRow.Cells["Дата"].Value);
                            DataBase.Entity.Consumable.Consumable.Writeoff = Convert.ToBoolean(GridView.CurrentRow.Cells["Списан"].Value);
                            DataBase.Entity.Consumable.Consumable.Note = GridView.CurrentRow.Cells["Примечание"].Value.ToString();
                            DataBase.Entity.Consumable.Consumable.Ready = Convert.ToBoolean(GridView.CurrentRow.Cells["Готов"].Value);
                            DataBase.Entity.Consumable.Consumable.Id_cartrige_type = Convert.ToString(GridView.CurrentRow.Cells["id_type"].Value);
                            DataBase.Entity.Consumable.Consumable.Id_room = Convert.ToString(GridView.CurrentRow.Cells["id_room"].Value);
                            DataBase.Entity.Consumable.Consumable.Id_model = Convert.ToString(GridView.CurrentRow.Cells["id_model"].Value);

                            modConsumable.ShowDialog();
                            UpdateTable();
                        }
                        else { MessageBox.Show("Выделите строчку для редактирования"); }


                        break;

                    case ("TreeNode: Местоположение"):
                        if (GridView.CurrentRow != null)
                        {
                            Modification.Room.ModRoom modAudit = new Modification.Room.ModRoom(); //объявляем форму, которую желаем открыть

                            DataBase.Entity.Audit.Audiences.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                            DataBase.Entity.Audit.Audiences.Name = GridView.CurrentRow.Cells["Имя"].Value.ToString();

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
                            DataBase.Entity.Fill.Fill.Note = GridView.CurrentRow.Cells["Примечание"].Value.ToString();

                            modFill.ShowDialog();
                            UpdateTable();
                        }
                        else { MessageBox.Show("Выделите строчку для редактирования"); }
                        break;

                    case ("TreeNode: Типы расходников"):
                        Modification.CartrigeType.ModCartrigeType modCartrigeType = new Modification.CartrigeType.ModCartrigeType(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.CartrigeType.CartrigeType.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value.ToString());
                        DataBase.Entity.CartrigeType.CartrigeType.Name = GridView.CurrentRow.Cells["Имя"].Value.ToString();
                        DataBase.Entity.CartrigeType.CartrigeType.Refill = Convert.ToBoolean(GridView.CurrentRow.Cells["Перезаправка"].Value.ToString());

                        modCartrigeType.ShowDialog();
                        UpdateTable();

                        break;

                    case ("TreeNode: Модели"):
                        Modification.Model.ModModel modModel = new Modification.Model.ModModel(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Model.Model.Id = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value.ToString());
                        DataBase.Entity.Model.Model.Name = GridView.CurrentRow.Cells["Имя"].Value.ToString();

                        modModel.ShowDialog();
                        UpdateTable();

                        break;
                    default:
                        break;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateToolBut_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void SetupToolBut_Click(object sender, EventArgs e)
        {

            try
            {
                TreeNode CurrentNode = treeView1.SelectedNode;
                DB db = new DB();
                //Modif = "Установка";

                db.openConnection();
                switch (Convert.ToString(CurrentNode))
                {
                    case ("TreeNode: Оборудование"):


                        break;

                    case ("TreeNode: Расходники"):
                        if (GridView.CurrentRow != null)
                        {
                            if (GridView.CurrentRow.Cells["Списан"].Value.ToString() == "False")
                            {
                                if (GridView.CurrentRow.Cells["Готов"].Value.ToString() == "True")
                                {
                                    Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть
                                                                                                              //MessageBox.Show(GridView.CurrentRow.Cells["Установлен"].Value.ToString());
                                    if (GridView.CurrentRow.Cells["Установ."].Value.ToString() == "False")
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
                                }
                                else { MessageBox.Show("Данный расходник не готов для установки"); }
                            }
                            else { MessageBox.Show("Расходник списан!"); return; }
                        }
                        else { MessageBox.Show("Выделите строчку для редактирования"); }

                        break;
                }
                db.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void DelToolBut_Click(object sender, EventArgs e)
        {

            try
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

                        case ("TreeNode: Оборудование"):

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

                        case ("TreeNode: Местоположение"):


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

                        case ("TreeNode: Типы расходников"):
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void WriteoffToolBut_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                if (GridView.CurrentRow != null)
                {
                    if (GridView.CurrentRow.Cells["Списан"].Value.ToString() == "False")
                    {
                        DialogResult result = MessageBox.Show(
                            "Вы уверены, что хотите списать данный расходник: " +
                            "ID = " +
                            GridView.CurrentRow.Cells[0].Value.ToString(),
                            "Подтвердите списание",
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
                else { MessageBox.Show("Выделите строку для списания"); }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void StoryToolBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView.CurrentRow != null)
                {
                    DataBase.Entity.Setup.Setup.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);
                    DataBase.Entity.Fill.Fill.Id_cartrige = Convert.ToInt32(GridView.CurrentRow.Cells["ID"].Value);

                    Forms.Modification.Story.ModStory modStory = new Modification.Story.ModStory();
                    modStory.ShowDialog();

                }
                else { MessageBox.Show("Выделите строчку для редактирования"); }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void Search()
        {
            try
            {
                bool visibleColum = false;

                DataBase.ConnectionForMySQL.DB db = new DataBase.ConnectionForMySQL.DB();
                MySqlDataAdapter mySql_dataAdapter = new MySqlDataAdapter(); //Через класс MySqlDataAdapter отправляем запрос в БД для получения данных
                DataTable table = new DataTable(); //Создаем класс DataTable для того чтоб занести данные из запроса в виртуальную таблицу          
                TreeNode CurrentNode = treeView1.SelectedNode; // Отслеживаем фокус иерархии. Общий вид вывода информации TreeNode: Принтер

                GridView.CurrentCell = null;
                //
                //Заполняем таблицу данными с запросов
                //
                //-----------------------------------------------------------
                switch (Convert.ToString(CurrentNode))
                {
                    case ("TreeNode: Все"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT users.Id, users.FullName, users.DateOfBirth, users.Phone, users.Email, roles.role FROM users INNER JOIN roles ON users.role = roles.id " +
                            "WHERE CONCAT(users.Id, users.FullName, users.DateOfBirth, users.Phone, users.Email, roles.role) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
                        mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                        GridView.DataSource = table; //Заполняем саму таблицу на форме



                        //Меняем название столбцов на руссифицированное
                        GridView.Columns["Id"].Visible = visibleColum;
                        GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                        GridView.Columns["FullName"].HeaderText = "ФИО";
                        GridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                        GridView.Columns["Phone"].HeaderText = "Номер телефона";
                        GridView.Columns["Email"].HeaderText = "Эл. почта";
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Администратор"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT users.Id,users.FullName,users.DateOfBirth,users.Phone,users.Email,roles.role FROM users INNER JOIN roles ON users.role = roles.id WHERE CONCAT(users.Id,users.FullName,users.DateOfBirth,users.Phone,users.Email,roles.role) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Пользователь"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT users.Id,users.FullName,users.DateOfBirth,users.Phone,users.Email,roles.role FROM users INNER JOIN roles ON users.role = roles.id WHERE CONCAT (users.Id,users.FullName,users.DateOfBirth,users.Phone,users.Email,roles.role) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        // GridView.Columns["Password"].Visible = false;
                        GridView.Columns["Role"].HeaderText = "Роль";

                        SetupToolBut.Visible = false;
                        WriteoffToolBut.Visible = false;
                        Ser5.Visible = false;
                        StoryToolBut.Visible = false;
                        Ser6.Visible = false;
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Роли"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT role.id, role.role FROM `roles` WHERE CONCAT (role.id, role.role)  LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Оборудование"):
                        GridView.ClearSelection(); //Чистим таблицу
                        MySqlCommand command = new MySqlCommand("SELECT printer.id AS ID, printer.name AS Имя, printer.inventory AS 'Инв. №', printer.id_room, room.name AS Аудитория, printer.note AS Примечание, printer.id_model, model.name AS Модель " +
                                        "FROM printer " +
                                        "INNER JOIN room ON printer.id_room = room.id " +
                                        "INNER JOIN model ON printer.id_model = model.id " +
                                        "WHERE CONCAT(printer.id, printer.name, printer.inventory, printer.id_room, room.name, printer.note, printer.id_model, model.name) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
                        mySql_dataAdapter.SelectCommand = command;
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
                        FiltrToolBut.Visible = true;



                        break;

                    case ("TreeNode: Расходники"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT cartrige.id AS ID, cartrige.name AS Имя, cartrige.code AS 'Код', cartrige.buy_date AS 'Дата', cartrige.writeoff AS Списан, cartrige.note AS Примечание, cartrige.ready AS Готов, cartrige.setup AS 'Установ.', cartrige.id_cartrige_type AS 'id_type',cartrige_type.name AS 'Тип', cartrige.id_room, room.name AS Место, cartrige.id_model, model.name AS 'Совместим'" +
                "FROM cartrige " +
                "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id " +
                "INNER JOIN room ON cartrige.id_room = room.Id " +
                "INNER JOIN model ON cartrige.id_model = model.id " +
                "WHERE CONCAT ( cartrige.id, cartrige.name, cartrige.code, cartrige.buy_date, cartrige.writeoff, cartrige.note, cartrige.ready, cartrige.setup, cartrige.id_cartrige_type,cartrige_type.name, cartrige.id_room, room.name, cartrige.id_model, model.name) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = true;


                        break;

                    case ("TreeNode: Местоположение"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT room.id AS 'ID', room.name AS 'Имя' FROM `room` WHERE CONCAT (room.id, room.name) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Установки"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT setup.id AS 'ID', printer.id AS id_printer, printer.name AS 'Принтер', cartrige.id AS id_cartrige, cartrige.code AS 'Ррасходник', setup.start AS 'Дата установки', setup.end AS 'Дата снятия', setup.note AS 'Заметки' " +
                "FROM setup " +
                "INNER JOIN printer ON setup.id_printer = printer.id " +
                "INNER JOIN cartrige ON setup.id_cartrige = cartrige.id " +
                "WHERE CONCAT (printer.id, printer.name, cartrige.id, cartrige.code, setup.start, setup.end, setup.note) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = true;
                        break;

                    case ("TreeNode: Перезаправлен"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT fill.id AS 'ID', cartrige.id AS 'id_cartrige', cartrige.code AS 'Код расходника', fill.date AS 'Дата заправки', fill.note AS 'Примечание' " +
                "FROM fill " +
                "INNER JOIN cartrige ON fill.id_cartrige = cartrige.id " +
                "WHERE CONCAT (fill.id, cartrige.id, cartrige.code, fill.date, fill.note) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = true;
                        break;

                    case ("TreeNode: Типы расходников"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT cartrige_type.id AS 'ID', cartrige_type.name AS 'Имя', cartrige_type.refill AS 'Перезаправка' FROM `cartrige_type` WHERE CONCAT (cartrige_type.id, cartrige_type.name, cartrige_type.refill)  LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = false;
                        break;

                    case ("TreeNode: Модели"):
                        GridView.ClearSelection(); //Чистим таблицу
                        mySql_dataAdapter.SelectCommand = new MySqlCommand("SELECT model.id AS 'ID', model.name AS 'Имя' FROM `model` WHERE CONCAT (model.id, model.name) LIKE '%" + searchTextBox.Text + "%'", db.getConnection());
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
                        FiltrToolBut.Visible = false;

                        break;
                    default:

                        break;

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Search();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            try
            {
                Search();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
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
            /*  DB db = new DB();
              db.openConnection();

              MySqlCommand mySqlCommand = new MySqlCommand("Select * From users INNER JOIN room ON printer.id_room = room.id  WHERE Email = @email ", db.getConnection());
              mySqlCommand.Parameters.Add("@email", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Auth.EmailAuthForUsers;

              MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
              DataTable user = new DataTable();
              mySqlDataAdapter.Fill(user);

              foreach (DataRow row in user.Rows)
              {
                  DataBase.Entity.Identification.DB_Users.IdUsers = row["id"].ToString();
                  DataBase.Entity.Identification.DB_Users.FullnameUsers = row["FullName"].ToString();
                  DataBase.Entity.Identification.DB_Users.PhoneUsers = row["id_cartrige"].ToString();
                  DataBase.Entity.Identification.DB_Users.EmailUsers = row["start"].ToString();
                  DataBase.Entity.Identification.DB_Users.RoleUsersForRole = row["end"].ToString();

              }

              if (setup.Rows.Count == 1)
              {
                  //  
                  //Заносим в поля данные
                  //
                  MessageBox.Show(id_printer_DB);
                  IdSetupTextBox.Text = id_DB;
                  CartrigeSetupComBox.SelectedValue = id_cartrige_DB;
                  PrinterSetupComBox.SelectedValue = id_printer_DB;
                  DateStartDatePicker.Text = start_DB;
                  DateEndDatePicker.Text = end_DB;
                  NoteSetupTextBox.Text = note_DB;

                  endGB.Visible = true;

                  IdSetupTextBox.Enabled = false;
                  CartrigeSetupComBox.Enabled = false;
                  PrinterSetupComBox.Enabled = false;
                  DateStartDatePicker.Enabled = false;
                  DateEndDatePicker.Enabled = true;
                  NoteSetupTextBox.Enabled = true;

              }
              else if (setup.Rows.Count > 1)
              {
                  MessageBox.Show("Этот картридж установлен одновременно более одного раза\n" +
                      "Произведите поправку в истории установок вручную");
                  this.Close();
              }
              else MessageBox.Show("ModSetup Error");
              db.closeConnection();*/



        }

        private void ASI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        internal void FiltrToolBut_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Visible == false)
            {
                FiltrPanel.Visible = true;

            }
            else if (FiltrPanel.Visible == true)
            {
                FiltrPanel.Visible = false;
            }
        }

        private void FiltrBut_Click(object sender, EventArgs e)
        {
            FilterUpdateTable();
        }

        private void ClearFiltrBut_Click(object sender, EventArgs e)
        {
            ModelConsumableComBox.SelectedIndex = 1;
            TypeConsumableComBox.SelectedIndex = 1;
            WriteoffConsumableComBox.SelectedIndex = 1;
            ReadyConsumableComBox.SelectedIndex = 1;
            SetupConsumComBox.SelectedIndex = 1;
            UpdateTable();
        }
    }
}