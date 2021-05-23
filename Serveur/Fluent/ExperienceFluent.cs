using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Fluent
{
    public class ExperienceFluent: EntityTypeConfiguration<Experience>
    {
        ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasColumnName("EXP_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(e => e.EmployeId)
                .HasColumnName("EMP_ID")
                .IsRequired();

            Property(e => e.Intitule)
                .HasColumnName("EXP_INTITULE")
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.Date)
                .HasColumnName("EXP_DATE")
                .IsRequired();
        }
    }
}
