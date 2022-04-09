using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class TransactionLineConfig : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLines");
            builder.HasKey(transline => transline.ID);
            builder.Property(transline => transline.ItemPrice).HasColumnType("decimal(10,2)");
            builder.Property(transline => transline.NetValue).HasColumnType("decimal(10,2)");
            builder.Property(transline => transline.DiscountPercent).HasColumnType("decimal(3,2)");
            builder.Property(transline => transline.DiscountValue).HasColumnType("decimal(10,2)");
            builder.Property(transline => transline.TotalValue).HasColumnType("decimal(10,2)");
            //Relations
            builder.HasOne(transline=>transline.Transaction).WithMany(trans=>trans.TransactionLines).HasForeignKey(transline=>transline.TransactionID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(transline=>transline.Item).WithMany(item=>item.TransactionLines).HasForeignKey(transline=>transline.ItemID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
