using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using Task11.Models;

namespace Task11.Configurations
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(m => m.Id)
                   .IsRequired();

            builder.Property(m => m.Name)
                   .HasMaxLength(100);

            builder.Property(m => m.Description)
                   .HasMaxLength(100);

            builder.Property(m => m.Type)
                   .HasMaxLength(100);

            var data = new List<Medicament>
            {
                new Medicament { Id = 1, Name = "Weed", Description = "For hippies and other shit", Type = "Stronks" },
                new Medicament { Id = 2, Name = "MoodPill", Description = "For mentally desparate situations", Type = "Music" }
            };

            builder.HasData(data);
        }
    }
}
