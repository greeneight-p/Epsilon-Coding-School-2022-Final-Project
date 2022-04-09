using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionLinesRepo : IEntityRepo<TransactionLine> {
        private readonly FuelStationContext _context;

        public TransactionLinesRepo(FuelStationContext context) {
            _context = context;
        }
        public async Task AddAsync(TransactionLine entity) {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundLine = await _context.TransactionLines.SingleOrDefaultAsync(line => line.ID == id);
            if (foundLine is null)
                throw new KeyNotFoundException($"TransactionLine id '{id}' was not found in database");
            _context.TransactionLines.Remove(foundLine);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TransactionLine>> GetAllAsync() {
            return await _context.TransactionLines
                .Include(line => line.Item)
                .Include(line => line.Transaction)
                .ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id) {
            return await _context.TransactionLines
           .Include(line => line.Item)
           .Include(line => line.Transaction)
           .SingleOrDefaultAsync(line => line.ID == id);
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity) {
            var foundLine = await _context.TransactionLines
                .Include(line => line.Item)
                .Include(line => line.Transaction)
                .SingleOrDefaultAsync(line => line.ID == id);
            if (foundLine is null)
                throw new KeyNotFoundException($"TransactionLine id '{id}' was not found in database");
            foundLine.TransactionID = entity.TransactionID;
            foundLine.ItemID=entity.ItemID;
            foundLine.Quantity = entity.Quantity;
            foundLine.ItemPrice=entity.ItemPrice;
            foundLine.NetValue = entity.NetValue;
            foundLine.DiscountPercent = entity.DiscountPercent;
            foundLine.DiscountValue=entity.DiscountValue;
            foundLine.TotalValue = entity.TotalValue;
            foundLine.Status = entity.Status;
            await _context.SaveChangesAsync();
        }
    }
}
