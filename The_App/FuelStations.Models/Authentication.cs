using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Authentication : BaseEntity {
        public string AdminPass { get; set; }
        public string ManagerPass { get; set; }
        public string StaffPass { get; set; }
        public string CashierPass { get; set; }
    }
}
