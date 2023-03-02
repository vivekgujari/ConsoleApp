using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Db;
using ConsoleApp.Models;

namespace ConsoleApp.Services
{
    public static class CRUD
    {
        public static void create(string key, string value)
        {
            using (var context = new ApplicationDbContext())
            {
                var name = context.Data.Where(d => d.Name == key).FirstOrDefault();
                if (name != null)
                {
                    return;
                }

                var data = new Data()
                {
                    Name = key,
                    Type = value
                };
                context.Data.Add(data);
                context.SaveChanges();
            }
        }

        public static void create_2(string key, string value, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = $"INSERT INTO dbo.Data (Name, Type) VALUES (@Name, @Type)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@Name", key);
            command.Parameters.AddWithValue("@Type", value);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteReader();
            adapter.Dispose();
        }

        public static void update(string key, string value, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = $"INSERT INTO dbo.Data (Name, Type) VALUES (@Name, @Type)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@Name", key);
            command.Parameters.AddWithValue("@Type", value);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteReader();
            adapter.Dispose();
        }
    }
}
