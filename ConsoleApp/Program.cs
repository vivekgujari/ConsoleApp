using ConsoleApp.Services;
using Microsoft.Data.SqlClient;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SqlConnection conn = new SqlConnection();
            string input = Console.ReadLine();
            string[] data = DecodeCommand.decode(input);
            CRUD.create(data[1], data[3]);
        }

        private static void OpenDb(SqlConnection conn)
        {
            conn.ConnectionString = "Server=(LocalDb)\\MSSQLLocalDB;Database=ConsoleApp;Trusted_Connection=true";
            conn.Open();
        }

        private static void CloseDb(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
