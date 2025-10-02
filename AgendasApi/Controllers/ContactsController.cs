using AgendasApi.Models.DTOs.Contact.Requests;
using AgendasApi.Models.Interfaces;
using AgendasApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int userId)
        {
            var contacts = _contactService.GetAllByUser(userId);

            return Ok(contacts);
        }

        [HttpGet("{contactId}")]
        public IActionResult GetOne(int contactId)

        [HttpPost]
        public IActionResult CreateContact(CreateAndUpdateContactDto createContactDto)

        [HttpPut]
        [Route("{contactId}")]
        public IActionResult UpdateContact(CreateAndUpdateContactDto dto, int contactId)

        [HttpDelete]
        [Route("{contactId}")]

    }
}
