using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.DataBase.Scripts
{
    public static class ScriptMySql
    {
        //
        //Скрипты для авторизации
        //
        //Идентификация пользователей
        internal static string script_SelectUser = "SELECT * FROM `users` WHERE `email` = @uL AND `password` = @uP;";
        //Запрос на вытаскивание роли пользователя
        internal static string script_SelectUserRole = $"SELECT `Role` FROM `users` WHERE `Email` = @uL;";
        //Запрос на вытаскивание пароля пользователя, по логину
        internal static string script_SelectUserPassDB = $"SELECT `Password` FROM `users` WHERE `Email` = @uPL;";

        //
        //Скрипты для регистрации
        //
        //Идентификация пользователей
        internal static string script_InsertUser = "INSERT INTO `users` (`FullName`, `DateOfBirth`, `Phone`, `Email`, `Password`, `Role`) VALUES (@fio, @dOb, @phone, @email, @pass, @role)";

        //
        //Скрипты для функций
        //
        //Запрос на сверку введенной почты с повторами в базе данных
        internal static string script_isUsersExists = $"SELECT * FROM `users` WHERE `Email` = @uL";

        //
        //Скрипты для основной формы
        //
        //Запрос на справочник принтеров
        internal static string script_SelectGuidePrinters = $"SELECT * FROM `printers`";
        //Запрос на справочник картриджей
        internal static string script_SelectGuideCartrige = $"SELECT * FROM `cartrige`";
        //Запрос на справочник аудиторий
        internal static string script_SelectGuideAuditorium = $"SELECT * FROM `audiences`";
        //Запрос на справочник Установок
        internal static string script_SelectSetup = $"SELECT * FROM `setup`";
        //Запрос на справочник перезаправленных картриджей
        internal static string script_SelectGuideRefill = $"SELECT * FROM `refill`";
        //Запрос на справочник Роли (доступ только у админов)
        internal static string script_SelectGuideRole = $"SELECT * FROM `roles`";
        //Запрос на справочник всех пользователей (доступ только у админов)
        internal static string script_SelectAllUsers = $"SELECT * FROM `asi`.`users`";
        //Запрос на справочник администраторов (доступ только у админов)
        internal static string script_SelectUser_Admin = $"SELECT * FROM `asi`.`users` WHERE `role` = 'ROLE_ADMIN'";
        //Запрос на справочник пользователей(доступ только у админов)
        internal static string script_SelectUser_User = $"SELECT * FROM `asi`.`users` WHERE `role` = 'ROLE_USER'";




    }
}
