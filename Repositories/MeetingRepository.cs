using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TestApi.Models;

public class MeetingRepository
{
    private readonly string _connectionString;

    public MeetingRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int GetMeetingCount()
    {
        int meetingCount = 0;

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Meetings";
            using (var command = new MySqlCommand(query, connection))
            {
                meetingCount = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        return meetingCount;
    }

    public List<Meeting> GetMeetings()
    {
        List<Meeting> meetings = new List<Meeting>();

        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Meetings";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        meetings.Add(new Meeting
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            MeetingName = reader["MeetingName"].ToString(),
                            Location = reader["Location"].ToString(),
                            Date = reader["Date"].ToString(),
                            // Time = reader.GetDateTime(reader.GetOrdinal("Time")).Date;
                        });
                    }
                }
            }
        }

        return meetings;
    }
}