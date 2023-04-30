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
    static class isAudiencesExists
    {
        public static bool isAuditExists() // Проверка на повторного пользователя
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isAudiencesExists, db.getConnection());
            command.Parameters.Add("@auditExists", MySqlDbType.VarChar).Value = Forms.Modification.Audiences.ModAudit.Audit;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count >= 1)
            {
                MessageBox.Show("Аудитория уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
