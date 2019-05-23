using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Entities;

namespace DAL
{
    public class AnswardDAO:IAnswardDAO
    {
        private string _connectionString = @"Data Source=DESKTOP-VAAPLAB;Initial Catalog=task3;Integrated Security=True";
        public void Add(Answard value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddAnsward";
                cmd.Parameters.AddWithValue(@"Title", value.Title);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Present(PresentAnsward value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddPresentAnsward";
                cmd.Parameters.AddWithValue(@"ID_User", value.ID_User);
                cmd.Parameters.AddWithValue(@"ID_Answard", value.ID_Answard);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Answard> GetAll()
        {
            List<Answard> answards = new List<Answard>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllAnswards";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    answards.Add(new Answard
                    {
                        ID = (int)reader["ID"],
                        Title = (string)reader["Title"]
                    });
                }
            }
            return answards;
        }
        public IEnumerable<Answard> GetPresentAnsward()
        {
            List<Answard> answards = new List<Answard>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM UserAnswardView";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {(int)reader["ID"]} Имя: {(string)reader["Name"]} Дата рождения: {(DateTime)reader["DateOfBrith"]} Возраст: {(int)reader["Age"]} Награды: {(string)reader["Title"]}");
                }
            }
            return answards;
        }
        public Answard GetByID(int ID)
        {
            Answard user = new Answard();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAnswardByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.ID = (int)reader["ID"];
                }
            }
            return user;
        }
        public void RemoveByID(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveAnsward";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
