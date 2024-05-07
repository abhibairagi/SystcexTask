using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TestApi.Models;

public class SupplierRepository
{
    private readonly string _connectionString;

    public SupplierRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int GetSupllierCount()
    {
        int supplierCount = 0;

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Suppliers";
            using (var command = new MySqlCommand(query, connection))
            {
                supplierCount = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        return supplierCount;
    }

    public List<Supplier> GetSuppliers()
    {
        List<Supplier> suppliers = new List<Supplier>();

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Suppliers";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new Supplier
                        {
                            // Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Phone = Convert.ToInt32(reader["Phone"]),
                            Email = reader["Email"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                        });
                    }
                }
            }
        }

        return suppliers;
    }
}