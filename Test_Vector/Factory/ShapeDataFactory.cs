using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Models;
using Test_Vector.Parsers;

namespace Test_Vector.Factory
{
    public static class ShapeDataFactory
    {

        private static readonly Dictionary<ShapeType, Func<IShape>> shapeDataCreators = new Dictionary<ShapeType, Func<IShape>>()
        {
            { ShapeType.line, () => new LineShape() },
            { ShapeType.circle, () => new CircleShape() },
            { ShapeType.triangle, () => new TriangleShape() },
           
            // Add creators for future parsers here
        };

        public static IShape CreateShape(ShapeType type)
        {
            if (shapeDataCreators.TryGetValue(type, out var shapeDataCreator))
            {
                return shapeDataCreator();
            }

            throw new NotSupportedException("Parser type not supported.");
        }

    }
}
