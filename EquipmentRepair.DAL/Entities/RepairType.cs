namespace EquipmentRepair.DAL.Entities
{
    public class RepairType
    {
        public int RepairTypeID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }
    }
}
