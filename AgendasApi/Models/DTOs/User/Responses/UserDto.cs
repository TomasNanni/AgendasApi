using System.ComponentModel.DataAnnotations;

namespace AgendasApi.Models.DTOs.User.Responses
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public State State { get; set; } = State.Active;
    }
}
