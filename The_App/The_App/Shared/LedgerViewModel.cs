using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace The_App.Shared {
    public class LedgerViewModel {
        public int Year { get; set; }
        public MonthEnum Month { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Rent { get; set; }
    }
}
