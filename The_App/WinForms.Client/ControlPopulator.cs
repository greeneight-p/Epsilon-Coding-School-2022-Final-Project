using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Enumerations;

namespace WinForms.Client {
    public class ControlPopulator {

        public void PopulateEmployeeType(RepositoryItemLookUpEdit lookup) {
            var userTypes = new Dictionary<EmployeeType, string>()
        {
            { EmployeeType.Admin, "Admin" },
            { EmployeeType.Manager, "Manager" },
            { EmployeeType.Staff, "Staff" },
            { EmployeeType.Cashier, "Cashier" }
        };

            lookup.DataSource = userTypes;
            lookup.Columns.Add(new LookUpColumnInfo("Value"));
            lookup.DisplayMember = "Value";
            lookup.ValueMember = "Key";
            lookup.ShowHeader = false;
        }


    }
}
