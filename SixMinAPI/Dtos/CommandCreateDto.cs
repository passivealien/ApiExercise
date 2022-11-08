using System.ComponentModel.DataAnnotations;

namespace SixMinAPI.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string? HowTo {get; set;}

        [Required]
        [MaxLength(20)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}
