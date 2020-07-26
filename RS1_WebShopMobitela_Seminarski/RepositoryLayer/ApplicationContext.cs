using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace RepositoryLayer
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
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
            // seed initial db with data.
            SeedDb.Make(modelBuilder);
            // add foreign key to aspnetusers table to match our existing users in the db.
            modelBuilder.Entity<Administrator>().HasOne(x => x.ApplicationUser).WithMany(x => x.Administratori);
            modelBuilder.Entity<Zaposlenik>().HasOne(x => x.ApplicationUser).WithMany(x => x.Zaposlenici);
            modelBuilder.Entity<Kupac>().HasOne(x => x.ApplicationUser).WithMany(x => x.Kupci);

        }


    }
}
