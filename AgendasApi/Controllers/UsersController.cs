using AgendasApi.Entities;
using AgendasApi.Models.DTOs.User.Requests;
using AgendasApi.Models.DTOs.User.Responses;
using AgendasApi.Models.Interfaces;
using AgendasApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using System.Collections.Generic;

namespace AgendasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<UserDto> GetAll()
        {
            var users = _userService.GetAll();
            if (users == null)
            {
                return NoContent();
            }
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetOneById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);

        }

        [HttpPut("{userId}")]
        public IActionResult UpdateUser(CreateAndUpdateUserDto dto, int userId) 
        { 
            _userService.Update(dto, userId);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            _userService.RemoveUser(id);
            return Ok();
        }
    }
}
