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
            flight_View = new DataGridView();
            first_Tab_Control1 = new Controls.Fisrt_Tab_Control();
            ((System.ComponentModel.ISupportInitialize)flight_View).BeginInit();
            SuspendLayout();
            // 
            // flight_View
            // 
            flight_View.AllowUserToAddRows = false;
            flight_View.AllowUserToDeleteRows = false;
            flight_View.AllowUserToResizeColumns = false;
            flight_View.AllowUserToResizeRows = false;
            flight_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            flight_View.BackgroundColor = SystemColors.ActiveCaption;
            flight_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flight_View.Location = new Point(12, 12);
            flight_View.Name = "flight_View";
            flight_View.ReadOnly = true;
            flight_View.RowHeadersWidth = 51;
            flight_View.Size = new Size(776, 426);
            flight_View.TabIndex = 1;
            // 
            // first_Tab_Control1
            // 
            first_Tab_Control1.Location = new Point(12, 8);
            first_Tab_Control1.Name = "first_Tab_Control1";
            first_Tab_Control1.Size = new Size(776, 430);
            first_Tab_Control1.TabIndex = 0;
            first_Tab_Control1.Load += first_Tab_Control1_Load;
            // 
            // Flights_Info_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flight_View);
            Controls.Add(first_Tab_Control1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Flights_Info_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flights_Info_Form";
            Load += Flights_Info_Form_Load;
            ((System.ComponentModel.ISupportInitialize)flight_View).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView flight_View;
        private Controls.Fisrt_Tab_Control first_Tab_Control1;
    }
}