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
    static class isPrinterExists
    {
        public static bool isPrinExists() // Проверка на повторного пользователя
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(DataBase.Scripts.ScriptMySql.script_isPrinterExists, db.getConnection());
            command.Parameters.Add("@printerExists", MySqlDbType.VarChar).Value = Forms.Modification.Printer.ModPrinter.PrinterInven;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (Forms.Modification.Printer.ModPrinter.PrinterInven == Forms.Modification.Printer.ModPrinter.PrinterInvenDB)
            {
                return false;
            }
            else if (table.Rows.Count >= 1)
            {
                MessageBox.Show("Инветарный номер принтера уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
