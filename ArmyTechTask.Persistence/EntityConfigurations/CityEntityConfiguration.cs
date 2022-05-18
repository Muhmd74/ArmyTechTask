using System;
using ArmyTechTask.Domain.Entities.Cities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyTechTask.Persistence.EntityConfigurations
{
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");

            builder.Property(p => p.CityName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
