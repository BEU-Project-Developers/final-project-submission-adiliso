using Airline.model.dto.request;
using Airline.service;

namespace Airline
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            FormsHelper.RoundItems([signUpPanel], 60);
            FormsHelper.RoundItems([btnSignUp], 50);
            FormsHelper.RoundItems([btnLogin2], 30);

            toolTipSignUp.SetToolTip(btnSignUp, "Click to create account");
            toolTipSignUp.SetToolTip(btnLogin2, "Click to go login form");
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            GoToLoginForm();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            PassengerService passengerService = new();

            var name = textBoxName.Text;
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var confirmPassword = textBoxCPassword.Text;

            var request = new PassengerCreateRequest
            {
                Name = name,
                Username = username,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            try
            {
                passengerService.Create(request);
                MessageBox.Show(@"Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            GoToLoginForm();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            textBoxCPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void GoToLoginForm()
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }
    }
}