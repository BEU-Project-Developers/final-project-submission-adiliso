using System.ComponentModel.DataAnnotations;

namespace Airline.domain.entity
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } // Unique

        public string Name { get; set; }

        [Required]
        public string Password { get; set; } // Hashed
    }

}
