namespace Airline
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            loginPanel = new Panel();
            btnSignUp2 = new Button();
            loginButton = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            toolTipLogin = new ToolTip(components);
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.Menu;
            loginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            loginPanel.Controls.Add(btnSignUp2);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(textBox3);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(label5);
            loginPanel.Controls.Add(label4);
            loginPanel.Controls.Add(label1);
            loginPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginPanel.Location = new Point(44, 31);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(409, 449);
            loginPanel.TabIndex = 1;
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
            loginButton.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(179, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 38);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(179, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 38);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(40, 224);
            label5.Name = "label5";
            label5.Size = new Size(132, 31);
            label5.TabIndex = 4;
            label5.Text = "password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(40, 149);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 3;
            label4.Text = "username : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(65, 61);
            label1.Name = "label1";
            label1.Size = new Size(110, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // toolTipLogin
            // 
            toolTipLogin.Popup += toolTipLogin_Popup;
            // 
            // Login_Form
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
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button loginButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnSignUp2;
        private ToolTip toolTipLogin;
    }
}