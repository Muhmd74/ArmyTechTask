using System;
using ArmyTechTask.Domain.Entities.InvoiceDetails;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyTechTask.Persistence.EntityConfigurations
{
    public class InvoiceDetailEntityConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetails");

            builder.Property(p => p.ItemName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.ItemCount)
                .IsRequired();

            builder.Property(p => p.ItemPrice)
                .IsRequired();
        }
    }
}
