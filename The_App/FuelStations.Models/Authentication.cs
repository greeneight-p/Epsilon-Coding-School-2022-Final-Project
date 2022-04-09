using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Authentication : BaseEntity {
        public string AdminPassword { get; set; }
        public string ManagerPassword { get; set; }
        public string CashierPassword { get; set; }
        public string StaffPassword { get; set; }

    }
}
