using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class AuthRepo : IEntityRepo<Authentication> {
        private readonly FuelStationContext _context;
        public AuthRepo(FuelStationContext context) {
            _context = context;
        }
        public async Task AddAsync(Authentication entity) {
            await _context.Authentications.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundAuth = await _context.Authentications.SingleOrDefaultAsync(x => x.ID == id);
            if (foundAuth is null)
                throw new KeyNotFoundException($"Authentication id '{id}' was not found in database.!");
            _context.Authentications.Remove(foundAuth);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Authentication>> GetAllAsync() {
            return await _context.Authentications.ToListAsync();
        }

        public async Task<Authentication?> GetByIdAsync(Guid id) {
            return await _context.Authentications.SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task UpdateAsync(Guid id, Authentication entity) {
            var foundAuth = await _context.Authentications.SingleOrDefaultAsync(x => x.ID == id);
            if (foundAuth is null)
                throw new KeyNotFoundException($"Authentication id '{id}' was not found in database.!");
            foundAuth.AdminPass = entity.AdminPass;
            foundAuth.ManagerPass = entity.ManagerPass;
            foundAuth.CashierPass = entity.CashierPass;
            foundAuth.StaffPass = entity.StaffPass;
            foundAuth.Status = entity.Status;
            await _context.SaveChangesAsync();
        }
    }
}
