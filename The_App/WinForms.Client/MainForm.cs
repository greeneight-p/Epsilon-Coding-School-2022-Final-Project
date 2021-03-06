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
        private string _uri;
        public MainForm(EmployeeType type, string uri) {
            _uri = uri;
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

        private void listToolStripMenuItem_Click(object sender, EventArgs e) {
            var customerForm = new CustomerListForm(_uri);
            customerForm.ShowDialog();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e) {
            var itemForm = new ItemListForm(_uri);
            itemForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            itemForm.ShowDialog();
        }

        private void Form_Closed(object? sender, FormClosedEventArgs e) {
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e) {
            var transactionsForm = new TransactionListForm(_uri);
            transactionsForm.ShowDialog();
        }
    }
}
