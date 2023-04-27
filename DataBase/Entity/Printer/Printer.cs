using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Printer
{
    internal class Printer
    {
        private static string id;
        private static string Brand;
        private static string Model;
        private static string Invent;
        private static string Audit;
        private static string Doubl;
        private static string Drum;
        private static string Color;

        public static string Id { get => id; set => id = value; }
        public static string Brand1 { get => Brand; set => Brand = value; }
        public static string Model1 { get => Model; set => Model = value; }
        public static string Invent1 { get => Invent; set => Invent = value; }
        public static string Audit1 { get => Audit; set => Audit = value; }
        public static string Doubl1 { get => Doubl; set => Doubl = value; }
        public static string Drum1 { get => Drum; set => Drum = value; }
        public static string Color1 { get => Color; set => Color = value; }
    }
}
