using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FuelStation.Models.Enumerations;

namespace WinForms.Client {
    public partial class MainForm : Form {

        private EmployeeType _employeeType;
        public MainForm(EmployeeType type) {

            _employeeType=type;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            if (_employeeType == EmployeeType.Staff) {
                customersToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible = false;
            }
            if (_employeeType == EmployeeType.Cashier) {
                itemsToolStripMenuItem.Visible = false;
            }
        }
    }
}
