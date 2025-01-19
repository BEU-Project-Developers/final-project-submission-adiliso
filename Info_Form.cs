namespace Airline
{
    public partial class Info_Form : Form
    {
        public Info_Form()
        {
            InitializeComponent();
        }

        public void ShowInfo<T>(List<T> items)
        {
            dataView.DataSource = items;
        }

        private void Flights_Info_Form_Load(object sender, EventArgs e)
        {
        }

        private void first_Tab_Control1_Load(object sender, EventArgs e)
        {
        }
    }
}