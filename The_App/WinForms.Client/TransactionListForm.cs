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
    public partial class TransactionListForm : Form {
        private string _uri;
        private List<TransactionViewModel> _transactionList = new();
        private TransactionViewModel _transaction = new();
        private HttpClient httpClient = new();
        private bool _activeTransactions = true;
        private List<EmployeeViewModel> _employeeList = new();
        private List<CustomerViewModel> _customerList = new();
        public TransactionListForm(string uri) {
            _uri = uri;
            httpClient.BaseAddress = new Uri(_uri);
            InitializeComponent();
        }

        private void TransactionListForm_Load(object sender, EventArgs e) {
            LoadTransactionsAsync();
        }

        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void simpleButtonNew_Click(object sender, EventArgs e) {
            var startTransaction = new StartTransactionForm(_uri);
            startTransaction.FormClosed += new FormClosedEventHandler(Form_Closed);
            startTransaction.ShowDialog();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e) {

        }

        private async void simpleButtonDelete_Click(object sender, EventArgs e) {
            await DeleteLogicAsync();
            await LoadTransactionsAsync();
        }

        private async void simpleButtonReverseActiveTransactions_Click(object sender, EventArgs e) {
            _activeTransactions = !_activeTransactions;
            if (_activeTransactions) {
                simpleButtonReverseActiveTransactions.Text = "Show Deleted Transactions";
                simpleButtonDelete.Text = "Delete";
                simpleButtonEdit.Enabled = true;
                simpleButtonNew.Enabled = true;
            }
            else {
                simpleButtonReverseActiveTransactions.Text = "Back";
                simpleButtonDelete.Text = "Undo";
                simpleButtonEdit.Enabled = false;
                simpleButtonNew.Enabled = false;
            }
            await LoadTransactionsAsync();
        }



        private async Task LoadTransactionsAsync() {
            _customerList = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("customers/getall");
            _employeeList = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("employees/getall");
            _transactionList = await httpClient.GetFromJsonAsync<List<TransactionViewModel>>("transactions/getall");
            foreach (var transaction in _transactionList) {
                var customer = _customerList.Find(x => x.ID == transaction.CustomerID);
                var employee = _employeeList.Find(x => x.ID == transaction.EmployeeID);
                transaction.CustomerName = $"{customer.Name} {customer.Surname}";
                transaction.EmployeeName = $"{employee.Name} {employee.Surname}";
            }
            bsTransactions.DataSource = _transactionList.Where(x => x.Status == _activeTransactions);
            gridControlTransactions.DataSource = bsTransactions;
            gridControlTransactions.RefreshDataSource();
            gridViewTransactions.RefreshData();
        }


        async void Form_Closed(object sender, FormClosedEventArgs e) {
            //CustomerDetailsForm customerDetailsForm = (CustomerDetailsForm)sender;
            await LoadTransactionsAsync();
        }

        private async Task<bool> DeleteLogicAsync() {
            if (bsTransactions.Current as TransactionViewModel is null)
                return false;
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Transaction?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                var transaction = bsTransactions.Current as TransactionViewModel;
                await httpClient.DeleteAsync($"transactions/{transaction.ID}");
            }
            return true;
        }

    }
}
