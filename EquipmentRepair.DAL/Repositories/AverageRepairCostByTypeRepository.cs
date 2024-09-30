using System.Data.SqlClient;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class AverageRepairCostByTypeRepository
{
    private readonly string _connectionString;

    public AverageRepairCostByTypeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<AverageRepairCostByType> GetAverageRepairCostsByType()
    {
        List<AverageRepairCostByType> costs = new List<AverageRepairCostByType>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlJoinQueries.AverageRepairCostByType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AverageRepairCostByType cost = new AverageRepairCostByType
                        {
                            RepairTypeName = reader.GetString(0),
                            AverageCost = reader.GetDecimal(1)
                        };
                        costs.Add(cost);
                    }
                }
            }
        }

        return costs;
    }
}