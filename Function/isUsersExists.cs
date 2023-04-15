using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ASI.Function
{
    static class isUsersExists
    {
        public static bool IsUsersExist() // Проверка на повторного пользователя
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isUsersExists, db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = DataBase.Entity.Identification.DB_Users.EmailUsers;

            adapter.SelectCommand = command;
            adapter.Fill(table);

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
