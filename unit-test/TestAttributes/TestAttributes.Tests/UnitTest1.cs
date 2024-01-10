using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [Owner("nur")]
        [TestCategory("developer")]
        [Priority(1)]
        [TestProperty("Güncelleyen","sude")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("nur")]
        [TestCategory("developer")]
        [Priority(1)]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("nur")]
        [TestCategory("developer")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("sude")]
        [TestCategory("tester")]
        [TestCategory("demo")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("sude")]
        [TestCategory("tester")]
        [Priority(2)]
        [TestProperty("Güncelleyen", "nur")]
        [TestProperty("Güncelleyen2", "nur")]
        public void TestMethod()
        {
            Assert.AreEqual(1, 1);
        }





    }
}
