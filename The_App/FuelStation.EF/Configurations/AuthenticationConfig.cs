using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class AuthenticationConfig : IEntityTypeConfiguration<Authentication> {
        public void Configure(EntityTypeBuilder<Authentication> builder) {
            builder.ToTable("Authentications");
            builder.HasKey(auth => auth.ID);
            builder.Property(auth => auth.AdminPassword).HasMaxLength(10);
            builder.Property(auth => auth.ManagerPassword).HasMaxLength(10);
            builder.Property(auth => auth.StaffPassword).HasMaxLength(10);
            builder.Property(auth => auth.CashierPassword).HasMaxLength(10);
        }
    }
}
