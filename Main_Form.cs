using Airline.exception;
using Airline.model.dto.request;
using Airline.service;

namespace Airline
{
    public partial class Main_Form : Form
    {
        private readonly FlightService _flightService = new();
        private readonly BookingService _bookingService = new();

        public Main_Form()
        {
            InitializeComponent();
            InitializeCustomTabControl();
        }

        private void InitializeCustomTabControl()
        {
            FormsHelper.RoundItems(
            [
                in24button,
                myFlightsButton,
                searchButton1,
                searchButton2,
                createBooking,
                cancelBookingButton,
                activeFlightsButton
            ], 30);

            toolTipMain.SetToolTip(in24button, "Click to get fligts in next 24 hours");
            toolTipMain.SetToolTip(myFlightsButton, "Click to get your active and inactive bookings");
            toolTipMain.SetToolTip(searchButton1, "Click to get flight");
            toolTipMain.SetToolTip(searchButton2, "Click to get flights");
            toolTipMain.SetToolTip(checkDate, "Click to ignore date");

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl1_DrawItem;

            if (FormsHelper.CURRENT_PASSENGER != null) accountLabel.Text = FormsHelper.CURRENT_PASSENGER.Username;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            bool isSelected = e.State == DrawItemState.Selected;

            Color backColor = isSelected ? Color.White : Color.FromArgb(204, 30, 58, 138);
            Color textColor = isSelected ? Color.FromArgb(204, 30, 58, 138) : Color.White;


            using (Brush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, tabRect);
            }

            string tabText = tabControl.TabPages[e.Index].Text;
            TextRenderer.DrawText(e.Graphics, tabText, tabControl.Font, tabRect, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            e.Graphics.DrawRectangle(Pens.White, tabRect);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Show_cursor(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;

            switch (sender)
            {
                case Panel panel:
                    panel.BackColor = Color.CadetBlue;
                    break;
                case Label label:
                    label.Parent.BackColor = Color.CadetBlue;
                    break;
            }
        }

        private void Leave_cursor(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (sender is Panel panel)
            {
                panel.BackColor = Color.WhiteSmoke;
            }
        }

        private void fisrt_Tab_Control1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void in24HoursButton_Click(object sender, EventArgs e)
        {
            FormsHelper.ShowInfoForm(_flightService.ShowIn24Hours());
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            var flightSearchRequest = new FlightSearchRequest
            (
                originPoint.Text,
                destPoint.Text,
                DateOnly.FromDateTime(dtimeSearch.Value),
                (int)numberOfPeople.Value
            );
            FormsHelper.ShowInfoForm(_flightService.SearchFlights(flightSearchRequest, checkDate.Checked));
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(flightIdBox.Text);
                FormsHelper.ShowInfoForm(_flightService.GetById(id));
            }
            catch (Exception exception) when (exception is FormatException or NotFoundException)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void toolTipMain_Popup(object sender, PopupEventArgs e)
        {
        }

        private void accountLabel_Click(object sender, EventArgs e)
        {
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            FormsHelper.CURRENT_PASSENGER = null;
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            Hide();
            var loginForm = new Login_Form();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }

        private void createBooking_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(flightIdBox.Text);
                FormsHelper.ShowInfoForm([_bookingService.createBooking(id)]);
                
                MessageBox.Show(@"Booking successful");
                flightIdBox.Text = string.Empty;
            }
            catch (Exception exception) when (exception is FormatException or BadRequestException or NotFoundException)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            toolTipMain.SetToolTip(checkDate, checkDate.Checked ? "Click to ignore date" : "Click to filter with date");
        }

        private void myFlightsButton_Click_1(object sender, EventArgs e)
        {
            _bookingService.UpdateBookingsStatus();
            FormsHelper.ShowInfoForm(_bookingService.ShowMyBookings());
        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(textBoxBookingId.Text);
                _bookingService.CancelBooking(id);
            }
            catch (Exception exception) when (exception is FormatException or BadRequestException or NotFoundException)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            MessageBox.Show(@"Booking cancelled");
        }

        private void activeFlightsButton_Click(object sender, EventArgs e)
        {
            FormsHelper.ShowInfoForm(_bookingService.ShowActiveBookings());
        }
    }
}