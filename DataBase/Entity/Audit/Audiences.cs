using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Audit
{
    internal class Audiences
    {
        private static string id;
        private static string Auditorium;
        private static string Comments;

        public static string Id { get => id; set => id = value; }
        public static string Auditorium1 { get => Auditorium; set => Auditorium = value; }
        public static string Comments1 { get => Comments; set => Comments = value; }
    }
}
