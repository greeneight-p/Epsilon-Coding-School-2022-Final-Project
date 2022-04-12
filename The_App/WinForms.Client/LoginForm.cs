using The_App.Shared;
using System.Net.Http.Json;
using System.Net.Http;

namespace WinForms.Client {
    public partial class LoginForm : Form {


        private LoginViewModel _loginViewModel = new();
        public LoginForm() {
            InitializeComponent();
            var cH = new ControlPopulator();
            cH.PopulateEmployeeType(lookUpEditUsers.Properties);
        }

        private void LoginForm_Load(object sender, EventArgs e) {

            bsloginViewModel.DataSource = _loginViewModel;
            textEditPassword.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Password", true));
            lookUpEditUsers.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Type", true));
        }

        private async void simpleButtonLogin_Click(object sender, EventArgs e) {
            string output = new string(_loginViewModel.Password.ToCharArray().Reverse().ToArray());
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7110/");
            bool x = await httpClient.GetFromJsonAsync<bool>($"authentications/login/{_loginViewModel.Type}/{output}");
            if (x) {
                var mainForm = new MainForm(_loginViewModel.Type);
                
                mainForm.ShowDialog();
            }
        }
    }
}