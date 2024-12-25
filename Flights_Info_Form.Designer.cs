namespace Airline
{
    partial class Flights_Info_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights_Info_Form));
            first_Tab_Control1 = new Controls.Fisrt_Tab_Control();
            SuspendLayout();
            // 
            // first_Tab_Control1
            // 
            first_Tab_Control1.Location = new Point(12, 8);
            first_Tab_Control1.Name = "first_Tab_Control1";
            first_Tab_Control1.Size = new Size(776, 430);
            first_Tab_Control1.TabIndex = 0;
            // 
            // Flights_Info_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(first_Tab_Control1);
            Icon = (Icon)resources.GetObject("this.Icon");
            Name = "Flights_Info_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flights_Info_Form";
            Load += Flights_Info_Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.Fisrt_Tab_Control first_Tab_Control1;
    }
}