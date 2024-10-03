using System.Data.SqlClient;
using EquipmentRepair.DAL.Entities;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class SpecialRepository
{
    private readonly string _connectionString;

    public SpecialRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<RepairRecordWithDetails> GetRepairRecordsByDate(DateTime startDate, DateTime endDate)
    {
        List<RepairRecordWithDetails> records = new List<RepairRecordWithDetails>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlJoinQueries.GetRepairRecordsByDate;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RepairRecordWithDetails record = new RepairRecordWithDetails
                        {
                            RegistrationNumber = reader.GetInt32(0),
                            Country = reader.GetString(1),
                            ManufactureYear = reader.GetInt32(2),
                            Brand = reader.GetString(3),
                            RepairTypeName = reader.GetString(4),
                            StartDate = reader.GetDateTime(5),
                            RepairQuality = reader.IsDBNull(6) ? null : reader.GetString(6)
                        };
                        records.Add(record);
                    }
                }
            }
        }

        return records;
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
    public List<RepairRecordWithDetails> GetRepairRecordsWithDetails()
    {
        List<RepairRecordWithDetails> records = new List<RepairRecordWithDetails>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlJoinQueries.GetRepairRecordsWithEquipmentAndRepairTypes;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RepairRecordWithDetails record = new RepairRecordWithDetails
                        {
                            RegistrationNumber = reader.GetInt32(0),
                            Country = reader.GetString(1),
                            ManufactureYear = reader.GetInt32(2),
                            Brand = reader.GetString(3),
                            RepairTypeName = reader.GetString(4),
                            StartDate = reader.GetDateTime(5),
                            RepairQuality = reader.IsDBNull(6) ? null : reader.GetString(6)
                        };
                        records.Add(record);
                    }
                }
            }
        }

        return records;
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