using Microsoft.AspNetCore.Identity;


namespace NotezAPI.Data.Entities.Shared
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual User.User User { get; set; }
        public virtual Role.Role Role { get; set; }
        
    }
}