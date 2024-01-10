using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", 
            "Users.xml",
            "User",DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager = new UserManager();
            var name = TestContext.DataRow["name"].ToString();
            var phone = TestContext.DataRow["phone"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();
            
            var sonuc = manager.AddUser(name,phone,mail);
            Assert.IsTrue(sonuc);
        }


        [DataSource("System.Data.SqlClient", "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Demo;Integrated Security=True", "Numbers", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest2()
        {
            var manager = new OperationManager();
            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int beklenen = Convert.ToInt32(TestContext.DataRow["beklenen"]);

            var gerceklesen = manager.Add(x, y);
            Assert.AreEqual(beklenen, gerceklesen);
        }

    }
}
