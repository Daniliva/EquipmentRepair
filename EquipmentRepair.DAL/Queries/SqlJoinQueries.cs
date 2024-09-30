namespace EquipmentRepair.DAL.Queries;

internal static class SqlJoinQueries
{
    // Запрос 1: Получение списка ремонтных записей с типом оборудования и ремонта
    public const string GetRepairRecordsWithEquipmentAndRepairTypes = @"
        SELECT rr.RegistrationNumber, et.Country, et.ManufactureYear, et.Brand, rt.Name, rr.StartDate, rr.RepairQuality
        FROM RepairRecords rr
        JOIN EquipmentTypes et ON rr.EquipmentTypeID = et.EquipmentTypeID
        JOIN RepairTypes rt ON rr.RepairTypeID = rt.RepairTypeID;";

    // Запрос 2: Фильтрация по дате начала ремонта
    public const string GetRepairRecordsByDate = @"
        SELECT rr.RegistrationNumber, et.Country, et.ManufactureYear, et.Brand, rt.Name, rr.StartDate, rr.RepairQuality
        FROM RepairRecords rr
        JOIN EquipmentTypes et ON rr.EquipmentTypeID = et.EquipmentTypeID
        JOIN RepairTypes rt ON rr.RepairTypeID = rt.RepairTypeID
        WHERE rr.StartDate BETWEEN @StartDate AND @EndDate;";

    // Запрос 3: Подсчет количества ремонтов по каждому типу оборудования
    public const string CountRepairsByEquipmentType = @"
        SELECT et.Brand, COUNT(*) AS RepairCount
        FROM RepairRecords rr
        JOIN EquipmentTypes et ON rr.EquipmentTypeID = et.EquipmentTypeID
        GROUP BY et.Brand;";

    // Запрос 4: Подсчет средней стоимости ремонта по каждому типу ремонта
    public const string AverageRepairCostByType = @"
        SELECT rt.Name, AVG(rt.Cost) AS AverageCost
        FROM RepairRecords rr
        JOIN RepairTypes rt ON rr.RepairTypeID = rt.RepairTypeID
        GROUP BY rt.Name;";
}