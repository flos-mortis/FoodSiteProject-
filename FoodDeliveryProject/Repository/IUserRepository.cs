using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryProject.Models;

namespace FoodDeliveryProject.Repository
{
    interface IUserRepository
    {
        Task Add(User user, string password_hash);
        Task<User> GetUser(string phone_number, string password);
    }
}
