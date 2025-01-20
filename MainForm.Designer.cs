using Airline.Controls;
using System.Runtime.ExceptionServices;

namespace Airline
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabPageSearchBook = new TabPage();
            checkDate = new CheckBox();
            originPoint = new ComboBox();
            labelOriginPoint = new Label();
            destPoint = new ComboBox();
            freeSeats = new NumericUpDown();
            dtimeSearch = new DateTimePicker();
            searchButton2 = new Button();
            labelFreeSeats = new Label();
            labelDate = new Label();
            labelDestpoint = new Label();
            tabInfoPage = new TabPage();
            createBookingButton = new Button();
            searchButton1 = new Button();
            flightIdBox = new TextBox();
            tabBoardPage = new TabPage();
            labelShowFlights = new Label();
            in24button = new Button();
            tabControl1 = new TabControl();
            tabPageBookings = new TabPage();
            cancelBookingButton = new Button();
            textBoxBookingId = new TextBox();
            activeFlightsButton = new Button();
            myFlightsButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            accountLabel = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            labelProjectName = new Label();
            pictureBoxIcon = new PictureBox();
            bindingSource1 = new BindingSource(components);
            toolTipMain = new ToolTip(components);
            logOutBtn = new Button();
            tabPageSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)freeSeats).BeginInit();
            tabInfoPage.SuspendLayout();
            tabBoardPage.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabPageSearchBook
            // 
            tabPageSearchBook.Controls.Add(checkDate);
            tabPageSearchBook.Controls.Add(originPoint);
            tabPageSearchBook.Controls.Add(labelOriginPoint);
            tabPageSearchBook.Controls.Add(destPoint);
            tabPageSearchBook.Controls.Add(freeSeats);
            tabPageSearchBook.Controls.Add(dtimeSearch);
            tabPageSearchBook.Controls.Add(searchButton2);
            tabPageSearchBook.Controls.Add(labelFreeSeats);
            tabPageSearchBook.Controls.Add(labelDate);
            tabPageSearchBook.Controls.Add(labelDestpoint);
            tabPageSearchBook.ImeMode = ImeMode.Disable;
            tabPageSearchBook.Location = new Point(4, 64);
            tabPageSearchBook.Margin = new Padding(0);
            tabPageSearchBook.Name = "tabPageSearchBook";
            tabPageSearchBook.Padding = new Padding(0, 10, 10, 10);
            tabPageSearchBook.Size = new Size(894, 293);
            tabPageSearchBook.TabIndex = 2;
            tabPageSearchBook.Text = "     Search-flights   ";
            tabPageSearchBook.UseVisualStyleBackColor = true;
            // 
            // checkDate
            // 
            checkDate.AutoSize = true;
            checkDate.Checked = true;
            checkDate.CheckState = CheckState.Checked;
            checkDate.Cursor = Cursors.Hand;
            checkDate.Location = new Point(580, 175);
            checkDate.Name = "checkDate";
            checkDate.Size = new Size(18, 17);
            checkDate.TabIndex = 18;
            checkDate.UseVisualStyleBackColor = true;
            checkDate.CheckedChanged += checkDate_CheckedChanged;
            // 
            // originPoint
            // 
            originPoint.FormattingEnabled = true;
            originPoint.Items.AddRange(new object[] { "Baku", "Istanbul", "Ankara", "New York", "Moscow", "Berlin", "Paris", "Madrid" });
            originPoint.Location = new Point(384, 39);
            originPoint.Name = "originPoint";
            originPoint.Size = new Size(180, 39);
            originPoint.TabIndex = 15;
            // 
            // labelOriginPoint
            // 
            labelOriginPoint.AutoSize = true;
            labelOriginPoint.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOriginPoint.Location = new Point(60, 52);
            labelOriginPoint.Name = "labelOriginPoint";
            labelOriginPoint.Size = new Size(209, 31);
            labelOriginPoint.TabIndex = 14;
            labelOriginPoint.Text = "Enter origin point :";
            // 
            // destPoint
            // 
            destPoint.FormattingEnabled = true;
            destPoint.Items.AddRange(new object[] { "Baku", "Istanbul", "Ankara", "New York", "Moscow", "Berlin", "Paris", "Madrid" });
            destPoint.Location = new Point(384, 97);
            destPoint.Name = "destPoint";
            destPoint.Size = new Size(180, 39);
            destPoint.TabIndex = 13;
            // 
            // freeSeats
            // 
            freeSeats.Location = new Point(384, 228);
            freeSeats.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            freeSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            freeSeats.Name = "freeSeats";
            freeSeats.Size = new Size(79, 39);
            freeSeats.TabIndex = 12;
            freeSeats.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtimeSearch
            // 
            dtimeSearch.AllowDrop = true;
            dtimeSearch.CalendarTitleBackColor = SystemColors.ControlText;
            dtimeSearch.CalendarTitleForeColor = Color.AliceBlue;
            dtimeSearch.CustomFormat = "dd MMM yyyy";
            dtimeSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtimeSearch.Format = DateTimePickerFormat.Custom;
            dtimeSearch.Location = new Point(384, 161);
            dtimeSearch.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtimeSearch.Name = "dtimeSearch";
            dtimeSearch.Size = new Size(180, 38);
            dtimeSearch.TabIndex = 11;
            dtimeSearch.Value = new DateTime(2025, 1, 20, 18, 21, 51, 0);
            // 
            // searchButton2
            // 
            searchButton2.BackColor = Color.FromArgb(55, 166, 219);
            searchButton2.Cursor = Cursors.Hand;
            searchButton2.FlatStyle = FlatStyle.Flat;
            searchButton2.ForeColor = SystemColors.Control;
            searchButton2.Location = new Point(663, 197);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(164, 70);
            searchButton2.TabIndex = 10;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = false;
            searchButton2.Click += searchButton2_Click;
            // 
            // labelFreeSeats
            // 
            labelFreeSeats.AutoSize = true;
            labelFreeSeats.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFreeSeats.Location = new Point(60, 236);
            labelFreeSeats.Name = "labelFreeSeats";
            labelFreeSeats.Size = new Size(132, 31);
            labelFreeSeats.TabIndex = 8;
            labelFreeSeats.Text = "Free Seats :";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate.Location = new Point(60, 171);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(138, 31);
            labelDate.TabIndex = 6;
            labelDate.Text = "Enter date  :";
            // 
            // labelDestpoint
            // 
            labelDestpoint.AutoSize = true;
            labelDestpoint.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDestpoint.Location = new Point(60, 110);
            labelDestpoint.Name = "labelDestpoint";
            labelDestpoint.Size = new Size(263, 31);
            labelDestpoint.TabIndex = 4;
            labelDestpoint.Text = "Enter destination point :";
            // 
            // tabInfoPage
            // 
            tabInfoPage.Controls.Add(createBookingButton);
            tabInfoPage.Controls.Add(searchButton1);
            tabInfoPage.Controls.Add(flightIdBox);
            tabInfoPage.Location = new Point(4, 64);
            tabInfoPage.Margin = new Padding(0);
            tabInfoPage.Name = "tabInfoPage";
            tabInfoPage.Size = new Size(894, 293);
            tabInfoPage.TabIndex = 1;
            tabInfoPage.Text = "     Flight Info     ";
            tabInfoPage.UseVisualStyleBackColor = true;
            // 
            // createBookingButton
            // 
            createBookingButton.BackColor = Color.FromArgb(55, 166, 219);
            createBookingButton.Cursor = Cursors.Hand;
            createBookingButton.FlatStyle = FlatStyle.Flat;
            createBookingButton.ForeColor = SystemColors.Control;
            createBookingButton.Location = new Point(432, 128);
            createBookingButton.Name = "createBookingButton";
            createBookingButton.Size = new Size(240, 65);
            createBookingButton.TabIndex = 3;
            createBookingButton.Text = "Create Booking";
            createBookingButton.UseVisualStyleBackColor = false;
            createBookingButton.Click += createBooking_Click;
            // 
            // searchButton1
            // 
            searchButton1.BackColor = Color.FromArgb(55, 166, 219);
            searchButton1.Cursor = Cursors.Hand;
            searchButton1.FlatStyle = FlatStyle.Flat;
            searchButton1.ForeColor = SystemColors.Control;
            searchButton1.Location = new Point(432, 37);
            searchButton1.Name = "searchButton1";
            searchButton1.Size = new Size(137, 53);
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
            tabBoardPage.Controls.Add(labelShowFlights);
            tabBoardPage.Controls.Add(in24button);
            tabBoardPage.Location = new Point(4, 64);
            tabBoardPage.Margin = new Padding(0);
            tabBoardPage.Name = "tabBoardPage";
            tabBoardPage.Size = new Size(894, 293);
            tabBoardPage.TabIndex = 0;
            tabBoardPage.Text = "    Online board     ";
            tabBoardPage.UseVisualStyleBackColor = true;
            // 
            // labelShowFlights
            // 
            labelShowFlights.AutoSize = true;
            labelShowFlights.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelShowFlights.Location = new Point(60, 46);
            labelShowFlights.Name = "labelShowFlights";
            labelShowFlights.Size = new Size(416, 40);
            labelShowFlights.TabIndex = 1;
            labelShowFlights.Text = "Show flights in next 24 hours";
            // 
            // in24button
            // 
            in24button.BackColor = Color.FromArgb(55, 166, 219);
            in24button.Cursor = Cursors.Hand;
            in24button.FlatStyle = FlatStyle.Flat;
            in24button.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            in24button.ForeColor = SystemColors.Control;
            in24button.Location = new Point(60, 146);
            in24button.Name = "in24button";
            in24button.Size = new Size(160, 60);
            in24button.TabIndex = 0;
            in24button.Text = "Show";
            in24button.UseVisualStyleBackColor = false;
            in24button.Click += in24HoursButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBoardPage);
            tabControl1.Controls.Add(tabPageSearchBook);
            tabControl1.Controls.Add(tabInfoPage);
            tabControl1.Controls.Add(tabPageBookings);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(190, 60);
            tabControl1.Location = new Point(255, 143);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(902, 361);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBookings
            // 
            tabPageBookings.Controls.Add(cancelBookingButton);
            tabPageBookings.Controls.Add(textBoxBookingId);
            tabPageBookings.Controls.Add(activeFlightsButton);
            tabPageBookings.Controls.Add(myFlightsButton);
            tabPageBookings.Location = new Point(4, 64);
            tabPageBookings.Name = "tabPageBookings";
            tabPageBookings.Size = new Size(894, 293);
            tabPageBookings.TabIndex = 3;
            tabPageBookings.Text = "    Bookings    ";
            tabPageBookings.UseVisualStyleBackColor = true;
            // 
            // cancelBookingButton
            // 
            cancelBookingButton.BackColor = Color.FromArgb(55, 166, 219);
            cancelBookingButton.Cursor = Cursors.Hand;
            cancelBookingButton.FlatStyle = FlatStyle.Flat;
            cancelBookingButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelBookingButton.ForeColor = SystemColors.Control;
            cancelBookingButton.Location = new Point(335, 46);
            cancelBookingButton.Name = "cancelBookingButton";
            cancelBookingButton.Size = new Size(192, 71);
            cancelBookingButton.TabIndex = 5;
            cancelBookingButton.Text = "Cancel booking";
            cancelBookingButton.UseVisualStyleBackColor = false;
            cancelBookingButton.Click += cancelBookingButton_Click;
            // 
            // textBoxBookingId
            // 
            textBoxBookingId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxBookingId.Location = new Point(103, 53);
            textBoxBookingId.Name = "textBoxBookingId";
            textBoxBookingId.PlaceholderText = "Enter booking id ";
            textBoxBookingId.Size = new Size(193, 38);
            textBoxBookingId.TabIndex = 4;
            // 
            // activeFlightsButton
            // 
            activeFlightsButton.BackColor = Color.FromArgb(55, 166, 219);
            activeFlightsButton.Cursor = Cursors.Hand;
            activeFlightsButton.FlatStyle = FlatStyle.Flat;
            activeFlightsButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            activeFlightsButton.ForeColor = SystemColors.Control;
            activeFlightsButton.Location = new Point(482, 192);
            activeFlightsButton.Name = "activeFlightsButton";
            activeFlightsButton.Size = new Size(332, 72);
            activeFlightsButton.TabIndex = 3;
            activeFlightsButton.Text = "Show active flights";
            activeFlightsButton.UseVisualStyleBackColor = false;
            activeFlightsButton.Click += activeFlightsButton_Click;
            // 
            // myFlightsButton
            // 
            myFlightsButton.BackColor = Color.FromArgb(55, 166, 219);
            myFlightsButton.Cursor = Cursors.Hand;
            myFlightsButton.FlatStyle = FlatStyle.Flat;
            myFlightsButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myFlightsButton.ForeColor = SystemColors.Control;
            myFlightsButton.Location = new Point(83, 192);
            myFlightsButton.Name = "myFlightsButton";
            myFlightsButton.Size = new Size(332, 72);
            myFlightsButton.TabIndex = 2;
            myFlightsButton.Text = "Show my flights";
            myFlightsButton.UseVisualStyleBackColor = false;
            myFlightsButton.Click += myFlightsButton_Click_1;
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
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.BackColor = Color.Transparent;
            accountLabel.Font = new Font("Segoe UI Black", 15.8F, FontStyle.Bold);
            accountLabel.ForeColor = Color.Snow;
            accountLabel.Location = new Point(1103, 23);
            accountLabel.Name = "accountLabel";
            accountLabel.Padding = new Padding(8);
            accountLabel.Size = new Size(264, 53);
            accountLabel.TabIndex = 13;
            accountLabel.Text = "Personal Account";
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
            pictureBox1.Location = new Point(1030, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.BackColor = Color.Transparent;
            labelProjectName.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProjectName.ForeColor = SystemColors.ControlLightLight;
            labelProjectName.Location = new Point(135, 28);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(242, 51);
            labelProjectName.TabIndex = 15;
            labelProjectName.Text = "Sky Wings";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.BackColor = Color.Transparent;
            pictureBoxIcon.Image = (Image)resources.GetObject("pictureBoxIcon.Image");
            pictureBoxIcon.Location = new Point(28, 23);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(101, 97);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 16;
            pictureBoxIcon.TabStop = false;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.LightGray;
            logOutBtn.Cursor = Cursors.Hand;
            logOutBtn.Location = new Point(1115, 85);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(101, 35);
            logOutBtn.TabIndex = 17;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1377, 770);
            Controls.Add(logOutBtn);
            Controls.Add(pictureBoxIcon);
            Controls.Add(labelProjectName);
            Controls.Add(accountLabel);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            tabPageSearchBook.ResumeLayout(false);
            tabPageSearchBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)freeSeats).EndInit();
            tabInfoPage.ResumeLayout(false);
            tabInfoPage.PerformLayout();
            tabBoardPage.ResumeLayout(false);
            tabBoardPage.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageBookings.ResumeLayout(false);
            tabPageBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabPage tabPageSearchBook;
        private Button searchButton2;
        private Label labelFreeSeats;
        private Label labelDate;
        private Label labelDestpoint;
        private TabPage tabInfoPage;
        private TabPage tabBoardPage;
        private Button in24button;
        private TabControl tabControl1;
        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private Label accountLabel;
        private Label labelProjectName;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private PictureBox pictureBoxIcon;
        private DateTimePicker dtimeSearch;
        private NumericUpDown freeSeats;
        private ComboBox destPoint;
        private BindingSource bindingSource1;
        private ToolTip toolTipMain;
        private ComboBox originPoint;
        private Label labelOriginPoint;
        private Button logOutBtn;
        private Button createBookingButton;
        private Button searchButton1;
        private TextBox flightIdBox;
        private CheckBox checkDate;
        private TabPage tabPageBookings;
        private Button myFlightsButton;
        private Button cancelBookingButton;
        private TextBox textBoxBookingId;
        private Button activeFlightsButton;
        private Label labelShowFlights;
    }
}