using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Models;
using Test_Vector.Parsers;
using Test_Vector.Strategies;

namespace Test_Vector.Factory
{
    public static class ShapeDrawingFactory
    {

        private static readonly Dictionary<ShapeType, Func<IShapeDrawing>> shapeDrawingObjCreators = new Dictionary<ShapeType, Func<IShapeDrawing>>()
        {
            { ShapeType.line, () => new LineDrawing() },
            { ShapeType.circle, () => new CircleDrawing() },
            { ShapeType.triangle, () => new TriangleDrawing() },

            // Add creators for future parsers here
        };


        public static IShapeDrawing CreateShapeObj(ShapeType type)
        {
            if (shapeDrawingObjCreators.TryGetValue(type, out var shapeDataCreator))
            {
                return shapeDataCreator();
            }

            throw new NotSupportedException("Parser type not supported.");
        }
    }
}
