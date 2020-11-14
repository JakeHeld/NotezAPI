using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace NotezAPI.Data.Entities
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> Users { get; set; } = new List<UserRole>();
    }
}