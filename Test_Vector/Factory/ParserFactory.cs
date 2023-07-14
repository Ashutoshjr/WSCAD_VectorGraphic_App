using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Vector.Models;
using Test_Vector.Parsers;

namespace Test_Vector.Factory
{
    public static class ParserFactory
    {

        private static readonly Dictionary<DataSourceType, Func<string, ParserBase>> parserCreators = new Dictionary<DataSourceType, Func<string, ParserBase>>()
        {
            { DataSourceType.json, (filepath) => new JsonParser(filepath) },
            { DataSourceType.xml, (filepath) => new XmlParser(filepath) },
            // Add creators for future parsers here
        };

        public static ParserBase CreateParser(DataSourceType type,string filepath)
        {
            if (parserCreators.TryGetValue(type, out var parserCreator))
            {
                return parserCreator(filepath);
            }

            throw new NotSupportedException("Parser type not supported.");
        }
    }
}
