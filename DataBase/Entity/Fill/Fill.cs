using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Fill
{
    internal class Fill
    {
        private static int id;
        private static int id_cartrige;
        private static DateTime date;
        private static string note;

        public static int Id { get => id; set => id = value; }
        public static int Id_cartrige { get => id_cartrige; set => id_cartrige = value; }
        public static DateTime Date { get => date; set => date = value; }
        public static string Note { get => note; set => note = value; }
    }
}
