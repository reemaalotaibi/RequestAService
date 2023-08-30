using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RequestAService.Data.Entities;

namespace RequestAService.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fields> Fields { get; set; }
        public DbSet<ServiceProviders> ServiceProviders { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Services> Services { get; set; }
    }
}