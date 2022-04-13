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
    public partial class ItemListForm : Form {

        private List<ItemViewModel> _itemsList = new();
        private ItemViewModel _item = new();
        private string _uri;
        private HttpClient httpClient = new();
        private bool _activeItems = true;
        public ItemListForm(string uri) {
            _uri = uri;
            httpClient.BaseAddress = new Uri(uri);
            InitializeComponent();
        }

        private async void ItemListForm_Load(object sender, EventArgs e) {
            await LoadItemsAsync();
        }
        private void simpleButtonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void simpleButtonNew_Click(object sender, EventArgs e) {
            var itemDetailsForm = new ItemDetailsForm(null, _uri);
            itemDetailsForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            itemDetailsForm.ShowDialog();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e) {
            var item = bsItemList.Current as ItemViewModel;
            var itemDetailsForm = new ItemDetailsForm(item, _uri);
            itemDetailsForm.FormClosed += new FormClosedEventHandler(Form_Closed);
            itemDetailsForm.ShowDialog();
        }

        private async void simpleButtonDelete_Click(object sender, EventArgs e) {
            await DeleteLogicAsync();
            await LoadItemsAsync();
        }

        private async void simpleButtonReverseActiveItems_Click(object sender, EventArgs e) {
            _activeItems = !_activeItems;
            if (_activeItems) {
                simpleButtonReverseActiveItems.Text = "Show Deleted Items";
                simpleButtonDelete.Text = "Delete";
                simpleButtonEdit.Enabled = true;
                simpleButtonNew.Enabled = true;
            }
            else {
                simpleButtonReverseActiveItems.Text = "Back";
                simpleButtonDelete.Text = "Undo";
                simpleButtonEdit.Enabled = false;
                simpleButtonNew.Enabled = false;
            }
            await LoadItemsAsync();

        }

        private async Task LoadItemsAsync() {
            _itemsList = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("items/getall");
            bsItemList.DataSource = _itemsList.Where(x => x.Status == _activeItems);
            gridControlItems.DataSource = bsItemList;
            gridControlItems.RefreshDataSource();
            gridViewItems.RefreshData();
        }

        private async Task<bool> DeleteLogicAsync() {

            if (bsItemList.Current as ItemViewModel is null)
                return false;
            var result = MessageBox.Show(this, "Are you sure you want to delete the selected Item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                var item = bsItemList.Current as ItemViewModel;
                await httpClient.DeleteAsync($"items/{item.ID}");

            }
            return true;
        }

        async void Form_Closed(object sender, FormClosedEventArgs e) {
            //CustomerDetailsForm customerDetailsForm = (CustomerDetailsForm)sender;
            await LoadItemsAsync();
        }
    }
}
