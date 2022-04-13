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
    public partial class ItemDetailsForm : Form {

        private ItemViewModel _itemViewModel = new();
        private HttpClient httpClient = new();
        private bool _newItem = true;
        public ItemDetailsForm(ItemViewModel? model, string uri) {
            httpClient.BaseAddress = new Uri(uri);
            if (model is not null) {
                _newItem = false;
                _itemViewModel = model;
            }
            InitializeComponent();
        }

        private void ItemDetailsForm_Load(object sender, EventArgs e) {
            textEditCode.ReadOnly = true;
            bsItem.DataSource = _itemViewModel;
            textEditCode.DataBindings.Add(new Binding("EditValue", bsItem, "Code", true));
            textEditDescription.DataBindings.Add(new Binding("EditValue", bsItem, "Description", true));
            calcEditCost.DataBindings.Add(new Binding("EditValue", bsItem, "Cost", true));
            calcEditPrice.DataBindings.Add(new Binding("EditValue", bsItem, "Price", true));
            var cH = new ControlPopulator();
            cH.PopulateItemType(lookUpEditItemType.Properties);
            lookUpEditItemType.DataBindings.Add(new Binding("EditValue", bsItem, "ItemType", true));

        }
        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e) {
            if (_newItem) {
                await httpClient.PostAsJsonAsync("items", _itemViewModel);
            }
            else {
                await httpClient.PutAsJsonAsync("items", _itemViewModel);
            }
            Close();
        }


    }
}
