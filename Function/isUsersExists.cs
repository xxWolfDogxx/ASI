using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ASI.Function
{
    static class isUsersExists
    {
        public static bool IsUsersExist() // Проверка на повторного пользователя
        {
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isUsersExists, db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Users.EmailUsers;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                //MessageBox.Show(Forms.Identification.Registration.Regs.numPhone);
                //MessageBox.Show(Forms.Identification.Registration.Regs.numPhoneDB);
               // MessageBox.Show(Forms.Identification.Registration.Regs.numEmail);
                //MessageBox.Show(Forms.Identification.Registration.Regs.numEmailDB);
                if (Forms.Identification.Registration.Regs.numEmail == Forms.Identification.Registration.Regs.numEmailDB)
                {
                    return false;
                }
                else
                {
                    if (Forms.Identification.Registration.Regs.numPhone == Forms.Identification.Registration.Regs.numPhoneDB)
                    {
                        return false;
                    }
                    else
                    {
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Пользователь существует");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }
    }
}
