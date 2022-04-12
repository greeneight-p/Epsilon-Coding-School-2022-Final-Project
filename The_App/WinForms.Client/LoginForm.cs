using The_App.Shared;
using System.Net.Http.Json;
using System.Net.Http;

namespace WinForms.Client {
    public partial class LoginForm : Form {

        private const string URI = "http://localhost:5000";

        private LoginViewModel _loginViewModel = new();
        public LoginForm() {
            InitializeComponent();
            var cHelper = new ControlPopulator();
            cHelper.PopulateEmployeeType(lookUpEditUsers.Properties);
        }

        private void LoginForm_Load(object sender, EventArgs e) {

            bsloginViewModel.DataSource = _loginViewModel;
            textEditPassword.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Password", true));
            lookUpEditUsers.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Type", true));
        }

        private async void simpleButtonLogin_Click(object sender, EventArgs e) {
            string output = new string(_loginViewModel.Password.ToCharArray().Reverse().ToArray());
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URI);
            bool x = await httpClient.GetFromJsonAsync<bool>($"authentications/login/{_loginViewModel.Type}/{output}");
            if (x) {
                var mainForm = new MainForm(_loginViewModel.Type,URI);
                
                mainForm.ShowDialog();
            }
        }
    }
}