using EquipmentRepair.DAL.Queries;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using EquipmentRepair.DAL.Entities;

namespace EquipmentRepair.DAL.Repositories;

public class EquipmentTypeRepository
{
    private readonly string _connectionString;

    public EquipmentTypeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Create (Insert)
    public void AddEquipmentType(string country, int manufactureYear, string brand)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.InsertEquipmentType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@ManufactureYear", manufactureYear);
                command.Parameters.AddWithValue("@Brand", brand);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Read (Select)
    public List<EquipmentType> GetAllEquipmentTypes()
    {
        List<EquipmentType> equipmentTypes = new List<EquipmentType>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.SelectAllEquipmentTypes;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EquipmentType equipmentType = new EquipmentType
                        {
                            EquipmentTypeID = reader.GetInt32(0),
                            Country = reader.GetString(1),
                            ManufactureYear = reader.GetInt32(2),
                            Brand = reader.GetString(3)
                        };
                        equipmentTypes.Add(equipmentType);
                    }
                }
            }
        }

        return equipmentTypes;
    }
    public EquipmentType GetEquipmentTypeByID(int equipmentTypeId)
    {
        EquipmentType equipmentType = null;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.SelectEquipmentTypesId;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EquipmentTypeID", equipmentTypeId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        equipmentType = new EquipmentType
                        {
                            EquipmentTypeID = reader.GetInt32(0),
                            Country = reader.GetString(1),
                            ManufactureYear = reader.GetInt32(2),
                            Brand = reader.GetString(3)
                        };
                    }
                }
            }
        }

        return equipmentType;
    }
    // Update
    public void UpdateEquipmentType(int equipmentTypeId, string country, int manufactureYear, string brand)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.UpdateEquipmentType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EquipmentTypeID", equipmentTypeId);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@ManufactureYear", manufactureYear);
                command.Parameters.AddWithValue("@Brand", brand);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    // Delete
    public void DeleteEquipmentType(int equipmentTypeId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = SqlQueries.DeleteEquipmentType;

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EquipmentTypeID", equipmentTypeId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}