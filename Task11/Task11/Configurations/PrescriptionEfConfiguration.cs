using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Task11.Models;

namespace Task11.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(p => p.Id)
                    .IsRequired();

            var data = new List<Prescription>
            {
                new Prescription { Id = 1, Date = new DateTime(2020, 1, 4), DueDate = new DateTime(2020, 1, 20), IdPatient = 2, IdDoctor = 1 }
            };

            builder.HasData(data);
        }
    }
}
