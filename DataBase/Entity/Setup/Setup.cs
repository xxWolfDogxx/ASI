
namespace ASI.DataBase.Entity.Setup
{
    internal class Setup
    {
        private static int id;
        private static int id_printer;
        private static int id_cartrige;
        private static string start;
        private static string end;
        private static string note;

        public static int Id { get => id; set => id = value; }
        public static int Id_printer { get => id_printer; set => id_printer = value; }
        public static int Id_cartrige { get => id_cartrige; set => id_cartrige = value; }
        public static string Start { get => start; set => start = value; }
        public static string End { get => end; set => end = value; }
        public static string Note { get => note; set => note = value; }
    }
}
