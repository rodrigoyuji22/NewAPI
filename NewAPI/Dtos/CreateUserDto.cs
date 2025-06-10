using System.ComponentModel.DataAnnotations;

namespace NewAPI.Dtos
{
    public class CreateUserDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
