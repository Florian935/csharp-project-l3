using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serveur.Fluent
{
    public class OffreFluent: EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_OFFRE");
            HasKey(o => o.Id);

            Property(o => o.Id)
                .HasColumnName("OFF_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(o => o.Intitule)
                .HasColumnName("OFF_INTITULE")
                .IsRequired()
                .HasMaxLength(50);

            Property(o => o.DateParution)
                .HasColumnName("OFF_DATE")
                .IsRequired();

            Property(o => o.Salaire)
                .HasColumnName("OFF_SALAIRE")
                .IsRequired();

            Property(o => o.Description)
                .HasColumnName("OFF_DESCRIPTION")
                .HasMaxLength(255)
                .IsRequired();

            Property(o => o.StatutId)
                .HasColumnName("STAT_ID")
                .IsRequired();

            Property(o => o.Responsable)
                .HasColumnName("OFF_REPONSABLE")
                .IsRequired();

            HasMany(o => o.Postulations)
                .WithRequired(p => p.Offre)
                .HasForeignKey(p => p.OffreId);
        }
    }
}
