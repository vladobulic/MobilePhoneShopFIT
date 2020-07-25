using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RepositoryLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<BannedKupac> BannedKupci { get; set; }
        public DbSet<Dobavljac> Dobavljaci { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Komentar> Komentari { get; set; }
        public DbSet<Komponente> Komponente { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Mobiteli> Mobiteli { get; set; }
        public DbSet<Narudzba> Narudzbe { get; set; }
        public DbSet<Novosti> Novosti { get; set; }
        public DbSet<OperativniSustav> OperativniSustavi { get; set; }
        public DbSet<Popusti> Popusti { get; set; }
        public DbSet<Poruka> Poruke { get; set; }
        public DbSet<Proizvodjac> Proizvodjaci { get; set; }
        public DbSet<Servis> Servisi { get; set; }
        public DbSet<Slika> Slike { get; set; }
        public DbSet<SmsLog> SmsLog { get; set; }
        public DbSet<StavkaNarudzbe> StavkeNarudzbe { get; set; }
        public DbSet<StavkaServisa> StavkaServisa { get; set; }
        public DbSet<TipKomponente> TipKomponente { get; set; }
        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            //modelBuilder.Entity<Administrator>();
            //modelBuilder.Entity<BannedKupac>();
            //modelBuilder.Entity<Dobavljac>();
            //modelBuilder.Entity<Grad>();
            //modelBuilder.Entity<Komentar>();
            //modelBuilder.Entity<Komponente>();
            //modelBuilder.Entity<Kupac>();
            //modelBuilder.Entity<Log>();
            //modelBuilder.Entity<Mobiteli>();
            //modelBuilder.Entity<Narudzba>();
            //modelBuilder.Entity<Novosti>();
            //modelBuilder.Entity<OperativniSustav>();
            //modelBuilder.Entity<Popusti>();
            //modelBuilder.Entity<Poruka>();
            //modelBuilder.Entity<Proizvodjac>();
            //modelBuilder.Entity<Servis>();
            //modelBuilder.Entity<Slika>();
            //modelBuilder.Entity<SmsLog>();
            //modelBuilder.Entity<StavkaNarudzbe>();
            //modelBuilder.Entity<StavkaServisa>();
            //modelBuilder.Entity<TipKomponente>();
            //modelBuilder.Entity<Zaposlenik>();
            //modelBuilder.Entity<Zupanija>();
        }
    }
}
