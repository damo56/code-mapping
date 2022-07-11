using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMapping
{
    public abstract class CodeTable
    {
        protected abstract List<CodeMapping> Mappings { get; }

        public Dictionary<string, string> GetMap(CodeType inputCodeType, CodeType outputCodeType)
        {
            return Mappings.ToDictionary(map => map.GetValue(inputCodeType), map => map.GetValue(outputCodeType));
        }
    }
}
