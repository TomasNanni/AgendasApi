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
        public IActionResult GetOne([FromQuery] int userId, int contactId)
        {
            var contact = _contactService.GetOneByUser(userId, contactId);
            if (contact == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(contact);
            }
        }

        [HttpPost]
        public IActionResult CreateContact([FromQuery] int userId, CreateAndUpdateContactDto createContactDto)
        {
            var createdContact = _contactService.Create(createContactDto, userId);
            return Created();
        }

        [HttpPut]
        [Route("{contactId}")]
        public IActionResult UpdateContact(CreateAndUpdateContactDto dto, int contactId)
        {
            _contactService.Update(dto, contactId);
            return NoContent();
        }

        [HttpDelete]
        [Route("{contactId}")]
        public IActionResult DeleteContact([FromQuery] int userId, int contactId)
        {
            _contactService.Delete(contactId);
            return NoContent();
        }
    }
}
