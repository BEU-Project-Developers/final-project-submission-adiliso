namespace Airline
{
    partial class SignUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            signUpPanel = new Panel();
            showPassword = new CheckBox();
            btnLogin2 = new Button();
            btnSignUp = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTipSignUp = new ToolTip(components);
            signUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // signUpPanel
            // 
            signUpPanel.BackColor = SystemColors.Menu;
            signUpPanel.Controls.Add(showPassword);
            signUpPanel.Controls.Add(btnLogin2);
            signUpPanel.Controls.Add(btnSignUp);
            signUpPanel.Controls.Add(textBox4);
            signUpPanel.Controls.Add(textBox3);
            signUpPanel.Controls.Add(textBox2);
            signUpPanel.Controls.Add(textBox1);
            signUpPanel.Controls.Add(label6);
            signUpPanel.Controls.Add(label5);
            signUpPanel.Controls.Add(label4);
            signUpPanel.Controls.Add(label2);
            signUpPanel.Controls.Add(label1);
            signUpPanel.Location = new Point(36, 38);
            signUpPanel.Name = "signUpPanel";
            signUpPanel.Size = new Size(535, 553);
            signUpPanel.TabIndex = 0;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Cursor = Cursors.Hand;
            showPassword.Font = new Font("Segoe UI", 12F);
            showPassword.Location = new Point(324, 354);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(168, 32);
            showPassword.TabIndex = 1;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
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
            btnLogin2.Click += button2_Click;
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
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(277, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 36);
            textBox4.TabIndex = 9;
            textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(277, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 36);
            textBox3.TabIndex = 8;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(277, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 38);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(277, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 38);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(38, 305);
            label6.Name = "label6";
            label6.Size = new Size(213, 31);
            label6.TabIndex = 5;
            label6.Text = "confirm password :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(38, 240);
            label5.Name = "label5";
            label5.Size = new Size(132, 31);
            label5.TabIndex = 4;
            label5.Text = "password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(38, 169);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 3;
            label4.Text = "username : ";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(38, 96);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 1;
            label2.Text = "name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // toolTipSignUp
            // 
            toolTipSignUp.Popup += toolTipSignUp_Popup;
            // 
            // SignUp_Form
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
            Name = "SignUp_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp_Form";
            Load += SignUp_Form_Load;
            signUpPanel.ResumeLayout(false);
            signUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel signUpPanel;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSignUp;
        private Button btnLogin2;
        private ToolTip toolTipSignUp;
        private CheckBox showPassword;
    }
}