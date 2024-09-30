namespace EquipmentRepair.DAL;

public class RepairRecordWithDetails
{
    public int RegistrationNumber { get; set; }
    public string Country { get; set; }
    public int ManufactureYear { get; set; }
    public string Brand { get; set; }
    public string RepairTypeName { get; set; }
    public DateTime StartDate { get; set; }
    public string RepairQuality { get; set; }
}