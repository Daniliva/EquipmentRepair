namespace EquipmentRepair.DAL.Entities;

public class RepairRecord
{
    public int RegistrationNumber { get; set; }
    public int EquipmentTypeID { get; set; }
    public int RepairTypeID { get; set; }
    public DateTime StartDate { get; set; }
    public string RepairQuality { get; set; }
}