using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs
{
    public class CommandUpdateDTO : CommandCreateDTO
    {
        // This inherits all properties from CommandCreateDTO
        
        // [Required]
        // [MaxLength(250)]
        // public string? HowTo { get; set; }
        // [Required]
        // public string? Line { get; set; }
        // [Required]
        // public string? Platform { get; set; }
    }
}