using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class EmployeeConfig : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employees");
            builder.HasKey(employee=>employee.ID);
            builder.Property(employee => employee.Name).HasMaxLength(20);
            builder.Property(employee => employee.Surname).HasMaxLength(50);
            builder.Property(employee => employee.SalaryPerMonth).HasColumnType("decimal(10,2)");
        }
    }
}
