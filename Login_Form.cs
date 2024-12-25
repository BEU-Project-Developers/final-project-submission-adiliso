using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SignUp_Form signUp_Form = new SignUp_Form();
            signUp_Form.FormClosed += (s, args) => Close();
            signUp_Form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Username can't be empty!");
                return;
            }
            Hide();
            Main_Form main_Form = new Main_Form();
            main_Form.FormClosed += (s, args) => Close();
            main_Form.ShowDialog();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void toolTipLogin_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
