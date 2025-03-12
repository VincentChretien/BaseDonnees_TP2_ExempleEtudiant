using Microsoft.EntityFrameworkCore;
using ExempleEtudiant.Models;

namespace ExempleEtudiant.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        // RÉFÉRENCER LA TABLE ETUDIANT
        public DbSet<Etudiant> Etudiants { get; set; }

    }
}