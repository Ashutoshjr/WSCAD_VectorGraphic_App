using System;
using System.Drawing;
using Test_Vector.Helpers;
using Test_Vector.Models;

namespace Test_Vector.Strategies
{
    public class CircleDrawing : IShapeDrawing
    {
        public void DrawShape(DrawShape shape, Graphics graphics, Color color, WindowsFormDetail windowsFormDetail)
        {
            try
            {
                Point center = Utility.ParseCoordinates(shape.Center);
                float radius = Convert.ToSingle(shape.Radius);

                int circleRadius;
                Point circleCenter;
                Utility.GetCirclePoints(shape, center, windowsFormDetail, out circleRadius, out circleCenter);


                Rectangle bounds = new Rectangle(circleCenter.X - circleRadius, circleCenter.Y - circleRadius, circleRadius * 6, circleRadius * 6);

                if (shape.Filled)
                {
                    using (SolidBrush brush = new SolidBrush(color))
                    {
                        graphics.FillEllipse(brush, bounds);
                    }
                }

                using (Pen pen = new Pen(color, 1))
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
