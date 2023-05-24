using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ASI.Forms.Modification.Fill
{
    public partial class ModFill : Form
    {
        public ModFill()
        {
            InitializeComponent();

            //
            //Блокируем ввод от руки в combox
            //
            RefillComBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModStatusWork_Load(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                switch (Forms.Main.ASI.Modif)
                {
                    case ("Изменить"):
                        LogoLabel.Text = "Изменение статуса";
                        AddFillBut.Visible = false;
                        ModFillBut.Visible = true;

                        IdFillTextBox.Text = DataBase.Entity.Fill.Fill.Id.ToString();
                        RefillComBox.SelectedValue = DataBase.Entity.Fill.Fill.Id_cartrige;
                        DateFillDatePicker.Text = DataBase.Entity.Fill.Fill.Date.ToString();
                        NoteFillTextBox.Text = DataBase.Entity.Fill.Fill.Note.ToString();

                        MySqlDataAdapter mySqlDataAdapter1 = new MySqlDataAdapter(DataBase.Scripts.ScriptMySql.script_SelectComBox1_ModFill, db.getConnection()); ;
                        DataTable tableCartrige1 = new DataTable();
                        mySqlDataAdapter1.Fill(tableCartrige1);

                        RefillComBox.DataSource = tableCartrige1;

                        RefillComBox.DisplayMember = "code";
                        RefillComBox.ValueMember = "id";

                        break;
                    case ("Добавить"):
                        LogoLabel.Text = "Добавление статуса";
                        AddFillBut.Visible = true;
                        ModFillBut.Visible = false;

                        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(DataBase.Scripts.ScriptMySql.script_SelectComBox_ModFill, db.getConnection()); ;
                        DataTable tableCartrige = new DataTable();
                        mySqlDataAdapter.Fill(tableCartrige);

                        db.openConnection();
                        if (tableCartrige.Rows.Count > 0)
                        {
                            RefillComBox.DataSource = tableCartrige;

                            RefillComBox.DisplayMember = "code";
                            RefillComBox.ValueMember = "id";
                        }
                        else
                        {
                            MessageBox.Show("Ничего перезаправлять не нужно");
                            this.Close();
                        }
                        db.closeConnection();

                        break;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddStatusWorkBut_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                db.openConnection(); //Открываем подключение к БД
                                     //Запрос на вставку данных с формы в базу данных
                MySqlCommand AddCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertFill_ModFill, db.getConnection());

                //Заносим данные в запрос
                AddCom.Parameters.Add("@cartrigeFill", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedValue);
                AddCom.Parameters.Add("@dateFill", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateFillDatePicker.Value);
                AddCom.Parameters.Add("@noteFill", MySqlDbType.VarChar).Value = NoteFillTextBox.Text;


                MySqlCommand UpdCartrigeCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertFillCartrigeReady_ModFill, db.getConnection());

                UpdCartrigeCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedValue);
                UpdCartrigeCom.Parameters.Add("@readyCartrige", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                //UpdCartrigeCom.Parameters.Add("@noteCartrige", MySqlDbType.VarChar).Value = "Перезаправлен";
                UpdCartrigeCom.Parameters.Add("@setupCartrige", MySqlDbType.UByte).Value = Convert.ToBoolean(false);


                db.closeConnection(); //Закрываем подключение к БД
                                      // Проверка на повторного пользователя
                db.openConnection();
                if (AddCom.ExecuteNonQuery() == 1 && UpdCartrigeCom.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Расходник перезаправлен");
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ModStatusWorkBut_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                db.openConnection(); //Открываем подключение к БД
                                     //Запрос на вставку данных с формы в базу данных
                MySqlCommand ModCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_UpdateFill_ModFill, db.getConnection());

                //Заносим данные в запрос
                ModCom.Parameters.Add("@idFill", MySqlDbType.Int32).Value = Convert.ToInt32(IdFillTextBox.Text);
                ModCom.Parameters.Add("@cartrigeFill", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedValue);
                ModCom.Parameters.Add("@dateFill", MySqlDbType.Date).Value = Convert.ToDateTime(value: DateFillDatePicker.Value);
                ModCom.Parameters.Add("@noteFill", MySqlDbType.VarChar).Value = NoteFillTextBox.Text;

                MySqlCommand UpdCartrigeCom = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_InsertFillCartrigeReady_ModFill, db.getConnection());

                UpdCartrigeCom.Parameters.Add("@idCartrige", MySqlDbType.Int32).Value = Convert.ToInt32(RefillComBox.SelectedValue);
                UpdCartrigeCom.Parameters.Add("@readyCartrige", MySqlDbType.UByte).Value = Convert.ToBoolean(true);
                //UpdCartrigeCom.Parameters.Add("@noteCartrige", MySqlDbType.VarChar).Value = "Перезаправлен";
                UpdCartrigeCom.Parameters.Add("@setupCartrige", MySqlDbType.UByte).Value = Convert.ToBoolean(false);


                db.closeConnection(); //Закрываем подключение к БД
                                      // Проверка на повторного пользователя
                db.openConnection();
                if (ModCom.ExecuteNonQuery() == 1 && UpdCartrigeCom.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Запись изменина");
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void CancleBut_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
