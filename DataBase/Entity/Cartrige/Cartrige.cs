using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Cartrige
{
    internal class Cartrige
    {
        private static string id;
        private static string Brand;
        private static string Model;
        private static string Number;
        private static string Status;
        private static string Refill;
        private static string Comment;

        public static string Id { get => id; set => id = value; }
        public static string Brand1 { get => Brand; set => Brand = value; }
        public static string Model1 { get => Model; set => Model = value; }
        public static string Number1 { get => Number; set => Number = value; }
        public static string Status1 { get => Status; set => Status = value; }
        public static string Refill1 { get => Refill; set => Refill = value; }
        public static string Comment1 { get => Comment; set => Comment = value; }
    }
}
