
namespace ASI.DataBase.Entity.Identification
{
    public class DB_Role
    {
        private static int idRole;
        private static string roleForRole;

        public static int IdRole { get => idRole; set => idRole = value; }
        public static string RoleForRole { get => roleForRole; set => roleForRole = value; }
    }
}
