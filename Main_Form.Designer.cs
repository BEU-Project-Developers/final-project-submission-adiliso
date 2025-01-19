using Airline.Controls;
using System.Runtime.ExceptionServices;

namespace Airline
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            tabPageSearchBook = new TabPage();
            comboBoxCities = new ComboBox();
            numberOfPeople = new NumericUpDown();
            dtimeSearch = new DateTimePicker();
            searchButton2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabInfoPage = new TabPage();
            fisrt_Tab_Control2 = new Fisrt_Tab_Control();
            searchButton1 = new Button();
            flightIdBox = new TextBox();
            tabBoardPage = new TabPage();
            myFlightsButton = new Button();
            in24button = new Button();
            tabControl1 = new TabControl();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            label5 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            toolTipMain = new ToolTip(components);
            tabPageSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPeople).BeginInit();
            tabInfoPage.SuspendLayout();
            tabBoardPage.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabPageSearchBook
            // 
            tabPageSearchBook.Controls.Add(comboBoxCities);
            tabPageSearchBook.Controls.Add(numberOfPeople);
            tabPageSearchBook.Controls.Add(dtimeSearch);
            tabPageSearchBook.Controls.Add(searchButton2);
            tabPageSearchBook.Controls.Add(label4);
            tabPageSearchBook.Controls.Add(label3);
            tabPageSearchBook.Controls.Add(label2);
            tabPageSearchBook.Location = new Point(4, 64);
            tabPageSearchBook.Margin = new Padding(0);
            tabPageSearchBook.Name = "tabPageSearchBook";
            tabPageSearchBook.Padding = new Padding(0, 10, 10, 10);
            tabPageSearchBook.Size = new Size(192, 32);
            tabPageSearchBook.TabIndex = 2;
            tabPageSearchBook.Text = "     Search-book    ";
            tabPageSearchBook.UseVisualStyleBackColor = true;
            // 
            // comboBoxCities
            // 
            comboBoxCities.FormattingEnabled = true;
            comboBoxCities.Items.AddRange(new object[] { "Baku", "Istanbul" });
            comboBoxCities.Location = new Point(382, 43);
            comboBoxCities.Name = "comboBoxCities";
            comboBoxCities.Size = new Size(180, 39);
            comboBoxCities.TabIndex = 13;
            // 
            // numberOfPeople
            // 
            numberOfPeople.Location = new Point(382, 168);
            numberOfPeople.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfPeople.Name = "numberOfPeople";
            numberOfPeople.Size = new Size(79, 39);
            numberOfPeople.TabIndex = 12;
            numberOfPeople.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtimeSearch
            // 
            dtimeSearch.CalendarTitleBackColor = SystemColors.ControlText;
            dtimeSearch.CalendarTitleForeColor = Color.AliceBlue;
            dtimeSearch.CustomFormat = "dd MMM yyyy";
            dtimeSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtimeSearch.Format = DateTimePickerFormat.Custom;
            dtimeSearch.Location = new Point(382, 107);
            dtimeSearch.Name = "dtimeSearch";
            dtimeSearch.Size = new Size(180, 38);
            dtimeSearch.TabIndex = 11;
            // 
            // searchButton2
            // 
            searchButton2.BackColor = Color.FromArgb(55, 166, 219);
            searchButton2.Cursor = Cursors.Hand;
            searchButton2.FlatStyle = FlatStyle.Flat;
            searchButton2.ForeColor = SystemColors.Control;
            searchButton2.Location = new Point(632, 133);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(164, 70);
            searchButton2.TabIndex = 10;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = false;
            searchButton2.Click += searchButton2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(58, 182);
            label4.Name = "label4";
            label4.Size = new Size(218, 31);
            label4.TabIndex = 8;
            label4.Text = "Number of people :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(58, 117);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 6;
            label3.Text = "Enter date  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(58, 56);
            label2.Name = "label2";
            label2.Size = new Size(263, 31);
            label2.TabIndex = 4;
            label2.Text = "Enter destination point :";
            // 
            // tabInfoPage
            // 
            tabInfoPage.Controls.Add(fisrt_Tab_Control2);
            tabInfoPage.Controls.Add(searchButton1);
            tabInfoPage.Controls.Add(flightIdBox);
            tabInfoPage.Location = new Point(4, 64);
            tabInfoPage.Margin = new Padding(0);
            tabInfoPage.Name = "tabInfoPage";
            tabInfoPage.Size = new Size(192, 32);
            tabInfoPage.TabIndex = 1;
            tabInfoPage.Text = "     Flight Info     ";
            tabInfoPage.UseVisualStyleBackColor = true;
            // 
            // fisrt_Tab_Control2
            // 
            fisrt_Tab_Control2.Location = new Point(40, 112);
            fisrt_Tab_Control2.Margin = new Padding(4, 3, 4, 3);
            fisrt_Tab_Control2.Name = "fisrt_Tab_Control2";
            fisrt_Tab_Control2.Size = new Size(802, 110);
            fisrt_Tab_Control2.TabIndex = 4;
            fisrt_Tab_Control2.TabStop = false;
            fisrt_Tab_Control2.Visible = false;
            // 
            // searchButton1
            // 
            searchButton1.BackColor = Color.FromArgb(55, 166, 219);
            searchButton1.Cursor = Cursors.Hand;
            searchButton1.FlatStyle = FlatStyle.Flat;
            searchButton1.ForeColor = SystemColors.Control;
            searchButton1.Location = new Point(432, 37);
            searchButton1.Name = "searchButton1";
            searchButton1.Size = new Size(136, 47);
            searchButton1.TabIndex = 2;
            searchButton1.Text = "Search";
            searchButton1.UseVisualStyleBackColor = false;
            searchButton1.Click += searchButton1_Click;
            // 
            // flightIdBox
            // 
            flightIdBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            flightIdBox.Location = new Point(216, 42);
            flightIdBox.Name = "flightIdBox";
            flightIdBox.PlaceholderText = "Enter flight id ";
            flightIdBox.Size = new Size(173, 38);
            flightIdBox.TabIndex = 1;
            // 
            // tabBoardPage
            // 
            tabBoardPage.Controls.Add(myFlightsButton);
            tabBoardPage.Controls.Add(in24button);
            tabBoardPage.Location = new Point(4, 64);
            tabBoardPage.Margin = new Padding(0);
            tabBoardPage.Name = "tabBoardPage";
            tabBoardPage.Size = new Size(894, 235);
            tabBoardPage.TabIndex = 0;
            tabBoardPage.Text = "    Online board     ";
            tabBoardPage.UseVisualStyleBackColor = true;
            // 
            // myFlightsButton
            // 
            myFlightsButton.BackColor = Color.FromArgb(55, 166, 219);
            myFlightsButton.Cursor = Cursors.Hand;
            myFlightsButton.FlatStyle = FlatStyle.Flat;
            myFlightsButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myFlightsButton.ForeColor = SystemColors.Control;
            myFlightsButton.Location = new Point(503, 61);
            myFlightsButton.Name = "myFlightsButton";
            myFlightsButton.Size = new Size(332, 72);
            myFlightsButton.TabIndex = 1;
            myFlightsButton.Text = "Show my flights";
            myFlightsButton.UseVisualStyleBackColor = false;
            myFlightsButton.Click += myFlightsButton_Click;
            // 
            // in24button
            // 
            in24button.BackColor = Color.FromArgb(55, 166, 219);
            in24button.Cursor = Cursors.Hand;
            in24button.FlatStyle = FlatStyle.Flat;
            in24button.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            in24button.ForeColor = SystemColors.Control;
            in24button.Location = new Point(48, 61);
            in24button.Name = "in24button";
            in24button.Size = new Size(358, 72);
            in24button.TabIndex = 0;
            in24button.Text = "Show flights in next 24 hours";
            in24button.UseVisualStyleBackColor = false;
            in24button.Click += in24HoursButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBoardPage);
            tabControl1.Controls.Add(tabInfoPage);
            tabControl1.Controls.Add(tabPageSearchBook);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(190, 60);
            tabControl1.Location = new Point(255, 143);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(902, 303);
            tabControl1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(1115, 23);
            label5.Name = "label5";
            label5.Padding = new Padding(8);
            label5.Size = new Size(226, 47);
            label5.TabIndex = 13;
            label5.Text = "Personal Account";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1041, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(135, 28);
            label6.Name = "label6";
            label6.Size = new Size(242, 51);
            label6.TabIndex = 15;
            label6.Text = "Sky Wings";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // toolTipMain
            // 
            toolTipMain.Popup += toolTipMain_Popup;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1377, 770);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            tabPageSearchBook.ResumeLayout(false);
            tabPageSearchBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfPeople).EndInit();
            tabInfoPage.ResumeLayout(false);
            tabInfoPage.PerformLayout();
            tabBoardPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabPageSearchBook;
        private Button searchButton2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabInfoPage;
        private Button searchButton1;
        private TextBox flightIdBox;
        private TabPage tabBoardPage;
        private Button myFlightsButton;
        private Button in24button;
        private TabControl tabControl1;
        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private DateTimePicker dtimeSearch;
        private NumericUpDown numberOfPeople;
        private ComboBox comboBoxCities;
        private Fisrt_Tab_Control fisrt_Tab_Control2;
        private BindingSource bindingSource1;
        private ToolTip toolTipMain;
    }
}