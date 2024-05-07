using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TestApi.Models;

public class CustomerRepository
{
    private readonly string _connectionString;

    public CustomerRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int GetCustomerCount()
    {
        int customerCount = 0;

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Customers";
            using (var command = new MySqlCommand(query, connection))
            {
                customerCount = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        return customerCount;
    }

    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Customers";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Phone = Convert.ToInt32(reader["Phone"]),
                            Email = reader["Email"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                        });
                    }
                }
            }
        }

        return customers;
    }
}