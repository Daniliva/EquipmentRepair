using System.Data.SqlClient;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class RepairRecordsWithDetailsRepository
{
    private readonly string _connectionString;

    public RepairRecordsWithDetailsRepository(string connectionString)
    {
        _connectionString = connectionString;
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
}