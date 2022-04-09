using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStations.Models {
    public class Enumerations {

        public  enum ItemType {
            Fuel,
            Product,
            Service
        }

        public enum EmployeeType {
            Manager,
            Staff,
            Cashier
        }

        public enum PaymentMethod {
            CreditCard,
            Cash
        }


    }
}
