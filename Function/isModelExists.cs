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
    static class isModelExists
    {
        public static bool isModExists() // Проверка на повторного пользователя
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isRoomExists, db.getConnection());
            command.Parameters.Add("@nameExists", MySqlDbType.VarChar).Value = Forms.Modification.Room.ModRoom.Room;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (Forms.Modification.Model.ModModel.Model == Forms.Modification.Model.ModModel.ModelDB)
            {
                return false;
            }
            else if (table.Rows.Count >= 1)
            {
                MessageBox.Show("Название модели уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
