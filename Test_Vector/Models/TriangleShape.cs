using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vector.Models
{
    public class TriangleShape : IShape
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string Filled { get; set; }

        public TriangleShape() {}
      

        public string SetShapeData(DrawShape drawShape)
        {
            A = drawShape.A;
            B = drawShape.B;
            C = drawShape.C;

            return $"{A} - {B} - {C}";

        }

        public string SetShapeFilledData(DrawShape drawShape)
        {
            return Filled = drawShape.Filled.ToString();
        }
    }
}
