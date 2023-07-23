using Test_Vector.Helpers;

namespace Test_Vector.Models
{
    public class LineShape : IShape
    {
        public string A { get; set; }

        public string B { get; set; }

        public LineShape() { }

        public string SetShapeData(DrawShape drawShape)
        {
            A = drawShape.A;
            B = drawShape.B;

            return $"{A} - {B}";
        }

        public string SetShapeFilledData(DrawShape drawShape)
        {
            return Utility.NotApplicable;
        }
    }
}
