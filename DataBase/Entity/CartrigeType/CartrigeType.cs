using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.CartrigeType
{
    internal class CartrigeType
    {
        private static int id;
        private static string name;
        private static bool refill;

        public static int Id { get => id; set => id = value; }
        public static string Name { get => name; set => name = value; }
        public static bool Refill { get => refill; set => refill = value; }
    }
}
