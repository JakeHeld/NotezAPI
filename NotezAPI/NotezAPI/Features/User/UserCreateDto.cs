using Microsoft.AspNetCore.Identity;

namespace NotezAPI.Features.User
{
    public class UserCreateDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}