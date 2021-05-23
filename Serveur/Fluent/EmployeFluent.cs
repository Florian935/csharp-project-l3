using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Fluent
{
    public class EmployeFluent: EntityTypeConfiguration<Employe>
    {
        EmployeFluent()
        {
            ToTable("APP_EMPLOYEE");
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("EMP_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(e => e.Nom)
                .HasColumnName("EMP_NOM")
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.Prenom)
                .HasColumnName("EMP_PRENOM")
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.DateNaissance)
                .HasColumnName("EMP_DATENAISSANCE")
                .IsRequired();

            Property(e => e.Anciennete)
                .HasColumnName("EMP_ANCIENNETE")
                .IsRequired();

            Property(e => e.Biographie)
                .HasColumnName("EMP_BIOGRAPHIE")
                .IsRequired();

            HasMany(e => e.Formations)
                .WithRequired(f => f.Employe)
                .HasForeignKey(f => f.EmployeId);

            HasMany(e => e.Experiences)
                .WithRequired(exp => exp.Employe)
                .HasForeignKey(exp => exp.EmployeId);

            HasMany(e => e.Postulations)
                .WithRequired(p => p.Employe)
                .HasForeignKey(p => p.EmployeId);
        }
    }
}
