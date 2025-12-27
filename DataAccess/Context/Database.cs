using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("ConsoleApp")]

namespace DataAccess.Context
{
    internal class Database : DbContext
    {
        public DbSet<Apotek> Apoteker { get; set; }
        public DbSet<Laegehus> Laegehuse { get; set; }
        public DbSet<Recept> Recept { get; set; }
        public DbSet<Ordination> Ordination { get; set; }

        public Database()
        {
            bool dbExist = this.Database.EnsureCreated();
            if (dbExist)
            {
                Console.WriteLine("Database Exist");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-BNJU8IC;Initial Catalog=Recept;Trusted_Connection=True;Integrated Security=SSPI; TrustServerCertificate=true");
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Recept;Trusted_Connection=True;Integrated Security=SSPI; TrustServerCertificate=true");

            }
        }


        // Hardcoded data til databasen
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apotek>().HasData(new Apotek[] {
                new Apotek (1,"Viby Apotek", "31938201","Ormslevvej 93"),
                new Apotek (2,"Brabrand Apotek", "71822110", "Edwin Rahrs vej1"),
                new Apotek (3,"Tilst Apotek", "91846378","Langkærvej 23B")
            });

            modelBuilder.Entity<Laegehus>().HasData(new Laegehus[] {
                new Laegehus(new List<Recept>(), 11, 123456, "Viby Lægehus", "92348674", "Damagervej 2D"),
                new Laegehus(new List<Recept>(), 12, 234567, "Brabrand Lægehus", "21349212", "Edwin Rahrs vej2"),
                new Laegehus(new List<Recept>(), 13, 345678, "Tislt Lægehus", "43562156", "Langkærvej 26B")
            });

            modelBuilder.Entity<Ordination>().HasData(new Ordination[]
            {
                new Ordination(1,1,"Mod betændelse","2 gange om dagen",2,1),
                new Ordination(2,1,"Mod allergi","1 gange om dagen",3,2)
            });

            modelBuilder.Entity<Recept>().HasData(new Recept[]
            {
                new Recept(new List<Ordination>(),1,123456,0101001122),
                new Recept(new List<Ordination>(),2,234567,0202002233)
            });
        }

        }
}
