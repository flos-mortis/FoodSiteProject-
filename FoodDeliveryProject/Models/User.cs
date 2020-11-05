using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FoodDeliveryProject.Enums;

namespace FoodDeliveryProject.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^((8 |\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$)", ErrorMessage = "Неверный формат номера телефона")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public string Key { get; set; }
        public Role Role { get; set; }
    }
}
