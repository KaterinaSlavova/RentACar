using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Rent_a_Car.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
