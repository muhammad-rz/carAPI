using System.ComponentModel.DataAnnotations;

namespace carApi.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public int Year { get; set; }
    }
}