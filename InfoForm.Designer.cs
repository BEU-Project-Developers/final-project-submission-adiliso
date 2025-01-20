namespace Airline
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            dataView = new DataGridView();
            first_Tab_Control1 = new Controls.Fisrt_Tab_Control();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.BackgroundColor = SystemColors.ActiveCaption;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(12, 12);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(834, 299);
            dataView.TabIndex = 1;
            // 
            // first_Tab_Control1
            // 
            first_Tab_Control1.Location = new Point(12, 8);
            first_Tab_Control1.Name = "first_Tab_Control1";
            first_Tab_Control1.Size = new Size(776, 430);
            first_Tab_Control1.TabIndex = 0;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 323);
            Controls.Add(dataView);
            Controls.Add(first_Tab_Control1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(876, 497);
            MaximizeBox = false;
            MaximumSize = new Size(876, 497);
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataView;
        private Controls.Fisrt_Tab_Control first_Tab_Control1;
    }
}