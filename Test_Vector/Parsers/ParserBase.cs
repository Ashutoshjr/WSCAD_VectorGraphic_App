using System.Collections.Generic;
using Test_Vector.Models;

namespace Test_Vector.Parsers
{
    public abstract class ParserBase
    {
        public string FilePath { get; set; }

        public ParserBase(string filePath)
        {
            FilePath = filePath;
        }

        public abstract List<DrawShape> Parse();
    }

}
