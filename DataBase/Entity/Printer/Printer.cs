using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Printer
{
    internal class Printer
    {
        private static int id;
        private static string name;
        private static string inventory;
        private static int id_room;
        private static string note;
        private static int id_model;

        public static int Id { get => id; set => id = value; }
        public static string Name { get => name; set => name = value; }
        public static string Inventory { get => inventory; set => inventory = value; }
        public static int Id_room { get => id_room; set => id_room = value; }
        public static string Note { get => note; set => note = value; }
        public static int Id_model { get => id_model; set => id_model = value; }
    }
}
