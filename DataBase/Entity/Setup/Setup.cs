using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Setup
{
    internal class Setup
    {
        private static string id;
        private static string idPrinter;
        private static string idCartrige;
        private static string data_setup;
        private static string data_withdrawals;
        private static string id_user;

        public static string Id { get => id; set => id = value; }
        public static string IdPrinter { get => idPrinter; set => idPrinter = value; }
        public static string IdCartrige { get => idCartrige; set => idCartrige = value; }
        public static string Data_setup { get => data_setup; set => data_setup = value; }
        public static string Data_withdrawals { get => data_withdrawals; set => data_withdrawals = value; }
        public static string Id_user { get => id_user; set => id_user = value; }
    }
}
