using System.Drawing;
using Test_Vector.Helpers;
using Test_Vector.Models;

namespace Test_Vector.Strategies
{
    internal class LineDrawing : IShapeDrawing
    {
        public void DrawShape(DrawShape shape, Graphics graphics, Color color, WindowsFormDetail windowsFormDetail)
        {

            Point pointA = Utility.ParseCoordinates(shape.A);
            Point pointB = Utility.ParseCoordinates(shape.B);

            Point scaledPointA = GetScaledPoint(pointA, windowsFormDetail);
            Point scaledPointB = GetScaledPoint(pointB, windowsFormDetail);


            using (Pen pen = new Pen(color, 2))
            {
                graphics.DrawLine(pen, scaledPointA, scaledPointB);
            }

        }


        private Point GetScaledPoint(Point point, WindowsFormDetail windowsFormDetail)
        {
            Point pictureCenter = new Point(windowsFormDetail.PictureBoxWidth / 2, windowsFormDetail.PictureBoxHeight / 2);
            float scaleX = (float)windowsFormDetail.FloatingWidth / windowsFormDetail.OriginalWidth;
            float scaleY = (float)windowsFormDetail.FloatingHeight / windowsFormDetail.OriginalHeight;

            return new Point(pictureCenter.X + (int)(point.X * scaleX), pictureCenter.Y + (int)(point.Y * scaleY));
        }
    }
}
