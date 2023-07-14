using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Helpers;
using Test_Vector.Models;

namespace Test_Vector.Strategies
{
    internal class LineDrawingStrategy : IShapeDrawingStrategy
    {
        public void DrawShape(DrawShape shape, Graphics graphics, Color color)
        {
            try
            {
                Point pointA = Utility.ParseCoordinates(shape.A);
                Point pointB = Utility.ParseCoordinates(shape.B);

                using (Pen pen = new Pen(color, 2))
                {
                    graphics.DrawLine(pen, pointA, pointB);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
