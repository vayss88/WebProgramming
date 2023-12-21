using Microsoft.EntityFrameworkCore;

namespace wayss.Models
{
    public class RandevuDBContext : DbContext
    {
        public DbSet<Insan> Insanlar { get; set; }
        public DbSet<Randevular> Randevular { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Hastane> Hastaneler { get; set; }
        public DbSet<Klinik> Klinikler { get; set; }

        public RandevuDBContext (DbContextOptions<RandevuDBContext> options ) : base ( options )
        {

        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Veritabanı oluşturma konfigürasyonları buraya eklenir.
        }*/
    }
}
