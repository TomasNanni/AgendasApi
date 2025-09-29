using System.ComponentModel.DataAnnotations;

namespace AgendasApi.Models.DTOs.Contact.Requests
{
    public class CreateAndUpdateContactDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string UrlImage { get; set; }
        public string Company { get; set; }
        [Required]
        public string Description { get; set; } = "";
    }
}
