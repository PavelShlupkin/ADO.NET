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
    public class UserDAO:IUserDao
    {
        private string _connectionString = @"Data Source=DESKTOP-VAAPLAB;Initial Catalog=task3;Integrated Security=True";
        public void Add(User<int> value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";
                cmd.Parameters.AddWithValue(@"Name", value.Name);
                cmd.Parameters.AddWithValue(@"Date", value.DateOfBrith);
                cmd.Parameters.AddWithValue(@"Age", value.Age);
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

        public IEnumerable<User<string>> GetAll()
        {
            List<User<string>> users = new List<User<string>>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllUser";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User<string>
                    {
                        ID = (int)reader["ID"],
                        Name = (string)reader["Name"],
                        DateOfBrith = (DateTime)reader["DateOfBrith"],
                        Age = (int)reader["Age"]
                    });
                }
            }
            return users;
        }
        public User<int> GetByID(int ID)
        {
            User<int> user = new User<int>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUserByID";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.ID = (int)reader["ID"];
                    user.Name = (string)reader["Name"];
                    user.DateOfBrith = (DateTime)reader["DateOfBrith"];
                    user.Age = (int)reader["Age"];
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
                cmd.CommandText = "RemoveUser";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
