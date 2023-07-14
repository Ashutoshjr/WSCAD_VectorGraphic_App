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
    public class CircleDrawingStrategy : IShapeDrawingStrategy
    {
        public void DrawShape(DrawShape shape, Graphics graphics, Color color)
        {
            try
            {
                Point center = Utility.ParseCoordinates(shape.Center);
                float radius = Convert.ToSingle(shape.Radius);

                int circleRadius = Convert.ToInt32(shape.Radius);
                Rectangle bounds = new Rectangle(circleRadius - center.X, circleRadius - center.Y, circleRadius * 6, circleRadius * 6);

                if (shape.Filled)
                {
                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        graphics.FillEllipse(brush, bounds);
                    }
                }

                using (Pen pen = new Pen(color,1))
                {
                    graphics.DrawEllipse(pen, bounds);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
