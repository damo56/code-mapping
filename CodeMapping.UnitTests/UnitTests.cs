using CodeMapping;
using CodeMapping.Tables;
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
    }
}
