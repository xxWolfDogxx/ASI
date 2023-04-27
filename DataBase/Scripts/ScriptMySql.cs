﻿using System;
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

        //
        //Скрипты для Принтеров модификация
        //
        //Запрос на вытаскивание данных в combobox 
        internal static string script_SelectPtinter_Audit = $"SELECT Auditorium FROM `audiences`";
        //Отправка на добавление записи
        internal static string script_ADDPrinter = "INSERT INTO `printers`(`Brand`, `Model`, `InventoryNumber`, `Auditorium`, `DoubleЫSided_Printing`, `DrumUnit`, `Color`) VALUES (@brandPrinter,@modelPrinter,@inventNumPtinter, @auditPtinter, @doubleSidedPrinter, @drumUnitPrinter, @colorPrinter)";

        internal static string script_UpdatePrinter = "UPDATE `printers` SET `Brand`=@brandPrinter,`Model`=@modelPrinter,`InventoryNumber`=@inventNum,`Auditorium`=@audit,`DoubleЫSided_Printing`=@doublPrinter,`DrumUnit`=@drumPrinter,`Color`=@colorPrinter WHERE `Id`=@idPrinter";
        //internal static string script_SelectPtinter_DuplexPrinting = $"SELECT DoubleЫSided_Printing FROM `printers`";
        //internal static string script_SelectPtinter_DrumUnit = $"SELECT DrumUnit FROM `printers`";
        //internal static string script_SelectPtinter_Color = $"SELECT Color FROM `printers`";



    }
}
