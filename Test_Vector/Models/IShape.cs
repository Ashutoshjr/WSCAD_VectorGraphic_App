using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vector.Models
{
    public interface IShape 
    {
        string SetShapeData(DrawShape drawShape);

        string SetShapeFilledData(DrawShape drawShape);
    }

}
