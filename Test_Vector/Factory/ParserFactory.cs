using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Parsers;

namespace Test_Vector.Factory
{
    public static class ParserFactory
    {

        private static readonly Dictionary<string, Func<string, ParserBase>> parserCreators = new Dictionary<string, Func<string, ParserBase>>()
        {
            { "json", (filepath) => new JsonParser(filepath) },
            { "xml", (filepath) => new XmlParser(filepath) },
            // Add creators for future parsers here
        };

        public static ParserBase CreateParser(string type,string filepath)
        {
            if (parserCreators.TryGetValue(type.ToLower(), out var parserCreator))
            {
                return parserCreator(filepath);
            }

            throw new NotSupportedException("Parser type not supported.");
        }
    }
}
