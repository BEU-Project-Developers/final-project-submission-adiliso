using Airline.model.dto.request;
using Airline.service;

namespace Airline
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
            FormsHelper.RoundItems([signUpPanel], 60);
            FormsHelper.RoundItems([btnSignUp], 50);
            FormsHelper.RoundItems([btnLogin2], 30);

            toolTipSignUp.SetToolTip(btnSignUp, "Click to create account");
            toolTipSignUp.SetToolTip(btnLogin2, "Click to go login form");
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login_Form login_Form = new Login_Form();
            login_Form.FormClosed += (s, args) => Close();
            login_Form.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            PassengerService passengerService = new();

            var name = textBox1.Text;
            var username = textBox2.Text;
            var password = textBox3.Text;
            var confirmPassword = textBox4.Text;

            PassengerCreateRequest request = new PassengerCreateRequest
            {
                Name = name,
                Username = username,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            try
            {
                var response = passengerService.Create(request);
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Hide();
            Main_Form main_Form = new Main_Form();
            main_Form.FormClosed += (s, args) => Close();
            main_Form.ShowDialog();
        }

        private void toolTipSignUp_Popup(object sender, PopupEventArgs e)
        {

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !showPassword.Checked;
            textBox4.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}
