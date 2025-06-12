using System.ComponentModel.DataAnnotations;

namespace NewAPI.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Nome { get; set; } =  string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
