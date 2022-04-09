using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        private FuelStationContext _context;
        public EmployeeRepo(FuelStationContext context) {
            _context = context;
        }
        public async Task AddAsync(Employee entity) {
            await _context.Employees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Employee id '{id}' was not found in database.!");
            _context.Employees.Remove(foundEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync() {
            return await _context.Employees.AsNoTracking().ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id) {
            return await _context.Employees.AsNoTracking().SingleOrDefaultAsync(employee => employee.ID == id);
        }

        public async Task UpdateAsync(Guid id, Employee entity) {
            var foundEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (foundEmployee is null)
                throw new KeyNotFoundException($"Employee id '{id}' was not found in database.!");
            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.HireDate = entity.HireDate;
            foundEmployee.DismissDate = entity.DismissDate;
            foundEmployee.Status = entity.Status;
            foundEmployee.EmployeeType = entity.EmployeeType;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            await _context.SaveChangesAsync();
        }
    }
}
