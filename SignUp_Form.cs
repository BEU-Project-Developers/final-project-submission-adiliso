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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Main_Form main_Form = new Main_Form();
            main_Form.FormClosed += (s, args) => Close();
            main_Form.ShowDialog();
        }

        private void toolTipSignUp_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
