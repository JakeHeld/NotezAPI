using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NotezAPI.Data.Entities.Shared;

namespace NotezAPI.Data.Entities.Role
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> Users { get; set; } = new List<UserRole>();
    }
}