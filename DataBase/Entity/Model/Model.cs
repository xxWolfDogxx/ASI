﻿
namespace ASI.DataBase.Entity.Model
{
    internal class Model
    {
        private static int id;
        private static string name;

        public static int Id { get => id; set => id = value; }
        public static string Name { get => name; set => name = value; }
    }
}
