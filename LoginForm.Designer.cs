namespace Airline
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPanel = new Panel();
            showPassword = new CheckBox();
            btnSignUp2 = new Button();
            loginButton = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            labelLogin = new Label();
            toolTipLogin = new ToolTip(components);
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.Menu;
            loginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            loginPanel.Controls.Add(showPassword);
            loginPanel.Controls.Add(btnSignUp2);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(textBoxPassword);
            loginPanel.Controls.Add(textBoxUsername);
            loginPanel.Controls.Add(labelPassword);
            loginPanel.Controls.Add(labelUsername);
            loginPanel.Controls.Add(labelLogin);
            loginPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginPanel.Location = new Point(44, 31);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(409, 449);
            loginPanel.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Cursor = Cursors.Hand;
            showPassword.Font = new Font("Segoe UI", 12F);
            showPassword.Location = new Point(193, 255);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(168, 32);
            showPassword.TabIndex = 12;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // btnSignUp2
            // 
            btnSignUp2.BackColor = SystemColors.ActiveCaption;
            btnSignUp2.Cursor = Cursors.Hand;
            btnSignUp2.FlatStyle = FlatStyle.Flat;
            btnSignUp2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSignUp2.ForeColor = SystemColors.Control;
            btnSignUp2.Location = new Point(110, 381);
            btnSignUp2.Name = "btnSignUp2";
            btnSignUp2.Size = new Size(174, 50);
            btnSignUp2.TabIndex = 11;
            btnSignUp2.Text = "Sign up";
            btnSignUp2.UseVisualStyleBackColor = false;
            btnSignUp2.Click += button2_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(44, 141, 199);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.Control;
            loginButton.Location = new Point(40, 303);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(321, 58);
            loginButton.TabIndex = 10;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(179, 202);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(182, 38);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUsername.Location = new Point(179, 127);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(182, 38);
            textBoxUsername.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(40, 202);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(132, 31);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "password : ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUsername.Location = new Point(40, 127);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(133, 31);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "username : ";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(62, 39);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(110, 46);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 522);
            Controls.Add(loginPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button loginButton;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelLogin;
        private Button btnSignUp2;
        private ToolTip toolTipLogin;
        private CheckBox showPassword;
    }
}