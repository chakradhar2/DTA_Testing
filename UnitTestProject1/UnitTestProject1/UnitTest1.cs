using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, Priority(0), Owner("test")]
        public void TestMethod1()
        {
            Assert.IsTrue(true, "It shouldn't fail");
        }

        [TestMethod, Priority(0), Owner("test")]
        public void TestMethod2()
        {
            Assert.IsTrue(false, "It should fail");
        }

        [TestMethod, Priority(0), Owner("test")]
        [Ignore]
        public void TestMethod3()
        {
            Assert.IsTrue(false, "This shouldn't be executed");
        }

        [TestMethod, Priority(3), Owner("test")]
        public void TestMethod4()
        {
            Assert.IsTrue(true, "Testing with Priority");
        }

        [TestMethod, Priority(2), Owner("test"), TestCategory("TestCat")]
        public void TestMethod5()
        {
            Assert.IsTrue(true, "Testing with some category");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(true, "Another simple test which throws exception");
            throw new Exception("Some random exception");
        }
    }
}
