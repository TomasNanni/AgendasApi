using System.ComponentModel.DataAnnotations;

namespace AgendasApi.Models.DTOs.User.Responses
{
    public class GetUserByIdDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public enum MyEnum
        {
            Active,
            Deleted
        }
        public MyEnum State { get; set; } = MyEnum.Active;
    }
}
