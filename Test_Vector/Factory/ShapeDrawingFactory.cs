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

        private static readonly Dictionary<ShapeType, Func<IShapeDrawingStrategy>> shapeDrawingObjCreators = new Dictionary<ShapeType, Func<IShapeDrawingStrategy>>()
        {
            { ShapeType.line, () => new LineDrawingStrategy() },
            { ShapeType.circle, () => new CircleDrawingStrategy() },
            { ShapeType.triangle, () => new TriangleDrawingStrategy() },

            // Add creators for future parsers here
        };


        public static IShapeDrawingStrategy CreateShapeObj(ShapeType type)
        {
            if (shapeDrawingObjCreators.TryGetValue(type, out var shapeDataCreator))
            {
                return shapeDataCreator();
            }

            throw new NotSupportedException("Parser type not supported.");
        }
    }
}
