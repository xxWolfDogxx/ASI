﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Setup
{
    internal class Setup
    {
        private static int id;
        private static int id_printer;
        private static int id_cartrige;
        private static DateTime start;
        private static DateTime end;
        private static string note;

        public static int Id { get => id; set => id = value; }
        public static int Id_printer { get => id_printer; set => id_printer = value; }
        public static int Id_cartrige { get => id_cartrige; set => id_cartrige = value; }
        public static DateTime Start { get => start; set => start = value; }
        public static string Note { get => note; set => note = value; }
        public static DateTime End { get => end; set => end = value; }
    }
}
