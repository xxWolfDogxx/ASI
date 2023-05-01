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
using ASI.DataBase.ConnectionForMySQL;

namespace ASI.Forms.Main
{
    public partial class ASI : Form
    {
        internal static string Modif;
        //private string table;

        public ASI()
        {
            InitializeComponent();
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.AllowUserToAddRows = false;
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
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectAllUsers, db.getConnection());
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


                    break;

                case ("TreeNode: Администратор"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_Admin, db.getConnection());
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

                    break;

                case ("TreeNode: Пользователь"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectUser_User, db.getConnection());
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

                    break;

                case ("TreeNode: Роли"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideRole, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["role"].HeaderText = "Роли";

                    break;

                case ("TreeNode: Принтер"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuidePrinters, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме                 

                    //GridView.Columns[1].Selected = true;

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["Brand"].HeaderText = "Бренд";
                    GridView.Columns["Model"].HeaderText = "Модель";
                    GridView.Columns["InventoryNumber"].HeaderText = "Инвентарный номер";
                    GridView.Columns["Auditorium"].HeaderText = "Аудитория";
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
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
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
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["Auditorium"].HeaderText = "Корпус / Аудитория";
                    GridView.Columns["Comments"].HeaderText = "Комментарий";


                    break;

                case ("TreeNode: Установки"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectSetup, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);
                    GridView.Columns["Invent_printer"].HeaderText = "Инвентарный номер принтера";
                    GridView.Columns["Number_cartrige"].HeaderText = "Номер картриджа";
                    GridView.Columns["Data_setup"].HeaderText = "Дата установки картриджа";
                    GridView.Columns["Data_setup"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    GridView.Columns["Data_withdrawals"].HeaderText = "Дата снятия картриджа";
                    //GridView.Columns["Id_user"].HeaderText = "Пользователь";

                    break;

                case ("TreeNode: Статус работоспобности картриджа"):
                    GridView.ClearSelection(); //Чистим таблицу
                    mySql_dataAdapter.SelectCommand = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_SelectGuideRefill, db.getConnection());
                    mySql_dataAdapter.Fill(table); //Заполняем данными из запроса в виртуальную таблицу
                    GridView.DataSource = table; //Заполняем саму таблицу на форме

                    //Меняем название столбцов на руссифицированное
                    GridView.Columns["Id"].Visible = visibleColum;
                    GridView.Sort(GridView.Columns[0], ListSortDirection.Ascending);

                    GridView.Columns["Status"].HeaderText = "Рабочее состояние";

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

        private void ASI_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            

            treeView1.Nodes[0].Remove();

            treeView1.Nodes[1].Nodes[0].Checked=true;
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

                    DataBase.Entity.Printer.Printer.Id = null;
                    DataBase.Entity.Printer.Printer.Brand1 = null;
                    DataBase.Entity.Printer.Printer.Model1 = null;
                    DataBase.Entity.Printer.Printer.Invent1 = null;
                    DataBase.Entity.Printer.Printer.Audit1 = null;
                    DataBase.Entity.Printer.Printer.Doubl1 = null;
                    DataBase.Entity.Printer.Printer.Drum1 = null;
                    DataBase.Entity.Printer.Printer.Color1 = null;

                    modPrinter.ShowDialog();
                    UpdateTable();
                    break;

                case ("TreeNode: Картридж"):

                        Modification.Cartrige.ModCartrige modCartrige = new Modification.Cartrige.ModCartrige(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Cartrige.Cartrige.Id = null;
                        DataBase.Entity.Cartrige.Cartrige.Brand1 = null;
                        DataBase.Entity.Cartrige.Cartrige.Model1 = null;
                        DataBase.Entity.Cartrige.Cartrige.Number1 = null;
                        DataBase.Entity.Cartrige.Cartrige.Status1 = null;
                        DataBase.Entity.Cartrige.Cartrige.Refill1 = null;
                        DataBase.Entity.Cartrige.Cartrige.Comment1 = null;

                        modCartrige.ShowDialog();
                        UpdateTable();
                    break;

                case ("TreeNode: Аудитория"):

                    Modification.Audiences.ModAudit modAudit = new Modification.Audiences.ModAudit(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Audit.Audiences.Id = null;
                    DataBase.Entity.Audit.Audiences.Auditorium1 = null;
                    DataBase.Entity.Audit.Audiences.Comments1 = null;

                    modAudit.ShowDialog();
                    UpdateTable();

                    break;

                case ("TreeNode: Установки"):
                    Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.Setup.Setup.Id = null;
                    DataBase.Entity.Setup.Setup.IdPrinter = null ;
                    DataBase.Entity.Setup.Setup.IdCartrige = null;
                    DataBase.Entity.Setup.Setup.Data_setup = null;
                    DataBase.Entity.Setup.Setup.Data_withdrawals = null;

                    modSetup.ShowDialog();
                    UpdateTable();
                    break;

                case ("TreeNode: Статус работоспобности картриджа"):
                    Modification.StatusWork.ModStatusWork modStatusWork = new Modification.StatusWork.ModStatusWork(); //объявляем форму, которую желаем открыть

                    DataBase.Entity.StatusWork.StatusWork.Id = null;
                    DataBase.Entity.StatusWork.StatusWork.Status = null;

                    modStatusWork.ShowDialog();
                    UpdateTable();
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

                        DataBase.Entity.Printer.Printer.Id = GridView.CurrentRow.Cells[0].Value.ToString();
                        DataBase.Entity.Printer.Printer.Brand1 = GridView.CurrentRow.Cells[1].Value.ToString();
                        DataBase.Entity.Printer.Printer.Model1 = GridView.CurrentRow.Cells[2].Value.ToString();
                        DataBase.Entity.Printer.Printer.Invent1 = GridView.CurrentRow.Cells[3].Value.ToString();
                        DataBase.Entity.Printer.Printer.Audit1 = GridView.CurrentRow.Cells[4].Value.ToString();
                        DataBase.Entity.Printer.Printer.Doubl1 = GridView.CurrentRow.Cells[5].Value.ToString();
                        DataBase.Entity.Printer.Printer.Drum1 = GridView.CurrentRow.Cells[6].Value.ToString();
                        DataBase.Entity.Printer.Printer.Color1 = GridView.CurrentRow.Cells[7].Value.ToString();

                        modPrinter.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }
                   

                    break;

                case ("TreeNode: Картридж"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Cartrige.ModCartrige modCartrige = new Modification.Cartrige.ModCartrige(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Cartrige.Cartrige.Id = GridView.CurrentRow.Cells[0].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Brand1 = GridView.CurrentRow.Cells[2].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Model1 = GridView.CurrentRow.Cells[3].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Number1 = GridView.CurrentRow.Cells[1].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Status1 = GridView.CurrentRow.Cells[4].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Refill1 = GridView.CurrentRow.Cells[5].Value.ToString();
                        DataBase.Entity.Cartrige.Cartrige.Comment1 = GridView.CurrentRow.Cells[6].Value.ToString();

                        modCartrige.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }
                  

                    break;

                case ("TreeNode: Аудитория"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Audiences.ModAudit modAudit = new Modification.Audiences.ModAudit(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Audit.Audiences.Id = GridView.CurrentRow.Cells[0].Value.ToString();
                        DataBase.Entity.Audit.Audiences.Auditorium1 = GridView.CurrentRow.Cells[1].Value.ToString();
                        DataBase.Entity.Audit.Audiences.Comments1 = GridView.CurrentRow.Cells[2].Value.ToString();

                        modAudit.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }


                    break;

                case ("TreeNode: Установки"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.Setup.ModSetup modSetup = new Modification.Setup.ModSetup(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.Setup.Setup.Id = GridView.CurrentRow.Cells[0].Value.ToString(); 
                        DataBase.Entity.Setup.Setup.IdPrinter = GridView.CurrentRow.Cells[1].Value.ToString(); 
                        DataBase.Entity.Setup.Setup.IdCartrige = GridView.CurrentRow.Cells[2].Value.ToString(); 
                        DataBase.Entity.Setup.Setup.Data_setup = GridView.CurrentRow.Cells[3].Value.ToString(); 
                        DataBase.Entity.Setup.Setup.Data_withdrawals = GridView.CurrentRow.Cells[4].Value.ToString(); 

                        modSetup.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }

                    break;

                case ("TreeNode: Статус работоспобности картриджа"):
                    if (GridView.CurrentRow != null)
                    {
                        Modification.StatusWork.ModStatusWork modStatusWork = new Modification.StatusWork.ModStatusWork(); //объявляем форму, которую желаем открыть

                        DataBase.Entity.StatusWork.StatusWork.Id = GridView.CurrentRow.Cells[0].Value.ToString();
                        DataBase.Entity.StatusWork.StatusWork.Status = GridView.CurrentRow.Cells[1].Value.ToString();

                        modStatusWork.ShowDialog();
                        UpdateTable();
                    }
                    else { MessageBox.Show("Выделите строчку для редактирования"); }

                    break;

            }
        }

        private void UpdateToolBut_Click(object sender, EventArgs e)
        {
            UpdateTable();
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
                            MySqlCommand AddCom = new MySqlCommand("DELETE FROM printers WHERE `id` = @id", db.getConnection());
                            AddCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells[0].Value.ToString();

                            AddCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {
                            
                        }

                        break;

                    case ("TreeNode: Картридж"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand AddCom = new MySqlCommand("DELETE FROM cartrige WHERE `id` = @id", db.getConnection());
                            AddCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells[0].Value.ToString();

                            AddCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {
                            
                        }

                        break;

                    case ("TreeNode: Аудитория"):


                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand AddCom = new MySqlCommand("DELETE FROM audiences WHERE `id` = @id", db.getConnection());
                            AddCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells[0].Value.ToString();

                            AddCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {
                          
                        }

                        break;

                    case ("TreeNode: Установки"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand AddCom = new MySqlCommand("DELETE FROM setup WHERE `id` = @id", db.getConnection());
                            AddCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells[0].Value.ToString();

                            AddCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {
                         
                        }

                        break;

                    case ("TreeNode: Статус работоспобности картриджа"):

                        if (result == DialogResult.Yes)
                        {
                            MySqlCommand AddCom = new MySqlCommand("DELETE FROM refill WHERE `id` = @id", db.getConnection());
                            AddCom.Parameters.Add("@id", MySqlDbType.Int32).Value = GridView.CurrentRow.Cells[0].Value.ToString();

                            AddCom.ExecuteNonQuery();
                            MessageBox.Show("Запись удалена!");
                        }
                        else
                        {
                           
                        }

                        break;

                }
                db.closeConnection(); //Закрываем подключение к БД

                UpdateTable();
            }
            else
            {
                MessageBox.Show("Выделите строчку для удаления");
            }
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
