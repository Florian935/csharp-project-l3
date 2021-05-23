using Serveur.Entities;
using System.Data.Entity;
using System.Reflection;

namespace Serveur
{
    public class MonContexte: DbContext
    {
        public MonContexte(): base("name=Cours1ConnexionString")
        {
        }

        public DbSet<Employe> Employes { get; set; }

        public DbSet<Experience> Experiences { get; set; }
        
        public DbSet<Formation> Formations { get; set; }
        
        public DbSet<Offre> Offres { get; set; }

        public DbSet<Postulation> Postulations { get; set; }

        public DbSet<Statut> Statuts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
