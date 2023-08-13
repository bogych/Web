namespace BlyatRotEbalWeb.Data
{
         public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
            {

            }
            public DbSet<Camera> Camera { get; set; }
            public DbSet<Complect> Complect { get; set; }
            public DbSet<PC> PC { get; set; }
            public DbSet<Perefiria> Perefiria { get; set; }
            public DbSet<Teleki_Monitori> Ekrani { get; set; }

        }
    }

