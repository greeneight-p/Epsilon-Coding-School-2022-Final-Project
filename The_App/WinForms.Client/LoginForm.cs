using The_App.Shared;
using System.Net.Http.Json;
using System.Net.Http;

namespace WinForms.Client {
    public partial class LoginForm : Form {

        private string URI = $"https://localhost:5001";
        private int port = 5001;
        private LoginViewModel _loginViewModel = new();
        public LoginForm() {
            InitializeComponent();
            var cHelper = new ControlPopulator();
            cHelper.PopulateEmployeeType(lookUpEditUsers.Properties);
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            label1.Text = $"Serve: {URI}";
            bsloginViewModel.DataSource = _loginViewModel;
            textEditPassword.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Password", true));
            lookUpEditUsers.DataBindings.Add(new Binding("EditValue", bsloginViewModel, "Type", true));
        }

        private async void simpleButtonLogin_Click(object sender, EventArgs e) {
            if (_loginViewModel.Password is null) {
                MessageBox.Show("Please fill the password.!");
                return;
            }
            string output = new string(_loginViewModel.Password.ToCharArray().Reverse().ToArray());
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URI);
            bool x = await httpClient.GetFromJsonAsync<bool>($"authentications/login/{_loginViewModel.Type}/{output}");
            if (x) {
                var mainForm = new MainForm(_loginViewModel.Type,URI);  
                mainForm.FormClosed += new FormClosedEventHandler(Form_Closed);
                mainForm.ShowDialog();
            }
            else {
                MessageBox.Show("Wrong User or Password.!");
            }
        }


        async void Form_Closed(object sender, FormClosedEventArgs e) {
            //CustomerDetailsForm customerDetailsForm = (CustomerDetailsForm)sender;
            textEditPassword.EditValue = string.Empty;
        }

        private void simpleButtonPort_Click(object sender, EventArgs e) {
            port = Convert.ToInt32(spinEditPort.EditValue);
            URI = $"https://localhost:{port}";
            label1.Text = $"Server: {URI}";

        }
    }
}