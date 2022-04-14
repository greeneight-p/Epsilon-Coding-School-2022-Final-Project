using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace The_App.Shared {
    public class TransactionViewModel {
        public Guid ID { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<TransactionLineViewModel> TransactionLines { get; set; } = new();
        public decimal TotalValue { get; set; }
        public decimal TotalCost { get; set; }
    }
}
