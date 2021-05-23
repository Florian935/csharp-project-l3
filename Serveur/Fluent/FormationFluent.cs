using Serveur.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur.Fluent
{
    public class FormationFluent: EntityTypeConfiguration<Formation>
    {
        FormationFluent()
        {
            ToTable("APP_FORMATION");
            HasKey(f => f.Id);

            Property(f => f.Id)
                .HasColumnName("FOR_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(f => f.EmployeId)
                .HasColumnName("EMP_ID")
                .IsRequired();

            Property(f => f.Intitule)
                .HasColumnName("FOR_INTITULE")
                .IsRequired()
                .HasMaxLength(50);

            Property(f => f.DateFormation)
                .HasColumnName("FOR_DATE")
                .IsRequired();
        }
    }
}
