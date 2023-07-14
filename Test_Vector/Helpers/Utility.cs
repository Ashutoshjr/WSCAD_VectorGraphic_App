using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vector.Helpers
{
    public class Utility
    {
        public static Point ParseCoordinates(string coordinates)
        {
            try
            {
                string[] parts = coordinates.Split(';');
                int x = Convert.ToInt32(parts[0]);
                int y = Convert.ToInt32(parts[1]);
                return new Point(x, y);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static Color ParseColor(string colorString)
        {
            try
            {
                string[] colorComponents = colorString.Split(';');
                int alpha = Convert.ToInt32(colorComponents[0]);
                int red = Convert.ToInt32(colorComponents[1]);
                int green = Convert.ToInt32(colorComponents[2]);
                int blue = Convert.ToInt32(colorComponents[3]);

                return Color.FromArgb(alpha, red, green, blue);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
