using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Fluent
{
    public class PostulationFluent: EntityTypeConfiguration<Postulation>
    {
        PostulationFluent()
        {
            ToTable("APP_POSTULATION");
            HasKey(p => new { p.OffreId, p.EmployeId } );

            Property(p => p.Id)
              .HasColumnName("POS_ID")
              .IsRequired()
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.OffreId)
                .HasColumnName("OFF_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.EmployeId)
               .HasColumnName("EMP_ID")
               .IsRequired()
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.DatePostulation)
                .HasColumnName("POS_DATE")
                .IsRequired();

            Property(p => p.Statut)
                .HasColumnName("POS_STATUT")
                .IsRequired();
        }
    }
}
