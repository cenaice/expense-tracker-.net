using Microsoft.Data.Sqlite;
using System;

namespace habit_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and connect to database
            string connectionString = @"Data Source=habit-Tracker.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS drinking_water (Id INTEGER PRIMARY KEY AUTOINCREMENT, Date TEXT, Quantity INTEGER)";

                tableCmd.ExecuteNonQuery();

                connection.Close();
            }



            Console.WriteLine("Welcome to the Habit Logger\n");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Input your command\n");
            Console.WriteLine("0 to exit");
            Console.WriteLine("1 to View All Records");
            Console.WriteLine("2 to Insert Record");
            Console.WriteLine("3 to Delete Record");
            Console.WriteLine("4 to Update Record");
            Console.WriteLine("------------------------------------------------");

            var input = Console.ReadLine();
            while (input == "")
            {
                Console.WriteLine("Invalid input");
                input = Console.ReadLine();
            }


        }
    }
}


