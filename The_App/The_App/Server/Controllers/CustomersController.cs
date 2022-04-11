using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using The_App.Shared;

namespace The_App.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase {

        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomersController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> GetActiveCustomers() {
            var result = await _customerRepo.GetAllAsync();
            return result.FindAll(x => x.Status == true).Select(x => new CustomerViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }
        [HttpGet("getall")]
        public async Task<IEnumerable<CustomerViewModel>> GetAllCustomers() {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber
            });
        }

        [HttpPost]
        public async Task Post(CustomerViewModel customer) {

            var guid = Guid.NewGuid();
            var dbCustomer = new Customer
            {
                ID = guid,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = $"A-{guid}"
            };
            await _customerRepo.AddAsync(dbCustomer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            var dbCustomer = await _customerRepo.GetByIdAsync(id);
            if (dbCustomer == null) return NotFound();
            dbCustomer.Status = !dbCustomer.Status;
            await _customerRepo.UpdateAsync(id, dbCustomer);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerViewModel customer) {
            var dbCustomer = await _customerRepo.GetByIdAsync(customer.ID);
            if (dbCustomer == null) return NotFound();
            dbCustomer.ID = customer.ID;
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname=customer.Surname;
            if (customer.NewCardNumber) {
                var guid = Guid.NewGuid();
                dbCustomer.CardNumber = $"A-{guid}";
            }                  
            await _customerRepo.UpdateAsync(customer.ID, dbCustomer);
            return Ok();
        }

    }
}
