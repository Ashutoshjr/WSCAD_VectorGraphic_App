using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Vector.Helpers;
using Test_Vector.Models;

namespace Test_Vector.Strategies
{
    public class TriangleDrawingStrategy : IShapeDrawingStrategy
    {
        public void DrawShape(DrawShape shape, Graphics graphics, Color color, WindowsFormDetail windowsFormDetail)
        {

            Point pointA = Utility.ParseCoordinates(shape.A);
            Point pointB = Utility.ParseCoordinates(shape.B);
            Point pointC = Utility.ParseCoordinates(shape.C);


            Point[] trianglePoints = GetScaledTrianglePoints(pointA, pointB, pointC, windowsFormDetail);

            if (shape.Filled)
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    graphics.FillPolygon(brush, trianglePoints);
                }
            }

            using (Pen pen = new Pen(color, 1))
            {
                graphics.DrawPolygon(pen, trianglePoints);
            }

        }

       
        private Point[] GetScaledTrianglePoints(Point pointA, Point pointB, Point pointC, WindowsFormDetail windowsFormDetail)
        {
            Point pictureCenter = new Point(windowsFormDetail.PictureBoxWidth / 2, windowsFormDetail.PictureBoxHeight / 2);
            float scaleX = (float)windowsFormDetail.FloatingWidth / windowsFormDetail.OriginalWidth;
            float scaleY = (float)windowsFormDetail.FloatingHeight / windowsFormDetail.OriginalHeight;

            Point scaledPointA = new Point((int)(pictureCenter.X + pointA.X * scaleX), (int)(pictureCenter.Y + pointA.Y * scaleY));
            Point scaledPointB = new Point((int)(pictureCenter.X + pointB.X * scaleX), (int)(pictureCenter.Y + pointB.Y * scaleY));
            Point scaledPointC = new Point((int)(pictureCenter.X + pointC.X * scaleX), (int)(pictureCenter.Y + pointC.Y * scaleY));

            return new Point[] { scaledPointA, scaledPointB, scaledPointC };
        }
    }
}
