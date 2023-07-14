using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vector.Models
{
    public class LineShape : IShape
    {
        public string A { get; set; }

        public string B { get; set; }


        public LineShape(){ }


        public string SetShapeData(DrawShape drawShape)
        {
          
            A = drawShape.A;
            B = drawShape.B;

            return $"{A} - {B}";

        }

        public string SetShapeFilledData(DrawShape drawShape)
        {
            return "NA";
        }
    }
}
