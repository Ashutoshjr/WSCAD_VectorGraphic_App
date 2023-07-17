using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vector.Models
{
    public class CircleShape : IShape
    {
        public string Center { get; set; }
        public double Radius { get; set; }
        public string Filled { get; set; }


        public CircleShape(){}

        public string SetShapeData(DrawShape drawShape)
        {

            Center = drawShape.Center;
            Radius = drawShape.Radius;

            return $" Center : {Center} - Radius : {Radius}";

        }

        public string SetShapeFilledData(DrawShape drawShape)
        {
            return Filled = drawShape.Filled.ToString();
        }
    }
}
