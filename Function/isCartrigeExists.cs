using ASI.DataBase.ConnectionForMySQL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ASI.Function
{
    static class isCartrigeExists
    {
        public static bool isCarExists() // Проверка на повторного пользователя
        {

            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isConsumableExists, db.getConnection());
                command.Parameters.Add("@numberCartrige", MySqlDbType.VarChar).Value = Forms.Modification.Consumable.ModConsumable.numCartrige;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (Forms.Modification.Consumable.ModConsumable.numCartrige == Forms.Modification.Consumable.ModConsumable.numCartrigeDB)
                {
                    return false;
                }
                else if (table.Rows.Count >= 1)
                {
                    MessageBox.Show("Код расходника уже существует");
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
