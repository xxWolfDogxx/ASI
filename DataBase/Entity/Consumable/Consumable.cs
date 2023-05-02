using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Consumable
{
    internal class Consumable
    {
        private static int id;
        private static string name;
        private static string code;
        private static DateTime bay_date;
        private static bool writeoff;
        private static string note;
        private static bool ready;
        private static int id_cartrige_type;
        private static int id_room;
        private static int id_model;

        public static int Id { get => id; set => id = value; }
        public static string Name { get => name; set => name = value; }
        public static string Code { get => code; set => code = value; }
        public static DateTime Bay_date { get => bay_date; set => bay_date = value; }
        public static bool Writeoff { get => writeoff; set => writeoff = value; }
        public static string Note { get => note; set => note = value; }
        public static bool Ready { get => ready; set => ready = value; }
        public static int Id_cartrige_type { get => id_cartrige_type; set => id_cartrige_type = value; }
        public static int Id_room { get => id_room; set => id_room = value; }
        public static int Id_model { get => id_model; set => id_model = value; }
    }
}
