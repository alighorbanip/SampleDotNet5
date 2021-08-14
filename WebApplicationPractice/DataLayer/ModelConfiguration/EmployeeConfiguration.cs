using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPractice.Models;

namespace WebApplicationPractice.DataLayer.ModelConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(o => o.EmployeeId);

            builder.Property(t => t.DateOfBirth)
                    .IsRequired()
                    .HasColumnType("Date")
                    .HasDefaultValueSql("GetDate()");

            builder.Property(x => x.PhoneNumber)
                    .IsUnicode(false)
                    .HasMaxLength(50);
        }
    }
}
