
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TestApi.Models;

public class TradeTransactionRepository
{
    private readonly string _connectionString;

    public TradeTransactionRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public TradeTransaction GetTradeTransactionById(int Id)
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM TradeTransactions WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", Id);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new TradeTransaction
                    {
                        Id = reader.GetInt32("Id"),
                        TradeId = reader.GetInt32("TradeId"),
                        ContractDetails = reader.GetString("ContractDetails"),
                        Product = reader.GetString("Product"),
                        ShippingDetails = reader.GetString("ShippingDetails"),
                        Location = reader.GetString("Location"),
                        Status = reader.GetString("Status"),
                    };
                }
            }
        }
        return null;
    }
}
