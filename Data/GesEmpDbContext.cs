using GesEmpAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class GesEmpDbContext : DbContext
    {
        public DbSet<Departement> Departements { get; set; } = null!;
        public DbSet<Employe> Employes { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>()
                .ToTable("departements");
            
            modelBuilder.Entity<Departement>()
                .Property(d => d.Nom)
                .IsRequired()
                .HasMaxLength(100);
            
            modelBuilder.Entity<Employe>()
                .ToTable("employes");
            
            modelBuilder.Entity<Employe>()
                .Property(e => e.NumeroCompte)
                .IsRequired()
                .HasMaxLength(50);
            
            modelBuilder.Entity<Employe>()
                .Property(e => e.Titulaire)
                .IsRequired()
                .HasMaxLength(100);
            
            modelBuilder.Entity<Employe>()
                .HasOne(e => e.Departement)
                .WithMany()
                .HasForeignKey(e => e.DepartementId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Port=8889;Database=GesEmpDB;User=root;Password=root;",
                new MySqlServerVersion(new Version(8, 0, 40))
            );
        }
    }
}
