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
    public partial class CustomerListForm : Form {
        private string _uri;
        private List<CustomerViewModel> _customerList = new();
        private CustomerViewModel _customer = new();
        private HttpClient httpClient = new();
        private bool _activeCustomers = true;
        public CustomerListForm(string uri) {
            httpClient.BaseAddress = new Uri(uri);
            InitializeComponent();
        }

        private async void CustomerListForm_Load(object sender, EventArgs e) {
            await LoadCustomersAsync();
        }

        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e) {

        }

        private void simpleButtonNew_Click(object sender, EventArgs e) {

        }

        private  async void simpleButtonDelete_Click(object sender, EventArgs e) {
            await DeleteLogicAsync();
            await LoadCustomersAsync();


        }

        private async Task<bool> DeleteLogicAsync() {

            if (bsCustomers.Current as CustomerViewModel is null)
                return false;
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Customer?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes){
                var customer = bsCustomers.Current as CustomerViewModel;
                await httpClient.DeleteAsync($"customers/{customer.ID}");
                
            }
            return true;
        }




        private async Task LoadCustomersAsync() {

            _customerList = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("customers/getall");
            bsCustomers.DataSource = _customerList.Where(x => x.Status == _activeCustomers);
            gridControlCustomers.DataSource = bsCustomers;
            gridControlCustomers.RefreshDataSource();
            gridViewCustomers.RefreshData();

        }

        private async void simpleButtonReverseActive_Click(object sender, EventArgs e) {
            _activeCustomers = !_activeCustomers;
            if (_activeCustomers) {
                simpleButtonReverseActive.Text = "Show Deleted Customers";
            }
            else {
                simpleButtonReverseActive.Text = "Back";
            }
           await LoadCustomersAsync();
        }
    }
}
