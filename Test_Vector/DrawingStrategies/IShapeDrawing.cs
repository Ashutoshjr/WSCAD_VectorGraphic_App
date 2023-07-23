using System.Drawing;
using Test_Vector.Models;

namespace Test_Vector.Strategies
{
    public interface IShapeDrawing
    {
        void DrawShape(DrawShape shape, Graphics graphics, Color color, WindowsFormDetail windowsFormDetail);

    }
}
