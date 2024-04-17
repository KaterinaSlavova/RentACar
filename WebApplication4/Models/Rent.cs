using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Rent
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string CarId { get; set; }
       // public virtual Car Car { get; set; }
        public DateTime StartDay {get;set;}
        public DateTime EndDay { get;set;}

    }
}
