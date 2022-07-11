using CodeMapping;
using CodeMapping.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMappingTest.DataSources
{
    public class CountryCodesData : GroupCodeDataSource
    {
        public CountryCodesData(CodeType inputType, CodeType outputType) : base(CountryCodes.CountryCodesTable.GetMap(inputType, outputType))
        {
            
        }
    }
}
