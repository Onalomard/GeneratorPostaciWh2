using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeneratorPostaciWh2.Encje
{
    public class GeneratorContext : DbContext
    {
      

        public DbSet<Postac> Postacie { get; set; }
        public DbSet<Rasa> Rasy { get; set; }
        public DbSet<Profesja> Profesje { get; set; }
        public DbSet<Umiejetnosc> Umiejetnosci { get; set; }
        public DbSet<Wyposazenie> Wyposazenie { get; set; }
        public DbSet<Zdolnosc> Zdolnosci { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=" +
                Path.Combine(Application.StartupPath, "Resources", "Database", "GeneratorPostaci.mdf") +
                ";Integrated Security=True;Connect Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postac>(eb =>
            {
                eb.HasOne(p => p.Rasa)
                .WithMany(r => r.Postacie)
                .HasForeignKey(p => p.RasaId);

                eb.HasOne(p => p.Profesja)
                .WithMany(r => r.Postacie)
                .HasForeignKey(p => p.ProfesjaId);

                eb.HasMany(p => p.Umiejetnosci)
                .WithMany(u => u.Postacie);

                eb.HasMany(p => p.Zdolnosci)
                .WithMany(u => u.Postacie);

                eb.HasMany(p => p.Wyposazenie)
                .WithMany(u => u.Postacie);
            });
            modelBuilder.Entity<Rasa>(eb =>
            {
                eb.HasMany(r => r.Umiejetnosci)
                .WithMany(u => u.Rasy);

                eb.HasMany(r => r.Zdolnosci)
                .WithMany(u => u.Rasy);
            });
            modelBuilder.Entity<Profesja>(eb =>
            {
                eb.HasMany(p => p.Umiejetnosci)
                .WithMany(u => u.Profesje);

                eb.HasMany(p => p.Zdolnosci)
                .WithMany(u => u.Profesje);

                eb.HasMany(p => p.Wyposazenie)
                .WithMany(u => u.Profesje);
            });
            modelBuilder.Entity<Wyposazenie>(eb =>
            {
                eb.HasDiscriminator<string>("Typ")
                .HasValue<Bron>("Broń")
                .HasValue<Pancerz>("Pancerz")
                .HasValue<Inne>("Inne");
            });
            modelBuilder.Entity<Pancerz>()
             .Property(p => p.Lokalizacje)
             .HasConversion(
              v => v.ToString(), 
              v => (LokalizacjaCiala)Enum.Parse(typeof(LokalizacjaCiala), v)
    );
            modelBuilder.Entity<Umiejetnosc>(eb =>
            {
                eb.HasMany(p => p.Specjalizacje)
                .WithOne(s => s.Umiejetnosc)
                .HasForeignKey(s => s.UmiejetnoscId);
            }

            );

        }

    }
}
