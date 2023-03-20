using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Entity.Identification
{
    public class DB_Auth
    {
        private static int idAuth;
        private static int idForUsers;
        private static string emailAuthForUsers;
        private static string passwordAuth;

        public static int IdAuth { get => idAuth; set => idAuth = value; }
        public static int IdForUsers { get => idForUsers; set => idForUsers = value; }
        public static string EmailAuthForUsers { get => emailAuthForUsers; set => emailAuthForUsers = value; }
        public static string PasswordAuth { get => passwordAuth; set => passwordAuth = value; }
    }
}
