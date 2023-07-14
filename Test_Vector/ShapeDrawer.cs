using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Helpers;
using Test_Vector.Models;
using Test_Vector.Strategies;

namespace Test_Vector
{
    public static class ShapeDrawer
    {
        private static Dictionary<string, Color> shapeColors = new Dictionary<string, Color>();
        private static Dictionary<ShapeType, IShapeDrawingStrategy> drawingStrategies;

        static ShapeDrawer()
        {
            drawingStrategies = new Dictionary<ShapeType, IShapeDrawingStrategy>()
            {
                { ShapeType.line, new LineDrawingStrategy() },
                { ShapeType.circle, new CircleDrawingStrategy() },
                { ShapeType.triangle, new TriangleDrawingStrategy() }
                // Add more strategies for other shape types as needed
           };
        }

        public static void DrawShapes(IEnumerable<DrawShape> shapes, Graphics graphics)
        {
            foreach (var shape in shapes)
            {
                try
                {
                    if (!Enum.TryParse(shape.Type, out ShapeType shapeType))
                    {
                        throw new NotSupportedException($"Unknown shape type: {shape.Type}");
                    }

                    if (!shapeColors.TryGetValue(shape.Color, out Color shapeColor))
                    {
                        shapeColor = Utility.ParseColor(shape.Color);
                        shapeColors.Add(shape.Color, shapeColor);
                    }

                    if (drawingStrategies.TryGetValue(shapeType, out var drawingStrategy))
                    {
                        drawingStrategy.DrawShape(shape, graphics, shapeColor);
                    }
                    else
                    {
                        throw new NotSupportedException($"Drawing strategy not found for shape type: {shape.Type}");
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
