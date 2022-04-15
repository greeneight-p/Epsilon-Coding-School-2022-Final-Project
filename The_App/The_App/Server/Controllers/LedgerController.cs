using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using The_App.Shared;
using static FuelStation.Models.Enumerations;

namespace The_App.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class LedgerController : ControllerBase {

        private IEntityRepo<Employee> _employeeRepo;
        private IEntityRepo<Transaction> _transactionsRepo;
        public LedgerController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionsRepo) {
            _employeeRepo = employeeRepo;
            _transactionsRepo = transactionsRepo;
        }



        [HttpGet("calc/{month}/{year}/{rent}")]
        public async Task<LedgerViewModel> CalculateLedger(MonthEnum month, int year, decimal rent) {
            var newLedger = new LedgerViewModel();
            int m = Convert.ToInt32(month);
            var employeeList = await _employeeRepo.GetAllAsync();
            var transactionList = await _transactionsRepo.GetAllAsync();
            transactionList = transactionList.FindAll(x => x.Date.Month == m && x.Date.Year == year);
            newLedger.Year = year;
            newLedger.Month = month;
            newLedger.TotalItemCost = transactionList.Sum(x => x.TotalCost);
            newLedger.TotalIncome = transactionList.Sum(x => x.TotalValue);
            newLedger.Rent = rent;
            foreach (var employee in employeeList) {//maxvalue shmainei oti akoma douleuei
                if (employee.HireDate.Month <= m && employee.HireDate.Year <= year && employee.DismissDate == DateTime.MaxValue) {
                    if(employee.HireDate.Month == DateTime.Now.Month) {
                        int days = DateTime.Now.Day - employee.HireDate.Day;
                        newLedger.TotalSalaries += (employee.SalaryPerMonth / 30) * days;
                    }else if(employee.HireDate.Month == m && m != DateTime.Now.Month) {
                        int days = 30 - employee.HireDate.Day;
                        newLedger.TotalSalaries += (employee.SalaryPerMonth / 30) * days;
                    }
                    else if(employee.HireDate.Month < m && m != DateTime.Now.Month) {
                        //newLedger.TotalSalaries += (employee.SalaryPerMonth / 30) * 30-employee.HireDate.Day;
                        newLedger.TotalSalaries += employee.SalaryPerMonth;
                    }else if (employee.HireDate.Month < m && m == DateTime.Now.Month) {
                        newLedger.TotalSalaries += (employee.SalaryPerMonth / 30) * DateTime.Now.Day;
                    }
                    else{
                        //newLedger.TotalSalaries += employee.SalaryPerMonth;
                    }                   
                }
                if(employee.HireDate.Month <= m && employee.HireDate.Year <= year && employee.DismissDate.Month <= m && employee.DismissDate.Year <= year) {
                    int days = employee.DismissDate.Day - employee.HireDate.Day;
                    newLedger.TotalSalaries += (employee.SalaryPerMonth / 30) * days;
                }
            }
            newLedger.TotalExpenses = newLedger.TotalItemCost + newLedger.TotalSalaries + newLedger.Rent;
            newLedger.Ledger = newLedger.TotalIncome - newLedger.TotalExpenses;
            return newLedger;
        }









    }
}
