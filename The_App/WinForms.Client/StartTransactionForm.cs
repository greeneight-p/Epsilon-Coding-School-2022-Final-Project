using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_App.Shared;

namespace WinForms.Client {
    public partial class StartTransactionForm : Form {
        private List<EmployeeViewModel> _employeeList = new();
        private List<CustomerViewModel> _customerList = new();
        private string _uri;
        private HttpClient httpClient = new();
        private bool _activeItems = true;
        public StartTransactionForm(string uri) {
            _uri = uri;
            httpClient.BaseAddress = new Uri(_uri);
            InitializeComponent();
        }


        private async void StartTransactionForm_Load(object sender, EventArgs e) {
            _customerList= await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("customers");
            _employeeList = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("employees");
            bsCustomers.DataSource= _customerList;
            bsEmployees.DataSource = _employeeList.Where(x => x.EmployeeType != Enumerations.EmployeeType.Staff && x.EmployeeType != Enumerations.EmployeeType.Admin);
            gridControlCustomers.DataSource = bsCustomers;
            gridControlEmployees.DataSource = bsEmployees;
            gridControlCustomers.RefreshDataSource();
            gridControlEmployees.RefreshDataSource();
            gridViewCustomers.RefreshData();
            gridViewEmployees.RefreshData();
        }
        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void simpleButtonConfirm_Click(object sender, EventArgs e) {

            var customer = bsCustomers.Current as CustomerViewModel;
            var employee = bsCustomers.Current as EmployeeViewModel;
            if (customer is null || employee is null) return;

            var transactionDetailsForm = new TransactionDetailsForm(_uri, employee, customer);
            transactionDetailsForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            transactionDetailsForm.ShowDialog();
        }

        private void Form_Closed(object? sender, FormClosedEventArgs e) {
            Close();
        }
    }
}
