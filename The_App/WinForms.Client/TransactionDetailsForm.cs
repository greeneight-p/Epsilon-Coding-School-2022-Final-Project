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
using FuelStation.Models;

namespace WinForms.Client {
    public partial class TransactionDetailsForm : Form {
        private List<TransactionLineViewModel> _tLinesList = new();
        private TransactionViewModel _transaction = new();
        private CustomerViewModel _customer;
        private EmployeeViewModel _employee;
        private List<ItemViewModel> _itemList = new();
        private string _uri;
        private HttpClient httpClient = new();
        public TransactionDetailsForm(string uri, EmployeeViewModel employee, CustomerViewModel customer) {
            _uri = uri;
            httpClient.BaseAddress = new Uri(_uri);
            _customer = customer;
            _employee = employee;
            InitializeComponent();

        }
        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e) {
            InitiateTopLabels();
            PopulateItemsGrid();
            CreateTransactionLinesBinding();
            CreateTransactionBinding();

        }


        private async void PopulateItemsGrid() {
            _itemList = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("items");
            bsItems.DataSource = _itemList;
            gridControlItems.DataSource = bsItems;
        }

        private async void CreateTransactionLinesBinding() {
            bsTransactionLines.DataSource = _tLinesList;
            gridControlLines.DataSource = bsTransactionLines;
        }
        private async void CreateTransactionBinding() {
            bsTransaction.DataSource = _transaction;
            var cPopulator = new ControlPopulator();
            cPopulator.PopulatePaymentMethod(lookUpEditPaymentMethod.Properties);
            lookUpEditPaymentMethod.DataBindings.Add(new Binding("EditValue", bsTransaction, "PaymentMethod", true));
        }

        private void InitiateTopLabels() {
            labelEmployee.Text = $"Employee: {_employee.Name} {_employee.Surname}, {_employee.EmployeeType}";
            labelCustomer.Text = $"Customer: {_customer.Name} {_customer.Surname}";
        }

        private void simpleButtonAddItem_Click(object sender, EventArgs e) {
            var transactionLine = new TransactionLineViewModel();
            var item = bsItems.Current as ItemViewModel;
            int qty = Convert.ToInt32(spinEditQuantity.EditValue);
            PopulateTransactionLine(transactionLine, item, qty);
            _tLinesList.Add(transactionLine);
            gridViewLines.RefreshData();
        }




        private void PopulateTransactionLine(TransactionLineViewModel line, ItemViewModel item, int qty) {
            line.ItemID = item.ID;
            line.Quantity = qty;
            line.ItemPrice = item.Price;
            line.ItemCost = item.Cost;
            line.TotalCost = qty * item.Cost;
            line.NetValue = qty * item.Price;
            line.Quantity = qty;
            if (item.ItemType == Enumerations.ItemType.Fuel &&
                line.NetValue > 20) {
                line.DiscountPercent = 0.10m;
                line.DiscountValue = line.NetValue * line.DiscountPercent;
                line.TotalValue = line.NetValue - line.DiscountValue;
            }
            else {
                line.DiscountPercent = 0;
                line.DiscountValue = 0;
                line.TotalValue = line.NetValue;
            }



        }

        private void simpleButtonRemoveLine_Click(object sender, EventArgs e) {
            var line = bsTransactionLines.Current as TransactionLineViewModel;
            if (line is null) return;
            _tLinesList.Remove(line);
            gridViewLines.RefreshData();
        }
    }

}
