using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryProject.Models;
using Npgsql;
using Dapper;

namespace FoodDeliveryProject.Repository
{
    public class UserRepository : IUserRepository
    {
        private string connectionString = "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=foodDelivery";
        public async Task Add(User user, string password_hash)
        {
            await using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                connection.Execute("insert into user (username, phone_number, password_hash) values (@Username, @PhoneNumber, @PasswordHash)",
                                    new { @Username = user.Username, @PhoneNumber = user.PhoneNumber, @PasswordHash = user.PasswordHash });
            }
        }
        public async Task<User> GetUser(string phone_number, string password)
        {
            await using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var user = connection.QueryFirstOrDefault<User>(
                    "select id, username, phone_number, password_hash, sess_key as Key from users where phone_number = @PhoneNumber and password_hash = @PasswordHash",
                    new { PhoneNumber = phone_number, Password = password }) ?? new User();
                return user;
            }
        }
    }
}
