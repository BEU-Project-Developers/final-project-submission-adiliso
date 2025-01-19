using Airline.model.dto;

namespace Airline
{
    public partial class Flights_Info_Form : Form
    {
        public Flights_Info_Form(List<FlightDto> flights)
        {
            InitializeComponent();
            flight_View.DataSource = flights;

        }

        private void Flights_Info_Form_Load(object sender, EventArgs e)
        {

        }

        private void first_Tab_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
