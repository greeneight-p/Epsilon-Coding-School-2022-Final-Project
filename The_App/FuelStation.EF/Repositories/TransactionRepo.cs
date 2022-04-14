using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        private readonly FuelStationContext _context;
        public TransactionRepo(FuelStationContext context) {
            _context = context;
        }
        public async Task AddAsync(Transaction entity) {
            await _context.Transactions.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(trans => trans.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Transaction id '{id}' was not found in database.!");
            _context.Transactions.Remove(foundTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetAllAsync() {
           return await _context.Transactions
                .Include(foundTransaction => foundTransaction.TransactionLines)
                .Include(foundTransaction => foundTransaction.Employee)
                .Include(foundTransaction => foundTransaction.Customer)
                .ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id) {
            return await _context.Transactions
                .Include(foundTransaction => foundTransaction.TransactionLines)
                .Include(foundTransaction => foundTransaction.Employee)
                .Include(foundTransaction => foundTransaction.Customer)
                .SingleOrDefaultAsync(trans => trans.ID == id);
        }

        public async Task UpdateAsync(Guid id, Transaction entity) {
            var foundTransaction = await _context.Transactions
                .Include(foundTransaction=>foundTransaction.TransactionLines)
                .Include(foundTransaction => foundTransaction.Employee)
                .Include(foundTransaction => foundTransaction.Customer)
                .SingleOrDefaultAsync(trans => trans.ID == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Transaction id '{id}' was not found in database.!");
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.Date=entity.Date;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalValue = entity.TotalValue;
            foundTransaction.TransactionLines = entity.TransactionLines;
            foundTransaction.Status = entity.Status;
            await _context.SaveChangesAsync();
        }
    }
}
