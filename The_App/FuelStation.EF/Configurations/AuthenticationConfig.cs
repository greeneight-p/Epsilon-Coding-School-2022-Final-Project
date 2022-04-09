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
            builder.Property(auth => auth.AdminPass).HasMaxLength(10);
            builder.Property(auth => auth.ManagerPass).HasMaxLength(10);
            builder.Property(auth => auth.StaffPass).HasMaxLength(10);
            builder.Property(auth => auth.CashierPass).HasMaxLength(10);
        }
    }
}
