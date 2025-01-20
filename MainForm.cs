using Airline.exception;
using Airline.model.dto.request;
using Airline.service;
using static Airline.FormsHelper;

namespace Airline
{
    public partial class MainForm : Form
    {
        private readonly FlightService _flightService = new();
        private readonly BookingService _bookingService = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomTabControl();
        }

        private void InitializeCustomTabControl()
        {
            RoundItems(
            [
                in24button,
                myFlightsButton,
                searchButton1,
                searchButton2,
                createBookingButton,
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

            if (CURRENT_PASSENGER != null) accountLabel.Text = CURRENT_PASSENGER.Username;
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

        private void in24HoursButton_Click(object sender, EventArgs e)
        {
            ShowInfoForm(_flightService.ShowIn24Hours());
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            var flightSearchRequest = new FlightSearchRequest
            (
                originPoint.Text,
                destPoint.Text,
                DateOnly.FromDateTime(dtimeSearch.Value),
                (int)freeSeats.Value
            );
            ShowInfoForm(_flightService.SearchFlights(flightSearchRequest, checkDate.Checked));
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(flightIdBox.Text);
                ShowInfoForm(_flightService.GetById(id));
            }
            catch (Exception exception) when (exception is FormatException or NotFoundException)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            CURRENT_PASSENGER = null;
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }

        private void createBooking_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(flightIdBox.Text);
                var booking = _bookingService.CreateBooking(id);
                
                MessageBox.Show(@"Booking successful");
                ShowInfoForm([booking]);

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
            ShowInfoForm(_bookingService.ShowMyBookings());
        }

        private void cancelBookingButton_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(textBoxBookingId.Text);
                _bookingService.CancelBooking(id);
                
                textBoxBookingId.Text = string.Empty;
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
            ShowInfoForm(_bookingService.ShowActiveBookings());
        }
    }
}