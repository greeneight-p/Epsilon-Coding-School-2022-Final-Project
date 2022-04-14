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
    public partial class TransactionDetailsForm : Form {
        private List<TransactionLineViewModel> _tLinesList = new();
        private CustomerViewModel _customer;
        private EmployeeViewModel _employee;
        private string _uri;
        private HttpClient httpClient = new();
        private bool _activeItems = true;
        public TransactionDetailsForm(string uri, EmployeeViewModel employee, CustomerViewModel customer ) {
            _uri = uri;
            httpClient.BaseAddress = new Uri(_uri);
            _customer = customer;
            _employee=employee;

            InitializeComponent();

        }
        private void simpleButtonClose_Click(object sender, EventArgs e) {
        Close();
        }
    
}
