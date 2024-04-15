using System.ComponentModel.DataAnnotations;

namespace Rent_a_Car.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
