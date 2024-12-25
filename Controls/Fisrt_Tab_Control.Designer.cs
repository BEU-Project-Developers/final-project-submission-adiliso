namespace Airline.Controls
{
    partial class Fisrt_Tab_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            output_label = new Label();
            SuspendLayout();
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.BackColor = Color.Transparent;
            output_label.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            output_label.Location = new Point(16, 13);
            output_label.Name = "output_label";
            output_label.Size = new Size(64, 25);
            output_label.TabIndex = 0;
            output_label.Text = "flights";
            // 
            // Fisrt_Tab_Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(output_label);
            Name = "Fisrt_Tab_Control";
            Size = new Size(405, 151);
            Load += Fisrt_Tab_Control_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label output_label;
    }
}
