using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMapping
{
    public class CodeTable
    {
        public CodeTable(List<CodeMapping> _mappings)
        {
            mappings = _mappings;
        }
        private List<CodeMapping> mappings;

        public Dictionary<string, string> GetMap(CodeType inputCodeType, CodeType outputCodeType)
        {
            return mappings.ToDictionary(map => map.GetValue(inputCodeType), map => map.GetValue(outputCodeType));
        }
    }
}
