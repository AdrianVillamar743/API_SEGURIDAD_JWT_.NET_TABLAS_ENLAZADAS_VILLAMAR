using VILLAMAR_SECURE_API.IdentityAuth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VILLAMAR_SECURE_API.Models;

namespace VILLAMAR_SECURE_API.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Departamento> departamento { get; set; }
        public DbSet<Empleado> empleado { get; set; }
    }
}
    

