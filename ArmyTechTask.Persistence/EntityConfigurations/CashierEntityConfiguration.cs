using System;
using ArmyTechTask.Domain.Entities.Cashiers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyTechTask.Persistence.EntityConfigurations
{
    public class CashierEntityConfiguration : IEntityTypeConfiguration<Cashier>
    {
        public void Configure(EntityTypeBuilder<Cashier> builder)
        {
            builder.ToTable("Cashier");

            builder.Property(p => p.CashierName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
