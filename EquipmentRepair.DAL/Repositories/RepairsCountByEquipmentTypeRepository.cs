using System.Data.SqlClient;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class RepairsCountByEquipmentTypeRepository
{
    private readonly string _connectionString;

    public RepairsCountByEquipmentTypeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<RepairCountByEquipment> GetRepairCountsByEquipmentType()
    {
        List<RepairCountByEquipment> counts = new List<RepairCountByEquipment>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlJoinQueries.CountRepairsByEquipmentType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RepairCountByEquipment count = new RepairCountByEquipment
                        {
                            Brand = reader.GetString(0),
                            RepairCount = reader.GetInt32(1)
                        };
                        counts.Add(count);
                    }
                }
            }
        }

        return counts;
    }
}