namespace EquipmentRepair.DAL.Queries;

internal static class SqlQueries
{
    // RepairTypes queries
    public const string InsertRepairType = @"
        INSERT INTO RepairTypes (Name, Duration, Cost, Notes)
        VALUES (@Name, @Duration, @Cost, @Notes);";

    public const string SelectAllRepairTypes = @"
        SELECT RepairTypeID, Name, Duration, Cost, Notes
        FROM RepairTypes;";

    public const string UpdateRepairType = @"
        UPDATE RepairTypes
        SET Name = @Name, Duration = @Duration, Cost = @Cost, Notes = @Notes
        WHERE RepairTypeID = @RepairTypeID;";

    public const string DeleteRepairType = @"
        DELETE FROM RepairTypes
        WHERE RepairTypeID = @RepairTypeID;";

    // EquipmentTypes queries
    public const string InsertEquipmentType = @"
        INSERT INTO EquipmentTypes (Country, ManufactureYear, Brand)
        VALUES (@Country, @ManufactureYear, @Brand);";

    public const string SelectAllEquipmentTypes = @"
        SELECT EquipmentTypeID, Country, ManufactureYear, Brand
        FROM EquipmentTypes;";

    public const string UpdateEquipmentType = @"
        UPDATE EquipmentTypes
        SET Country = @Country, ManufactureYear = @ManufactureYear, Brand = @Brand
        WHERE EquipmentTypeID = @EquipmentTypeID;";

    public const string DeleteEquipmentType = @"
        DELETE FROM EquipmentTypes
        WHERE EquipmentTypeID = @EquipmentTypeID;";

    // RepairRecords queries
    public const string InsertRepairRecord = @"
        INSERT INTO RepairRecords (EquipmentTypeID, RepairTypeID, StartDate, RepairQuality)
        VALUES (@EquipmentTypeID, @RepairTypeID, @StartDate, @RepairQuality);";

    public const string SelectAllRepairRecords = @"
        SELECT RegistrationNumber, EquipmentTypeID, RepairTypeID, StartDate, RepairQuality
        FROM RepairRecords;";

    public const string UpdateRepairRecord = @"
        UPDATE RepairRecords
        SET EquipmentTypeID = @EquipmentTypeID, RepairTypeID = @RepairTypeID, StartDate = @StartDate, RepairQuality = @RepairQuality
        WHERE RegistrationNumber = @RegistrationNumber;";

    public const string DeleteRepairRecord = @"
        DELETE FROM RepairRecords
        WHERE RegistrationNumber = @RegistrationNumber;";
}