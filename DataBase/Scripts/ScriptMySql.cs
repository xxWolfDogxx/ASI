
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
        internal static string script_SelectUserRole = $"SELECT roles.role  FROM `users` INNER JOIN roles ON users.role = roles.id WHERE `Email` = @uL;";
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
        //Запрос на сверку введенной  модели с повторами в базе данных
        internal static string script_isModelExists = $"SELECT * FROM `model` WHERE `name` = @nameExists";
        //Запрос на сверку введенной номером расходника с повторами в базе данных
        internal static string script_isConsumableExists = $"SELECT * FROM `cartrige` WHERE `code` = @numberCartrige";
        //Запрос на сверку введенной номером принтера с повторами в базе данных
        internal static string script_isPrinterExists = $"SELECT * FROM `printer` WHERE `inventory` = @printerExists";
        //Запрос на сверку введенной типом расходника с повторами в базе данных
        internal static string script_isTypeExists = $"SELECT * FROM `cartrige_type` WHERE `name` = @typeExists";


        //
        //Скрипты для основной формы ASI
        //
        //Запрос на вывод в таблицу принтеров
        internal static string script_SelectPrinter_ASI = "SELECT printer.id AS ID, printer.name AS Имя, printer.inventory AS 'Инв. №', printer.id_room, room.name AS Аудитория , printer.note AS Примечание, printer.id_model, model.name AS Модель " +
                "FROM printer " +
                "INNER JOIN room ON printer.id_room = room.id " +
                "INNER JOIN model ON printer.id_model = model.id";
        //Запрос на вывод в таблицу расходников
        internal static string script_SelectCartrige_ASI = "SELECT cartrige.id AS ID, cartrige.name AS Имя, cartrige.code AS 'Код', cartrige.buy_date AS 'Дата', cartrige.writeoff AS Списан, cartrige.note AS Примечание, cartrige.ready AS Готов, cartrige.setup AS 'Установ.', cartrige.id_cartrige_type AS 'id_type',cartrige_type.name AS 'Тип', cartrige.id_room, room.name AS Место, cartrige.id_model, model.name AS 'Совместим'" +
                "FROM cartrige " +
                "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id " +
                "INNER JOIN room ON cartrige.id_room = room.Id " +
                "INNER JOIN model ON cartrige.id_model = model.id";
        //Запрос на вывод в таблицу установок
        internal static string script_SelectSetup_ASI = "SELECT setup.id AS 'ID', printer.id AS id_printer, printer.name AS 'Принтер', cartrige.id AS id_cartrige, cartrige.code AS 'Ррасходник', setup.start AS 'Дата установки', setup.end AS 'Дата снятия', setup.note AS 'Заметки' " +
                "FROM setup " +
                "INNER JOIN printer ON setup.id_printer = printer.id " +
                "INNER JOIN cartrige ON setup.id_cartrige = cartrige.id";
        //Запрос на вывод в таблицу перезаправок
        internal static string script_SelectFill_ASI = "SELECT fill.id AS 'ID', cartrige.id AS 'id_cartrige', cartrige.code AS 'Код расходника', fill.date AS 'Дата заправки', fill.note AS 'Примечание' " +
                "FROM fill " +
                "INNER JOIN cartrige ON fill.id_cartrige = cartrige.id";
        //Запрос вывод в таблицу аудиторий
        internal static string script_SelectRoom_ASI = "SELECT room.id AS 'ID', room.name AS 'Имя' FROM `room`";
        //Запрос на вывод в таблицу моделей принтеров
        internal static string script_SelectModel_ASI = $"SELECT model.id AS 'ID', model.name AS 'Имя' FROM `model`";
        //Запрос на вывод в таблицу тип расходника
        internal static string script_SelectCartrigeType_ASI = $"SELECT cartrige_type.id AS 'ID', cartrige_type.name AS 'Имя', cartrige_type.refill AS 'Перезаправка' FROM `cartrige_type`";

        //Запрос на справочник Роли (доступ только у рута)
        internal static string script_SelectRole_ASI = $"SELECT * FROM `roles`";
        //Запрос на справочник всех пользователей (доступ только у рута)
        internal static string script_SelectAllUsers_ASI = $"SELECT users.Id,users.FullName AS 'ФИО',users.DateOfBirth AS 'Дата рождения',users.Phone AS 'Номер телефона',users.Email AS 'Эл. почта',roles.role AS 'Роль' FROM users INNER JOIN roles ON users.role = roles.id  ";
        //Запрос на справочник администраторов (доступ только у рута)
        internal static string script_SelectUser_Admin_ASI = $"SELECT users.Id,users.FullName AS 'ФИО',users.DateOfBirth AS 'Дата рождения',users.Phone AS 'Номер телефона',users.Email AS 'Эл. почта',roles.role AS 'Роль' FROM users INNER JOIN roles ON users.role = roles.id WHERE roles.role = 'ROLE_AMDMIN'";
        //Запрос на справочник пользователей(доступ только у рута)
        internal static string script_SelectUser_User_ASI = $"SELECT users.Id,users.FullName AS 'ФИО',users.DateOfBirth AS 'Дата рождения',users.Phone AS 'Номер телефона',users.Email AS 'Эл. почта',roles.role AS 'Роль' FROM users INNER JOIN roles ON users.role = roles.id WHERE roles.role = 'ROLE_USER'";


        //
        //Скрипты для ModPrinter
        //
        //Запрос на вытаскивание данных в combobox Room
        internal static string script_SelectRoom_ModPrinter = $"SELECT id AS id_room, name AS name_room FROM `room`";
        //Запрос на вытаскивание данных в combobox Model
        internal static string script_SelectModel_ModPrinter = $"SELECT model.id AS id_model, model.name AS name_model FROM `model`";
        //Отправка на добавление записи принтер
        internal static string script_ADDPrinter_ModPrinter = "INSERT INTO `printer`(`name`, `inventory`, `id_room`, `note`, `id_model`) VALUES (@namePrinter, @inventoryPtinter, @roomPtinter, @notePrinter, @modelPrinter)";
        //Отправка на изменение записи принтер
        internal static string script_UpdatePrinter_ModPrinter = "UPDATE `printer` SET `name` = @namePrinter,`inventory` = @inventoryPtinter,`id_room` = @roomPtinter,`note` = @notePrinter,`id_model` = @modelPrinter WHERE `id` = @idPrinter";
        //Запрос на вытаскивание инвентарного номера принтера для проверки на повторы
        internal static string script_SelectPrinterInventDB_ModPrinter = "SELECT Inventory FROM printer WHERE id = @idPrinter";
        //Запрос на вытаскивание название принтера для проверки на повторы
        internal static string script_SelectPrinterNameDB_ModPrinter = "SELECT Name FROM printer WHERE id = @idPrinter";


        //
        //Скрипты для ModConsumable
        //
        //Запрос на вытаскивание данных в combobox Room
        internal static string script_SelectRoom_ModConsumable = $"SELECT id AS id_room, name AS name_room FROM `room`";
        //Запрос на вытаскивание данных в combobox Model
        internal static string script_SelectModel_ModConsumable = $"SELECT model.id AS id_model, model.name AS name_model FROM `model`";
        //Запрос на вытаскивание данных в combobox Cartrige_Type
        internal static string script_SelectCartrigeType_ModConsumable = $"SELECT cartrige_type.id AS 'id_type', cartrige_type.name AS 'name_type' FROM `cartrige_type`";
        //Запрос на вытаскивание уникального кода расходника для проверки на повторы
        internal static string script_SelectConsumableDB_ModConsumable = $"SELECT code FROM cartrige WHERE id = @idConsumable";
        //Отправка запроса на изменение записи картриджа
        internal static string script_UpdateConsumable_ModConsumable = "UPDATE `cartrige` SET `name`= @nameConsumable,`code`= @codeConsumable,`buy_date`= @buy_dateConsumable,`writeoff`= @writeoffConsumable,`note`= @noteConsumable,`ready`= @readyConsumable,`id_cartrige_type`= @typeConsumable,`id_room`= @roomConsumable,`id_model`= @modelConsumable WHERE `id`= @idConsumable";
        //Отправка запроса на вставку записи картриджа
        internal static string script_InsertConsumable_ModConsumable = "INSERT INTO `cartrige`(`name`, `code`, `buy_date`, `writeoff`, `note`, `ready`, `setup`, `id_cartrige_type`, `id_room`, `id_model`) VALUES (@nameConsumable, @codeConsumable, @buy_dateConsumable, @writeoffConsumable,@noteConsumable,@readyConsumable,@setupConsumable, @typeConsumable,@roomConsumable,@modelConsumable)";


        //
        //Скрипты для ModRoom
        //
        //Отправка запроса на изменение аудитории
        internal static string script_UpdateRoom_ModRoom = "UPDATE `room` SET `name`= @room WHERE `id`= @idRoom";
        //Отправка запроса на вставку аудитории
        internal static string script_InsertRoom_ModRoom = "INSERT INTO `room`(`name`) VALUES (@room)";
        //Запрос на вытягивание названия аудитории для проверки повторов
        internal static string script_SelectRoomDB_ModRoom = $"Select name  From room Where id = @idRoom";


        //
        //Скрипты для ModFill
        //
        //Отправка запроса на изменение записи заправок
        internal static string script_UpdateFill_ModFill = "UPDATE `fill` SET `id_cartrige` = @cartrigeFill,`date` = @dateFill,`note` = @noteFill WHERE `id` = @idFill";
        //Отправка запроса на вставку записи заправок
        internal static string script_InsertFill_ModFill = "INSERT INTO `fill`(`id_cartrige`, `date`, `note`) VALUES (@cartrigeFill, @dateFill, @noteFill)";
        //Отправка запроса на изменение записи картриджа (Готовность, установка, заметки)
        internal static string script_InsertFillCartrigeReady_ModFill = "Update `cartrige` SET `ready` = @readyCartrige, `setup` = @setupCartrige WHERE `id` = @idCartrige";
        //Запрос на вытягивание записей в ComBox расходников (перезаправляемых) при изменении
        internal static string script_SelectComBox_ModFill = "SELECT cartrige.id, cartrige.code, cartrige.ready, cartrige_type.refill " +
                "FROM cartrige " +
                "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id WHERE cartrige_type.refill = true && cartrige.ready = 0";
        //Запрос на вытягивание записей в ComBox расходников (перезаправляемых) при добавлении
        internal static string script_SelectComBox1_ModFill = "SELECT cartrige.id, cartrige.code, cartrige.ready, cartrige_type.refill " +
                "FROM cartrige " +
                "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id WHERE cartrige_type.refill = true";


        //
        //Скрипты для ModModel
        //
        //Отправка запроса на изменение записи модель
        internal static string script_UpdateModel_ModModel = "UPDATE `model` SET `name`=@nameModel WHERE `id`= @idModel";
        //Отправка запроса на вставку записи модель
        internal static string script_InsertModel_ModModel = "INSERT INTO `model`(`name`) VALUES (@nameModel)";
        //Запрос на вытягивание название моделей принтера для проверки от повторов
        internal static string script_SelectConsumableDB_ModModel = $"SELECT name FROM model WHERE id = @idModel";


        //
        //Скрипты для ModCartrigeType
        //
        //Запрос на изменение записи тип расходника
        internal static string script_UpdateType_ModCartrigeType = "UPDATE `cartrige_type` SET `name`=@type,`refill`=@refill WHERE `id`=@idType";
        //Запрос на вставку записи тип расходника
        internal static string script_InsertType_ModCartrigeType = "INSERT INTO `cartrige_type`(`name`, `refill`) VALUES (@type,@refill)";
        //Запрос на вытягивание название название расходников в типах для проверки от повторов
        internal static string script_SelectConsumableDB_ModCartrigeType = $"SELECT name FROM cartrige_type WHERE id = @idType";


        //
        //Скрипты для Установок модификация
        //
        //Отправка запроса на изменение записи установок
        internal static string script_UpdateSetup = "UPDATE `setup` SET `id_printer` = @printerSetup,`id_cartrige`=@cartrigeSetup,`start`=@dataStartSetup,`end`=@dataEndSetup,`note`=@noteSetup WHERE `id`= @idSetup";
        //Отправка запроса на вставку записи установок
        internal static string script_InsertSetup = "INSERT INTO `setup`(`id_printer`, `id_cartrige`, `start`, `end`, `note`) VALUES (@printerSetup,@cartrigeSetup,@dataStartSetup,@dataEndSetup,@noteSetup)";
        //Отправка запроса на изменение записи картриджа (готовность)
        internal static string script_UpdateSetupCheck_Cartrige = "UPDATE `cartrige` SET `setup`= @setupCheck WHERE `id`=@idCartrige";
        //Отправка запроса на изменение записи картриджа (готовность, установка, заметки)
        internal static string script_UpdateReadyCheck_Cartrige = "UPDATE cartrige " +
                    "INNER JOIN cartrige_type ON cartrige.id_cartrige_type = cartrige_type.id " +
                    "SET `cartrige`.`ready`= @readyCheck,`cartrige`.`setup`= @setupCheck  WHERE `cartrige`.`id` = @idCartrige";
        //Запрос на вытаскивание данных в combobox название принтера
        internal static string script_SelectPrinter_ModSetup = "SELECT * FROM `printer` WHERE id_model =@idModelPrinter";
        //Запрос на вытаскивание данных в combobox код картриджа
        internal static string script_SelectCartrige_ModSetup = "SELECT * FROM `cartrige`";
    }

}
