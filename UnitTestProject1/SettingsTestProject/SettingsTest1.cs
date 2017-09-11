using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SettingsTestProject
{
    [TestClass]
    public class SettingsTest1
    {
        private TestContext m_testContext;

        public TestContext TestContext
        {
            get { return m_testContext; }

            set { m_testContext = value; }
        }

        [TestMethod]
        public void TestOverrideParam1Value()
        {
            string param1 = (string)TestContext.Properties["param1"];
            Assert.AreEqual("OverrideParam1Value", param1, "Value for param1 doesnt match the expected overriden value : OverrideParam1Value");
        }

        [TestMethod]
        public void TestOverrideParam2ValueWithSemiColon()
        {
            string param2 = (string)TestContext.Properties["param2"];
            Assert.AreEqual("Override;Param2Value", param2, "Value for param1 doesnt match the expected overriden value : Override;Param2Value");
        }

        [TestMethod]
        public void TestNoOverrideParam3Value()
        {
            string param3 = (string)TestContext.Properties["param3"];
            Assert.AreEqual("Param3Value", param3, "Value for param3 doesnt match the expected original value : Param3Value");
        }
    }
}
