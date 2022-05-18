using System;
using ArmyTechTask.Domain.Entities.Branches;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArmyTechTask.Persistence.EntityConfigurations
{
    public class BranchEntityConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            builder.Property(p => p.BranchName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
