using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Flights_Info_Form : Form
    {
        public Flights_Info_Form(String flights)
        {
            InitializeComponent();
            first_Tab_Control1.PrintFlight(flights);
            first_Tab_Control1.Visible = true;

        }

        private void Flights_Info_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
