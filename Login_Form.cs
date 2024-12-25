using Airline.model.dto.request;
using Airline.service;

namespace Airline
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            FormsHelper.RoundItems([loginPanel], 60);
            FormsHelper.RoundItems([loginButton], 40);
            FormsHelper.RoundItems([btnSignUp2], 30);

            toolTipLogin.SetToolTip(loginButton, "Click to login to your account");
            toolTipLogin.SetToolTip(btnSignUp2, "Click to go sign up form");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp_Form signUpForm = new SignUp_Form();
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
                passengerService.Login(request);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                return;
            }

            Hide();
            Main_Form mainForm = new Main_Form();
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