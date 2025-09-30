using Microsoft.AspNetCore.Mvc;

namespace AgendasApi.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult<List<UserDto>> GetAll();

        [HttpGet("{id}")]
        public IActionResult GetOneById(int id);

        [HttpPut("{userId}")]
        public IActionResult UpdateUser(CreateAndUpdateUserDto dto, int userId);

        [HttpDelete]
        public IActionResult DeleteUser(int id);

    }
}
