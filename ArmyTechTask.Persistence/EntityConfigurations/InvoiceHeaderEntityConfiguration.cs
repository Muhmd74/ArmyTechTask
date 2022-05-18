using System;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyTechTask.Persistence.EntityConfigurations
{
    public class InvoiceHeaderEntityConfiguration : IEntityTypeConfiguration<InvoiceHeader>
    {
        public void Configure(EntityTypeBuilder<InvoiceHeader> builder)
        {
            builder.ToTable("InvoiceHeader");

            builder.Property(p => p.CustomerName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
