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
        public void DrawShape(DrawShape shape, Graphics graphics, Color color)
        {
            try
            {
                Point pointA = Utility.ParseCoordinates(shape.A);
                Point pointB = Utility.ParseCoordinates(shape.B);
                Point pointC = Utility.ParseCoordinates(shape.C);

                Point[] trianglePoints = new Point[] { pointA, pointB, pointC };

                if (shape.Filled)
                {
                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        graphics.FillPolygon(brush, trianglePoints);
                    }
                }

                using (Pen pen = new Pen(color,1))
                {
                    graphics.DrawPolygon(pen, trianglePoints);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
