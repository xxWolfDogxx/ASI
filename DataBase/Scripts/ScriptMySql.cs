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
        internal static string script_isRoomExists = $"SELECT * FROM `room` WHERE `name` = @roomExists";
        //Запрос на сверку введенной аудитории с повторами в базе данных
        internal static string script_isModelExists = $"SELECT * FROM `model` WHERE `name` = @nameExists";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isConsumableExists = $"SELECT * FROM `cartrige` WHERE `code` = @numberCartrige";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isPrinterExists = $"SELECT * FROM `printer` WHERE `inventory` = @printerExists";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isStatusWorkExists = $"SELECT * FROM `refill` WHERE `status` = @statusWork";
        //Запрос на сверку введенной номером картриджа с повторами в базе данных
        internal static string script_isTypeExists = $"SELECT * FROM `cartrige_type` WHERE `name` = @typeExists";

        //
        //Скрипты для основной формы
        //
        //Запрос на справочник принтеров
        internal static string script_SelectPrinter = "SELECT printer.id, printer.name, printer.inventory, room.name , printer.note, model.name " +
                "FROM printer " +
                "INNER JOIN room ON printer.id_room = room.Id " +
                "INNER JOIN model ON printer.id_model = model.id";
        //Запрос на справочник картриджей
        internal static string script_SelectCartrige = "SELECT cartrige.id, cartrige.name, cartrige.code, cartrige.buy_date, cartrige.writeoff, cartrige.note, cartrige.ready, cartrige_type.name, room.name, model.name " +
                "FROM cartrige "+
                "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id "+
                "INNER JOIN room ON cartrige.id_room = room.Id "+
                "INNER JOIN model ON cartrige.id_model = model.id";
        //Запрос на справочник аудиторий
        internal static string script_SelectRoom = $"SELECT * FROM `room`";
        //Запрос на справочник Установок
        internal static string script_SelectSetup = $"SELECT * FROM `setup`";
        //Запрос на справочник перезаправленных картриджей
        internal static string script_SelectFill = $"SELECT * FROM `fill`";
        //Запрос на справочник перезаправленных картриджей
        internal static string script_SelectModel = $"SELECT * FROM `model`";
        //Запрос на справочник перезаправленных картриджей
        internal static string script_SelectCartrigeType = $"SELECT * FROM `cartrige_type`";
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
        internal static string script_SelectPrinter_Room = $"SELECT name FROM `room`";
        
        internal static string script_SelectPrinter_Model = $"SELECT name FROM `model`";
        //Отправка на добавление записи
        internal static string script_ADDPrinter_ModPrinter = "INSERT INTO `printer`(`name`, `inventory`, `id_room`, `note`, `id_model`) VALUES(@namePrinter, @inventoryPtinter, @roomPtinter, @notePrinter, @modelPrinter)";

        internal static string script_UpdatePrinter_ModPrinter = "UPDATE `printer` SET `name`=@namePrinter,`inventory`=@inventoryPtinter,`id_room`=@roomPtinter,`note`=@notePrinter,`id_model`=@modelPrinter WHERE `id`=@idPrinter";


        //
        //Скрипты для Картриджев модификация
        //
        //Запрос на вытаскивание данных в combobox Статус работоспособности
        internal static string script_SelectStatusWork = $"SELECT status FROM `statuscartrige`";
        //Запрос на вытаскивание данных в combobox Перезаправлености
        internal static string script_SelectRefill = $"SELECT status FROM `refill`";
        //Запрос на изменение записи картриджа
        internal static string script_UpdateConsumable_ModConsumable= "UPDATE `cartrige` SET `name`=@nameConsumable,`code`=@codeConsumable,`buy_date`=@buy_dateConsumable,`writeoff`=@writeoffConsumable,`note`=@noteConsumable,`ready`=@readyConsumable,`id_cartrige_type`=@typeConsumable,`id_room`=@roomConsumable,`id_model`=@modelConsumable WHERE `id`=@idConsumable";
        //Запрос на вставку записи картриджа
        internal static string script_InsertConsumable_ModConsumable = "INSERT INTO `cartrige`(`name`, `code`, `buy_date`, `writeoff`, `note`, `ready`, `id_cartrige_type`, `id_room`, `id_model`) VALUES (@nameConsumable, @codeConsumable, @buy_dateConsumable, @writeoffConsumable,@noteConsumable,@readyConsumable,@typeConsumable,@roomConsumable,@modelConsumable)";

        //
        //Скрипты для ModRoom
        //
        //Запрос на изменение аудитории
        internal static string script_UpdateRoom_ModRoom = "UPDATE `room` SET `name`=@room WHERE `id`= @idRoom";
        //Запрос на вставку аудитории
        internal static string script_InsertRoom_ModRoom = "INSERT INTO `room`(`name`) VALUES (@room)";

        //
        //Скрипты для ModFill
        //
        //Запрос на изменение записи статус работоспособности
        internal static string script_UpdateFill_ModFill = "UPDATE `fill` SET `id_cartrige`=@cartrigeFill,`date`=@dateFill,`note`=@noteFill WHERE `id`=@idFill";
        //Запрос на вставку записи статус работоспособности
        internal static string script_InsertFill_ModFill = "INSERT INTO `fill`(`id_cartrige`, `date`, `note`) VALUES (@cartrigeFill,@dateFill,@noteFill)";
        
        
        //
        //Скрипты для ModModel
        //
        //Запрос на изменение записи статус работоспособности
        internal static string script_UpdateModel_ModModel = "UPDATE `model` SET `name`=@nameModel WHERE `id`= @idModel";
        //Запрос на вставку записи статус работоспособности
        internal static string script_InsertModel_ModModel = "INSERT INTO `model`(`name`) VALUES (@nameModel)";
        
        
        //
        //Скрипты для ModModel
        //
        //Запрос на изменение записи статус работоспособности
        internal static string script_UpdateType_ModCartrigeType = "UPDATE `cartrige_type` SET `name`=@type,`refill`=@refill WHERE `id`=@idType";
        //Запрос на вставку записи статус работоспособности
        internal static string script_InsertType_ModCartrigeType = "INSERT INTO `cartrige_type`(`name`, `refill`) VALUES (@type,@refill)";


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
