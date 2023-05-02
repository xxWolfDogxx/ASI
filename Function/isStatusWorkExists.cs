using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASI.Function
{
    static class isStatusWorkExists
    {
       /* public static bool isStatusExists() // Проверка на повторного пользователя
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isStatusWorkExists, db.getConnection());
            command.Parameters.Add("@statusWork", MySqlDbType.VarChar).Value = Forms.Modification.Fill.ModFill.statusWork;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (Forms.Modification.StatusWork.ModFill.statusWork == Forms.Modification.StatusWork.ModFill.statusWorkDB)
            {               
                return false;
            }
            else if (table.Rows.Count >= 1)
            {
                MessageBox.Show("Статус уже существует");
                return true;
            }
            else
            {               
                return false;
            }
        }*/
    }
}
