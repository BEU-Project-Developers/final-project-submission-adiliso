namespace Airline
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public void ShowInfo<T>(List<T> items)
        {
            dataView.DataSource = items;
        }
    }
}