using Airline.model.dto.request;
using Airline.service;
using static Airline.FormsHelper;

namespace Airline
{
    public partial class Login_Form : Form
    {
        public Login_Form()
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
            var signUpForm = new SignUp_Form();
            signUpForm.FormClosed += (s, args) => Close();
            signUpForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            PassengerService passengerService = new();

            var request = new PassengerLoginRequest
            {
                Username = textBox2.Text,
                Password = textBox3.Text
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
            var mainForm = new Main_Form();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.ShowDialog();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
        }

        private void toolTipLogin_Popup(object sender, PopupEventArgs e)
        {
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}