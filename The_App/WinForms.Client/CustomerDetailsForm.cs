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
    public partial class CustomerDetailsForm : Form {

        private CustomerViewModel _customerViewModel = new(); 
        private HttpClient httpClient = new();
        private bool _newCustomer = true;
        
        public CustomerDetailsForm(CustomerViewModel? model, string uri) {
            httpClient.BaseAddress = new Uri(uri);
            if (model is not null) {
                _newCustomer = false;
                _customerViewModel = model;
            }
            InitializeComponent();
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e) {
            //simpleButtonGenerateCard.Visible = false;
            if (!_newCustomer)
                simpleButtonGenerateCard.Enabled=true;
            bsCustomer.DataSource = _customerViewModel;
            textEditName.DataBindings.Add(new Binding("EditValue", bsCustomer, "Name", true));
            textEditSurname.DataBindings.Add(new Binding("EditValue", bsCustomer, "Surname", true));
        }

        private void simpleButtonGenerateNewCard_Click(object sender, EventArgs e) {
            var res = MessageBox.Show(this, "Are you sure you want to generate a new card!?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
                return;
                _customerViewModel.NewCardNumber = true;
        }

        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e) {
            //var res = MessageBox.Show(this, "Are you sure you want to save!?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (res != DialogResult.Yes)
            //    return;
            if (_newCustomer) {
               await httpClient.PostAsJsonAsync("customers", _customerViewModel);
            }
            else {
                await httpClient.PutAsJsonAsync("customers", _customerViewModel);
            }
            Close();
        }

        private void simpleButtonGenerateCard_Click(object sender, EventArgs e) {
            var res = MessageBox.Show(this, "Are you sure you want to generate a new card!?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes)
                return;
            _customerViewModel.NewCardNumber = true;
        }
    }
}
