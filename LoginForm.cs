using Airline.model.dto.request;
using Airline.service;
using static Airline.FormsHelper;

namespace Airline
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RoundItems([loginPanel], 60);
            RoundItems([loginButton], 40);
            RoundItems([btnSignUp2], 30);

            toolTipLogin.SetToolTip(loginButton, "Click to login to your account");
            toolTipLogin.SetToolTip(btnSignUp2, "Click to go sign up form");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var signUpForm = new SignUpForm();
            signUpForm.FormClosed += (s, args) => Close();
            signUpForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            PassengerService passengerService = new();

            var request = new PassengerLoginRequest
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };

            try
            {
                CURRENT_PASSENGER = passengerService.Login(request);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            Hide();
            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.ShowDialog();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}