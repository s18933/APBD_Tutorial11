using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Task11.Models;

namespace Task11.Configurations
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(p => p.Id)
                   .IsRequired();

            builder.Property(p => p.FirstName)
                   .HasMaxLength(100);

            builder.Property(p => p.LastName)
                   .HasMaxLength(100);

            var data = new List<Patient>
            {
                new Patient { Id = 1, FirstName = "Sans", LastName = "TheSkeleton", BirthDate = new DateTime(1999, 10, 10) },
                new Patient { Id = 2, FirstName = "Frisk", LastName = "TheHuman", BirthDate = new DateTime(2012, 12, 5) }
            };

            builder.HasData(data);
        }
    }
}
