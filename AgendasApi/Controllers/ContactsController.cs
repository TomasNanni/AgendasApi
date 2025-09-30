using AgendasApi.Models.DTOs.Contact.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AgendasApi.Controllers
{
    public class ContactsController : Controller
    {
        ContactsController

        [HttpGet]
        public IActionResult GetAll()

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
