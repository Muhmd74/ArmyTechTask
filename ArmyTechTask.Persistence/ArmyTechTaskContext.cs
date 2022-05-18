using System;
using ArmyTechTask.Domain.Entities.Branches;
using ArmyTechTask.Domain.Entities.Cashiers;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;
using Microsoft.EntityFrameworkCore;

namespace ArmyTechTask.Persistence
{
    public class ArmyTechTaskContext : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=.;Initial Catalog=ArmyTechTask;Integrated Security=SSPI;MultipleActiveResultSets=True");

            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<InvoiceHeader> InvoiceHeader { get; private set; }

        public DbSet<Cashier> Cashier { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArmyTechTaskContext).Assembly);

            base.OnModelCreating(modelBuilder);

        }
    }
}