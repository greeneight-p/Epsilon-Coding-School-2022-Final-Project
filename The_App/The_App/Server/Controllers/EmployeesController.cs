using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using The_App.Shared;

namespace The_App.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase {


        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeesController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeViewModel>> GetActiveEmployees() {
            var result = await _employeeRepo.GetAllAsync();
            return result.FindAll(x => x.Status == true).Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Name = x.Name,
                Surname = x.Surname,
                EmployeeType = x.EmployeeType,
                HireDate = x.HireDate,
                DismissDate = x.DismissDate,
                SalaryPerMonth = x.SalaryPerMonth
            });
        }

        [HttpGet("getall")]
        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployees() {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Name = x.Name,
                Surname = x.Surname,
                EmployeeType = x.EmployeeType,
                HireDate = x.HireDate,
                DismissDate = x.DismissDate,
                SalaryPerMonth = x.SalaryPerMonth
            });
        }
        [HttpGet("{id}")]
        public async Task<EmployeeViewModel> GetOneEmployee(Guid id) {
            var result = await _employeeRepo.GetByIdAsync(id);
            return new EmployeeViewModel()
            {
                ID = result.ID,
                Status = result.Status,
                Name = result.Name,
                Surname = result.Surname,
                EmployeeType = result.EmployeeType,
                HireDate = result.HireDate,
                DismissDate = result.DismissDate,
                SalaryPerMonth = result.SalaryPerMonth
            };
        }

        [HttpPost]
        public async Task Post(EmployeeViewModel employee) {

            
            var dbEmployee = new Employee
            {
                ID = Guid.NewGuid(),
                Name = employee.Name,
                Surname = employee.Surname,
                HireDate = DateTime.Now,
                DismissDate = employee.DismissDate,
                EmployeeType = employee.EmployeeType,
                SalaryPerMonth= employee.SalaryPerMonth,    
            };
            await _employeeRepo.AddAsync(dbEmployee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            var dbEmployee = await _employeeRepo.GetByIdAsync(id);
            if (dbEmployee == null) return NotFound();
            if (dbEmployee.Status) {
                dbEmployee.DismissDate = DateTime.Now;
            }
            else {
                dbEmployee.HireDate = DateTime.Now;
                dbEmployee.DismissDate = DateTime.MinValue;
            }
                
            dbEmployee.Status = !dbEmployee.Status;
            await _employeeRepo.UpdateAsync(id, dbEmployee);
            return Ok();
        }


        [HttpPut]
        public async Task<ActionResult> Put(EmployeeViewModel employee) {
            var dbEmployee = await _employeeRepo.GetByIdAsync(employee.ID);
            if (dbEmployee == null) return NotFound();
            dbEmployee.ID = employee.ID;
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.EmployeeType = employee.EmployeeType;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;


            await _employeeRepo.UpdateAsync(employee.ID, dbEmployee);
            return Ok();
        }

    }
}
