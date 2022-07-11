using CodeMapping;
using CodeMapping.Tables;
using CodeMappingTest.DataSources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeMappingTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCountryMapping()
        {
            Dictionary<string, string> mapper = CountryCodes.CountryCodesTable.GetMap(CodeType.ExternalCode, CodeType.InternalKey);

            Assert.AreEqual("036", mapper["au"]);
        }

        [TestMethod]
        [CountryCodesData(CodeType.ExternalCode, CodeType.InternalKey)]
        public void TestCountryMapping_DataSource(string input, string output)
        {
            Dictionary<string, string> mapper = CountryCodes.CountryCodesTable.GetMap(CodeType.ExternalCode, CodeType.InternalKey);

            Assert.AreEqual(output, mapper[input]);
        }
    }
}
