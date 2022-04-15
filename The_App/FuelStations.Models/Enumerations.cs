using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models {
    public class Enumerations {

        public  enum ItemType {
            Fuel,
            Product,
            Service
        }

        public enum EmployeeType {
            Manager,
            Staff,
            Cashier,
            Admin=9
        }

        public enum PaymentMethod {
            CreditCard,
            Cash
        }

        public enum MonthEnum {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

    }
}
