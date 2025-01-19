using Airline.exception;
using Airline.model.dto.request;
using Airline.service;

namespace Airline
{
    public partial class Main_Form : Form
    {
        private readonly FlightService _flightService = new();

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
                searchButton2
            ], 30);

            toolTipMain.SetToolTip(in24button, "Click to get fligts in next 24 hours");
            toolTipMain.SetToolTip(myFlightsButton, "Click to get your active and inactive bookings");
            toolTipMain.SetToolTip(searchButton1, "Click to get flight");
            toolTipMain.SetToolTip(searchButton2, "Click to get flights");

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl1_DrawItem;
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
            var fi = new Flights_Info_Form(_flightService.ShowIn24Hours());
            fi.ShowDialog();
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
            var fi = new Flights_Info_Form(_flightService.SearchFlights(flightSearchRequest));
            fi.ShowDialog();
        }

        private void myFlightsButton_Click(object sender, EventArgs e)
        {
            String text = "my fligts";
            //Flights_Info_Form fi = new Flights_Info_Form(text);
            //fi.ShowDialog();
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(flightIdBox.Text);
                var fi = new Flights_Info_Form(_flightService.GetById(id));

                fi.ShowDialog();
                flightIdBox.Text = "";
            }
            catch (Exception exception) when (exception is FormatException or NotFoundException)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void toolTipMain_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}