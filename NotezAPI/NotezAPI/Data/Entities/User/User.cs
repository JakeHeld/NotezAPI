using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NotezAPI.Data.Entities.Shared;

namespace NotezAPI.Data.Entities.User
{
    public class User: IdentityUser<int>
    {
        public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
        
        public virtual ICollection<Lecture.Lecture> Lectures { get; set; }
        
        
    }
}