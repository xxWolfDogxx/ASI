
namespace ASI.DataBase.Entity.Fill
{
    internal class Fill
    {
        private static int id;
        private static int id_cartrige;
        private static string date;
        private static string note;

        public static int Id { get => id; set => id = value; }
        public static int Id_cartrige { get => id_cartrige; set => id_cartrige = value; }
        
        public static string Note { get => note; set => note = value; }
        public static string Date { get => date; set => date = value; }
    }
}
