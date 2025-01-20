using System.Drawing.Drawing2D;
using Airline.model.dto;

namespace Airline
{
    public static class FormsHelper
    {
        public static PassengerDto CURRENT_PASSENGER = null;

        public static void RoundItems(List<Control> items, int radius)
        {
            foreach (var item in items)
            {
                item.Region = new Region(CreateRoundedRectanglePath(item.ClientRectangle, radius));
            }
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void ShowInfoForm<T>(List<T> items)
        {
            var fi = new InfoForm();
            fi.ShowInfo(items);
            fi.ShowDialog();
        }
    }
}