using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Models;

namespace Test_Vector.Parsers
{
    public class XmlParser : ParserBase
    {

        public XmlParser(string filePath) : base(filePath)
        {
            
        }

        public override List<DrawShape> Parse()
        {
          throw new NotImplementedException();
        }
    }
}
