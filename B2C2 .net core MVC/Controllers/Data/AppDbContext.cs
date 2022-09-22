using B2C2_.net_core_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace B2C2_.net_core_MVC.Controllers.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Beheerder> Beheerders { get; set; }

    }
}
