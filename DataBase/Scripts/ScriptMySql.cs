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
        //Запрос на сверку введенной аудитории с повторами в базе данных
        internal static string script_isAudiencesExists = $"SELECT * FROM `audiences` WHERE `Auditorium` = @auditExists";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isCartrigeExists = $"SELECT * FROM `cartrige` WHERE `Number` = @numberCartrige";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isPrinterExists = $"SELECT * FROM `printers` WHERE `InventoryNumber` = @printerExists";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isStatusWorkExists = $"SELECT * FROM `statuscartrige` WHERE `status` = @statusWork";

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


        //
        //Скрипты для Картриджев модификация
        //
        //Запрос на вытаскивание данных в combobox Статус работоспособности
        internal static string script_SelectStatusWork = $"SELECT status FROM `statuscartrige`";
        //Запрос на вытаскивание данных в combobox Перезаправлености
        internal static string script_SelectRefill = $"SELECT status FROM `refill`";
        //Запрос на изменение записи картриджа
        internal static string script_UpdateCartrige = "UPDATE `cartrige` SET `Number`=@numberCartrige,`Brand`=@brandCartrige,`Model`=@modelCartrige,`Status`=@statusWorkCartrige,`Refill`=@refillCartrige,`Comment`=@comCartrige WHERE `Id`=@idCartrige";
        //Запрос на вставку записи картриджа
        internal static string script_InsertCartrige = "INSERT INTO `cartrige`(`Number`, `Brand`, `Model`, `Status`, `Refill`, `Comment`) VALUES (@numberCartrige,@brandCartrige,@modelCartrige,@statusWorkCartrige,@refillCartrige,@comCartrige)";

        //
        //Скрипты для Аудиторий модификация
        //
        //Запрос на изменение записи картриджа
        internal static string script_UpdateAudit = "UPDATE `audiences` SET `Auditorium`= @audit,`Comments`= @comAudit WHERE `Id` = @idAudit";
        //Запрос на вставку записи картриджа
        internal static string script_InsertAudit = "INSERT INTO `audiences`(`Auditorium`, `Comments`) VALUES (@audit,@comAudit)";

        //
        //Скрипты для статус работоспособности модификация
        //
        //Запрос на изменение записи статус работоспособности
        internal static string script_UpdateStatusWork = "UPDATE `statuscartrige` SET `Status`= @statusWork WHERE `Id` = @idStatusWork";
        //Запрос на вставку записи статус работоспособности
        internal static string script_InsertStatusWork = "INSERT INTO `statuscartrige`(`Status`) VALUES (@statusWork)";


        //
        //Скрипты для Установок модификация
        //
        //Запрос на вытаскивание данных в combobox Инвентарный номер принтера
        internal static string script_SelectInventPrinter = $"SELECT InventoryNumber FROM `printers`";
        //Запрос на вытаскивание данных в combobox Номер картриджа
        internal static string script_SelectNumberCartrige = $"SELECT Number FROM `cartrige`";
        //Запрос на изменение записи установок
        internal static string script_UpdateSetup = "UPDATE `setup` SET `Invent_printer`=@inventPrinterSetup,`Number_cartrige`=@numberCartrigeSetup,`Data_setup`=@dataSetup,`Data_withdrawals`=@dataWithDrawals WHERE `Id` = @idSetup";
        //Запрос на вставку записи установок
        internal static string script_InsertSetup = "INSERT INTO `setup`(`Invent_printer`, `Number_cartrige`, `Data_setup`, `Data_withdrawals`) VALUES (@inventPrinterSetup,@numberCartrigeSetup,@dataSetup,@dataWithDrawals)";
    }
    
}
