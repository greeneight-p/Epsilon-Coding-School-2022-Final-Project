using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class TransactionConfig : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transactions");
            builder.HasKey(trans => trans.ID);
            builder.Property(trans => trans.TotalValue).HasColumnType("decimal(10,2)");
            builder.Property(trans => trans.TotalCost).HasColumnType("decimal(10,2)");
            //Relations
            builder.HasOne(trans=>trans.Employee).WithMany(employee=>employee.Transactions).HasForeignKey(trans=>trans.EmployeeID).OnDelete(DeleteBehavior.Restrict);    
            builder.HasOne(trans=>trans.Customer).WithMany(customer=>customer.Transactions).HasForeignKey(trans=>trans.CustomerID).OnDelete(DeleteBehavior.Restrict);    
        }
    }
}
