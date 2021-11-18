using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazzeXYZ
{
    public class Kontekst : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);

            Osoba osoba = new();
            modelBuilder.Entity<Osoba>().Property(nameof(osoba.Ime)).IsRequired();
            modelBuilder.Entity<Osoba>().Property(nameof(osoba.Prezime)).IsRequired();

            modelBuilder.Entity<Osoba>().HasData(
                new Osoba[]
                {
                    new Osoba{Id=-1, Ime = "Pera", Prezime = "Peric"},
                    new Osoba{Id=-2, Ime = "Neko", Prezime = "Nekic"},
                    new Osoba{Id=-3, Ime = "Trecko", Prezime= "Treckovic"}
                });
            base.OnModelCreating(modelBuilder);
        }

    }
}
