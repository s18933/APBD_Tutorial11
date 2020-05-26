using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using Task11.Models;

namespace Task11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(b =>b.Id);  
            
            builder.Property(d => d.Id)
                   .IsRequired();

            builder.Property(d => d.FirstName)
                   .HasMaxLength(100);

            builder.Property(d => d.LastName)
                   .HasMaxLength(100);

            builder.Property(d => d.Email)
                   .HasMaxLength(100);

            var data = new List<Doctor>
            {
                new Doctor { Id = 1, FirstName = "Jan", LastName = "Janych", Email = "janjanych@gmail.com" },
                new Doctor { Id = 2, FirstName = "Al", LastName = "Caholic", Email = "killboy@gmail.com" }
            };

            builder.HasData(data);
        }
    }
}
