using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeMappingTest
{
    public abstract class GroupCodeDataSource : Attribute, ITestDataSource
    {
        private readonly IEnumerable<object[]> data;
        public GroupCodeDataSource(Dictionary<string, string> groupCodeTable)
        {
            data = groupCodeTable.Select(kvp => new object[] { kvp.Key, kvp.Value }).AsEnumerable();
        }

        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            return data;
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
            {
                return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", methodInfo.Name, string.Join(",", data));
            }

            return string.Empty;
        }
    }
}
