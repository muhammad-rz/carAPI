using System.ComponentModel.DataAnnotations;

namespace carApi.Dtos
{
    public class CarCreateDto
    {

        [Required]
        [MaxLength(250)]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public int Year { get; set; }
    }
}