using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Description("Bu bir karekök testi yapan metottur")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod,Ignore]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod,Timeout(1000)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod,Timeout(TestTimeout.Infinite)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }

    }
}
