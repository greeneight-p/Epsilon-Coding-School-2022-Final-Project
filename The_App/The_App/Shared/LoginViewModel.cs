using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace The_App.Shared {
    public class LoginViewModel {

        public EmployeeType Type { get; set; }
        public string Password { get; set; }
    }
}
