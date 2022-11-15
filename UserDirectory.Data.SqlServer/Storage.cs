using Microsoft.EntityFrameworkCore;
using UserDirectory.Data.SqlServer.Config;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Data.SqlServer
{
    public class Storage : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public Storage(DbContextOptions<Storage> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);

            var types = modelBuilder.Model.GetEntityTypes();
            foreach (var type in types)
            {
                type.SetTableName(type.DisplayName());
            }

        }

    }
}
