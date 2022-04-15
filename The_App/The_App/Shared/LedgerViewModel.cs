using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace The_App.Shared {
    public class LedgerViewModel {
        public int Year { get; set; } = 0;
        public MonthEnum Month { get; set; } 
        public decimal TotalIncome { get; set; } = 0m;
        public decimal TotalExpenses { get; set; } = 0m;
        public decimal TotalItemCost { get; set; } = 0m;
        public decimal TotalSalaries { get; set; } = 0m;
        public decimal Rent { get; set; } = 0m;
        public decimal Ledger { get; set; } = 0m;
    }
}
