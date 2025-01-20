namespace Airline
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            signUpPanel = new Panel();
            checkBoxShowPassword = new CheckBox();
            btnLogin2 = new Button();
            btnSignUp = new Button();
            textBoxCPassword = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxName = new TextBox();
            labelConfirmPassword = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelName = new Label();
            labelSignUp = new Label();
            toolTipSignUp = new ToolTip(components);
            signUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // signUpPanel
            // 
            signUpPanel.BackColor = SystemColors.Menu;
            signUpPanel.Controls.Add(checkBoxShowPassword);
            signUpPanel.Controls.Add(btnLogin2);
            signUpPanel.Controls.Add(btnSignUp);
            signUpPanel.Controls.Add(textBoxCPassword);
            signUpPanel.Controls.Add(textBoxPassword);
            signUpPanel.Controls.Add(textBoxUsername);
            signUpPanel.Controls.Add(textBoxName);
            signUpPanel.Controls.Add(labelConfirmPassword);
            signUpPanel.Controls.Add(labelPassword);
            signUpPanel.Controls.Add(labelUsername);
            signUpPanel.Controls.Add(labelName);
            signUpPanel.Controls.Add(labelSignUp);
            signUpPanel.Location = new Point(36, 38);
            signUpPanel.Name = "signUpPanel";
            signUpPanel.Size = new Size(535, 553);
            signUpPanel.TabIndex = 0;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.Font = new Font("Segoe UI", 12F);
            checkBoxShowPassword.Location = new Point(324, 354);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(168, 32);
            checkBoxShowPassword.TabIndex = 1;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = SystemColors.ActiveCaption;
            btnLogin2.Cursor = Cursors.Hand;
            btnLogin2.FlatStyle = FlatStyle.Flat;
            btnLogin2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin2.ForeColor = SystemColors.Control;
            btnLogin2.Location = new Point(151, 485);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(191, 55);
            btnLogin2.TabIndex = 12;
            btnLogin2.Text = "Login";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(44, 141, 199);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.Control;
            btnSignUp.Location = new Point(52, 405);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(421, 63);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // textBoxCPassword
            // 
            textBoxCPassword.Font = new Font("Segoe UI", 13F);
            textBoxCPassword.Location = new Point(277, 302);
            textBoxCPassword.Name = "textBoxCPassword";
            textBoxCPassword.Size = new Size(215, 36);
            textBoxCPassword.TabIndex = 9;
            textBoxCPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13F);
            textBoxPassword.Location = new Point(277, 233);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(215, 36);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUsername.Location = new Point(277, 169);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(215, 38);
            textBoxUsername.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName.Location = new Point(277, 93);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(215, 38);
            textBoxName.TabIndex = 6;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelConfirmPassword.Location = new Point(38, 305);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(213, 31);
            labelConfirmPassword.TabIndex = 5;
            labelConfirmPassword.Text = "confirm password :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(38, 240);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(132, 31);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "password : ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUsername.Location = new Point(38, 169);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(133, 31);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "username : ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(38, 96);
            labelName.Name = "labelName";
            labelName.Size = new Size(83, 31);
            labelName.TabIndex = 1;
            labelName.Text = "name :";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSignUp.Location = new Point(52, 35);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(146, 46);
            labelSignUp.TabIndex = 0;
            labelSignUp.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            AcceptButton = btnSignUp;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1138, 629);
            Controls.Add(signUpPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp_Form";
            signUpPanel.ResumeLayout(false);
            signUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel signUpPanel;
        private Label labelName;
        private Label labelSignUp;
        private Label labelConfirmPassword;
        private Label labelPassword;
        private Label labelUsername;
        private TextBox textBoxCPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxName;
        private Button btnSignUp;
        private Button btnLogin2;
        private ToolTip toolTipSignUp;
        private CheckBox checkBoxShowPassword;
    }
}