using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NotezAPI.Data.Entities.Note;
using NotezAPI.Data.Entities.Lecture;
using NotezAPI.Data.Entities.Role;
using NotezAPI.Data.Entities.Shared;
using NotezAPI.Data.Entities.User;

namespace NotezAPI.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<MainIdea> MainIdeas { get; set; }
        public DbSet<Summary> Summaries { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var userRoleBuilder = builder.Entity<UserRole>();

            userRoleBuilder.HasKey(x => new {x.UserId, x.RoleId});

            userRoleBuilder.HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId);

            userRoleBuilder.HasOne(x => x.User)
                .WithMany(x => x.Roles)
                .HasForeignKey(x => x.UserId);

            /*var lectureBuilder = builder.Entity<Lecture>();
            lectureBuilder.HasOne(x => x.Lecturer)
                .WithMany(x => x.Lecture)
                .HasForeignKey(x => x.LecturerId);*/
        }
    }
}