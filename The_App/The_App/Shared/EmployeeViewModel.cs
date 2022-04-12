using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace The_App.Shared {
    public class EmployeeViewModel {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DismissDate { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool Status { get; set; }
    }
}
