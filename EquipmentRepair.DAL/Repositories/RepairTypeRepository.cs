using System.Data.SqlClient;
using EquipmentRepair.DAL.Queries;

namespace EquipmentRepair.DAL.Repositories;

public class RepairTypeRepository
{
    private readonly string _connectionString;

    public RepairTypeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Create (Insert)
    public void AddRepairType(string name, int duration, decimal cost, string notes)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.InsertRepairType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Read (Select)
    public List<RepairType> GetAllRepairTypes()
    {
        List<RepairType> repairTypes = new List<RepairType>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.SelectAllRepairTypes;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RepairType repairType = new RepairType
                        {
                            RepairTypeID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Duration = reader.GetInt32(2),
                            Cost = reader.GetDecimal(3),
                            Notes = reader.IsDBNull(4) ? null : reader.GetString(4)
                        };
                        repairTypes.Add(repairType);
                    }
                }
            }
        }

        return repairTypes;
    }

    // Update
    public void UpdateRepairType(int repairTypeId, string name, int duration, decimal cost, string notes)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.UpdateRepairType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RepairTypeID", repairTypeId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Delete
    public void DeleteRepairType(int repairTypeId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.DeleteRepairType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RepairTypeID", repairTypeId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    // Get a single RepairType by ID
    public RepairType GetRepairTypeByID(int repairTypeId)
    {
        RepairType repairType = null;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.SelectRepairTypeByID; // Обязательно добавьте этот запрос в ваш SqlQueries класс

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RepairTypeID", repairTypeId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        repairType = new RepairType
                        {
                            RepairTypeID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Duration = reader.GetInt32(2),
                            Cost = reader.GetDecimal(3),
                            Notes = reader.IsDBNull(4) ? null : reader.GetString(4)
                        };
                    }
                }
            }
        }

        return repairType;
    }

}