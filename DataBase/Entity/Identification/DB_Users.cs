using System;

namespace ASI.DataBase.Entity.Identification
{
    public static class DB_Users
    {
        private static int idUsers;
        private static string fullnameUsers;
        private static DateTime dateOfBirthUsers;
        private static string phoneUsers;
        private static string emailUsers;
        private static string roleUsersForRole;

        public static int IdUsers { get => idUsers; set => idUsers = value; }
        public static string FullnameUsers { get => fullnameUsers; set => fullnameUsers = value; }
        public static DateTime DateOfBirthUsers { get => dateOfBirthUsers; set => dateOfBirthUsers = value; }
        public static string PhoneUsers { get => phoneUsers; set => phoneUsers = value; }
        public static string EmailUsers { get => emailUsers; set => emailUsers = value; }
        public static string RoleUsersForRole { get => roleUsersForRole; set => roleUsersForRole = value; }
    }
}
