using System.Collections.Generic;

namespace NotezAPI.Features.Authentication
{
    public class UserRoleDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public IList<string> UserRoles { get; set; }
    }
}