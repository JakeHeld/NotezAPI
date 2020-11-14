using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace NotezAPI.Data.Entities
{
    public class User: IdentityUser<int>
    {
        public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
    }
}