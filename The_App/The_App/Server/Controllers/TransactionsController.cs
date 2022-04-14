using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using The_App.Shared;

namespace The_App.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionsController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> GetActiveTransactions() {
            var result = await _transactionRepo.GetAllAsync();
            return result.FindAll(x => x.Status == true).Select(x => new TransactionViewModel
            {
                ID = x.ID,
                Status = x.Status,
                CustomerID = x.CustomerID,
                EmployeeID = x.EmployeeID,
                Date = x.Date,
                PaymentMethod = x.PaymentMethod,
                TotalValue=x.TotalValue,
                TransactionLines = x.TransactionLines
            });
        }

        [HttpGet("getall")]
        public async Task<IEnumerable<TransactionViewModel>> GetAllTransactions() {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionViewModel
            {
                ID = x.ID,
                Status = x.Status,
                CustomerID = x.CustomerID,
                EmployeeID = x.EmployeeID,
                Date = x.Date,
                PaymentMethod = x.PaymentMethod,
                TotalValue = x.TotalValue,
                TransactionLines = x.TransactionLines
            });
        }

        [HttpPost]
        public async Task Post(TransactionViewModel transaction) {
            var dbTransaction = new Transaction
            {
                ID = Guid.NewGuid(),
                Status = transaction.Status,
                CustomerID= transaction.CustomerID,
                EmployeeID= transaction.EmployeeID,
                PaymentMethod= transaction.PaymentMethod,
                Date = transaction.Date,
                TotalValue= transaction.TotalValue,
                TransactionLines= transaction.TransactionLines
            };
            await _transactionRepo.AddAsync(dbTransaction);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            var dbTransaction = await _transactionRepo.GetByIdAsync(id);
            if (dbTransaction == null) return NotFound();
            dbTransaction.Status = !dbTransaction.Status;
            await _transactionRepo.UpdateAsync(id, dbTransaction);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionViewModel transaction) {
            var dbTransaction = await _transactionRepo.GetByIdAsync(transaction.ID);
            if (dbTransaction == null) return NotFound();
            dbTransaction.ID = transaction.ID;
            dbTransaction.CustomerID = transaction.CustomerID;
            dbTransaction.EmployeeID=transaction.EmployeeID;
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.TotalValue=dbTransaction.TotalValue;
            dbTransaction.Date = transaction.Date;
            dbTransaction.TransactionLines = transaction.TransactionLines;
            await _transactionRepo.UpdateAsync(transaction.ID, dbTransaction);
            return Ok();
        }
    }















}
