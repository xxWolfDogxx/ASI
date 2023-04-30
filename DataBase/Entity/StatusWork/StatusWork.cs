using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.StatusWork
{
    internal class StatusWork
    {
        private static string id;
        private static string status;

        public static string Id { get => id; set => id = value; }
        public static string Status { get => status; set => status = value; }
    }
}
