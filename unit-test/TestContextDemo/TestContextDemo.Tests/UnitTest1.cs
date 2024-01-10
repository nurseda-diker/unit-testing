using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n");
            TestContext.WriteLine("Test Adı: {0}",TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}",TestContext.CurrentTestOutcome);
            TestContext.Properties["bilgi"] = "Bu bir ekstra bilgidir";
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["bilgi"]);
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod--\n");
            TestContext.WriteLine("Test Adı: {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu: {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test Sınıfı: {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test Bilgi: {0}", TestContext.Properties["bilgi"]);

            Assert.AreEqual(1, 1);
        }
    }
}
