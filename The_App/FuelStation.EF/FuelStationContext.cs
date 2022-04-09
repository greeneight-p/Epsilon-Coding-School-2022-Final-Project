using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Models;
using FuelStation.EF.Configurations;

namespace FuelStation.EF {
    public class FuelStationContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Authentication> Authentications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new ItemConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
            modelBuilder.ApplyConfiguration(new TransactionLineConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbFuelStation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
