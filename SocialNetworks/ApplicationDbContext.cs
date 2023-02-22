using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetworks.Models.Users;

namespace SocialNetworks
{
    public class ApplicationDbContext : IdentityDbContext<User> {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
