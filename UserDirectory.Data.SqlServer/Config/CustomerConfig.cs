using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDirectory.Domain.Config;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Data.SqlServer.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
                .HasColumnType("varchar(max)");

            builder.Property(c => c.LastName)
              .HasColumnType("varchar(max)");

            builder.Property(c => c.DateOfBirth)
                .HasColumnType("varchar(max)");

            builder.Property(c => c.EmailAddress)
             .HasColumnType("varchar(max)");

            builder.Property(c => c.Address)
             .HasColumnType("varchar(max)");

            builder.Property(c => c.City)
             .HasColumnType("varchar(max)");

            builder.Property(c => c.Country)
             .HasColumnType("varchar(max)");

            builder.Property(c => c.ZipCode)
             .HasColumnType("varchar(max)");


            // SEED DATA
            var defaultConfig = new DefaultConfig();
            builder.HasData(defaultConfig.Customers);
        }

    }
}
