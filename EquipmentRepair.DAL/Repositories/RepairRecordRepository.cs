using System.Data.SqlClient;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class RepairRecordRepository
{
    private readonly string _connectionString;

    public RepairRecordRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Create (Insert)
    public void AddRepairRecord(int equipmentTypeId, int repairTypeId, DateTime startDate, string repairQuality)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.InsertRepairRecord;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EquipmentTypeID", equipmentTypeId);
                command.Parameters.AddWithValue("@RepairTypeID", repairTypeId);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@RepairQuality", repairQuality ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Read (Select)
    public List<RepairRecord> GetAllRepairRecords()
    {
        List<RepairRecord> repairRecords = new List<RepairRecord>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.SelectAllRepairRecords;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RepairRecord repairRecord = new RepairRecord
                        {
                            RegistrationNumber = reader.GetInt32(0),
                            EquipmentTypeID = reader.GetInt32(1),
                            RepairTypeID = reader.GetInt32(2),
                            StartDate = reader.GetDateTime(3),
                            RepairQuality = reader.IsDBNull(4) ? null : reader.GetString(4)
                        };
                        repairRecords.Add(repairRecord);
                    }
                }
            }
        }

        return repairRecords;
    }

    // Update
    public void UpdateRepairRecord(int registrationNumber, int equipmentTypeId, int repairTypeId, DateTime startDate, string repairQuality)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.UpdateRepairRecord;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                command.Parameters.AddWithValue("@EquipmentTypeID", equipmentTypeId);
                command.Parameters.AddWithValue("@RepairTypeID", repairTypeId);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@RepairQuality", repairQuality ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Delete
    public void DeleteRepairRecord(int registrationNumber)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.DeleteRepairRecord;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}