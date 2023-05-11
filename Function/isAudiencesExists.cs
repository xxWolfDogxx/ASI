using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ASI.Function
{
    static class isAudiencesExists
    {
        public static bool isAuditExists() // Проверка на повторного пользователя
        {

            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isRoomExists, db.getConnection());
                command.Parameters.Add("@roomExists", MySqlDbType.VarChar).Value = Forms.Modification.Room.ModRoom.Room;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (Forms.Modification.Room.ModRoom.Room == Forms.Modification.Room.ModRoom.RoomDB)
                {
                    return false;
                }
                else if (table.Rows.Count >= 1)
                {
                    MessageBox.Show("Аудитория уже существует");
                    return true;
                }
                else
                {
                    return false;
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
