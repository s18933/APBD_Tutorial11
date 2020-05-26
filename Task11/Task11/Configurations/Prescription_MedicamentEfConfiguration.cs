using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task11.Models;

namespace Task11.Configurations
{
    public class Prescription_MedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {

        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(k => new { k.IdMedicament, k.IdPrescription });

            builder.Property(p_m => p_m.Dose)
                     .IsRequired();

            builder.Property(p => p.Details)
                   .HasMaxLength(100);

            var data = new List<Prescription_Medicament>
            {
                new Prescription_Medicament { IdMedicament = 2, IdPrescription = 1, Dose = 5, Details = "Mood Pill of type C(piano/violin)" }
            };

            builder.HasData(data);
        }
    }
}
