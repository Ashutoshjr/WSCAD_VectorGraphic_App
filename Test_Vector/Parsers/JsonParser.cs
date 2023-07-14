using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Test_Vector.Models;

namespace Test_Vector.Parsers
{
    public class JsonParser : ParserBase
    {
        public JsonParser(string filePath) : base(filePath)
        {
            
        }

        private static readonly JsonSerializerOptions _options =
          new JsonSerializerOptions()
          {
              PropertyNameCaseInsensitive = true,
              DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
          };

        public override List<DrawShape> Parse()
        {
            using (FileStream fileStream = File.OpenRead(FilePath))
            {
                var shape = JsonSerializer.Deserialize<List<DrawShape>>(fileStream, _options);
                return shape;
            }
        }
    }
}
