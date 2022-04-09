using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using The_App.Shared;
using static FuelStation.Models.Enumerations;

namespace The_App.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationsController : ControllerBase {

        private readonly IEntityRepo<Authentication> _authRepo;
        public AuthenticationsController(IEntityRepo<Authentication> authRepo) {
            _authRepo = authRepo;
        }


        [HttpGet("login/{type}/{Rpass}")]
        public async Task<bool> Authenticate(EmployeeType type, string Rpass) {


            var dbAuths = await _authRepo.GetAllAsync();
            bool result = false;
            string pass = new string(Rpass.ToCharArray().Reverse().ToArray());
            switch (type) {
                case EmployeeType.Admin:
                    foreach (var auth in dbAuths) {
                        if (pass == auth.AdminPassword) {
                            result = true;
                            break;
                        }
                    }
                    break;
                case EmployeeType.Manager:
                    foreach (var auth in dbAuths) {
                        if (pass == auth.ManagerPassword) {
                            result = true;
                            break;
                        }  
                    }
                    break;
                case EmployeeType.Staff:
                    foreach (var auth in dbAuths) {
                        if (pass == auth.StaffPassword) {
                            result = true;
                            break;
                        }
                    }
                    break;
                case EmployeeType.Cashier:
                    foreach (var auth in dbAuths) {
                        if (pass == auth.CashierPassword) {
                            result = true;
                            break;
                        }
                    }
                    break;
                default:
                    break;

            }

            return result;
        }
    }
}
