using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotezAPI.Data;
using NotezAPI.Data.Entities.Role;
using NotezAPI.Data.Entities.User;
using NotezAPI.Features.User;

namespace NotezAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController: ControllerBase
    {
        private readonly UserManager<User> userManager;

        public UserController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        [HttpPost("create")]
        public async Task<ActionResult> Create(UserCreateDto dto)
        {
            var user = userManager.FindByNameAsync(dto.UserName);
            if (user != null)
            {
                return BadRequest("User already exists.");
            }
            
            var userToAdd = new User {UserName = dto.UserName};
            await userManager.CreateAsync(userToAdd, dto.Password);
            await userManager.AddToRoleAsync(userToAdd, dto.Role);

            return Ok();
        }
    }
}