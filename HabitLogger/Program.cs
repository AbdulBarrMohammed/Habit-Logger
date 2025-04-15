using System;
using Microsoft.Data.Sqlite;


class Program
{
    static void Main(string[] args)
    {
        // connection string to backend database
        string connectionString = @"Data Source=habit-Tracker.db";

        //connecting to database
        using (var connection = new SqliteConnection(connectionString)) {
            connection.Open();
            var tableCmd = connection.CreateCommand();

            tableCmd.CommandText =
            @"CREATE TABLE IF NOT EXISTS drinking_water (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT,
                Quantity INTEGER
            )";
            tableCmd.ExecuteNonQuery(); // means we dont want the database to return any values

            connection.Close();
        }
    }
}
