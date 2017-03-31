using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, Priority(0), Owner("test")]
        public void PassingTest()
        {
            Assert.IsTrue(true, "It shouldn't fail");
        }

        [TestMethod, Priority(2), Owner("test")]
        public void TestRunParameterTest()
        {
            Assert.AreEqual("DataSource=tcp:ServerName.database.windows.net,1433;InitialCatalog=DatabaseName", this.TestContext.Properties["connectionString"], "Test run parameter not overridden. Should fail unless overridden");
        }

        [TestMethod, Priority(0), Owner("test")]
        [Ignore]
        public void IgnoredTest()
        {
            Assert.IsTrue(false, "This shouldn't be executed");
        }

        [TestMethod, Priority(3), Owner("test")]
        public void P3Test()
        {
            Assert.IsTrue(true, "Testing with Priority");
        }

        [TestMethod, Priority(2), Owner("test"), TestCategory("TestCat")]
        public void TestCategoryTest()
        {
            Assert.IsTrue(true, "Testing with some category");
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.IsTrue(true, "Another simple test which throws exception");
            throw new Exception("Some random exception");
        }

        public TestContext TestContext { get; set; }
    }
}
