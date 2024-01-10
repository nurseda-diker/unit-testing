using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double girilenDeger = 16;
            const double beklenen = 4;
            double gerceklesen = Math.Sqrt(girilenDeger);

            Assert.AreEqual(beklenen, gerceklesen, "{0} sayısının karekökü {1} olmalıdır", girilenDeger, beklenen);


        }

        [TestMethod]
        public void TestMethod2()
        {
            double beklenen = 3.1622;
            //formül => |beklenen-gerceklesen| <=delta

            double delta = 0.0001;
            double gercek = Math.Sqrt(10);
            Assert.AreEqual(beklenen, gercek, delta);

        }

        [TestMethod]
        public void TestMethod3()
        {
            string beklenen = "MERHABA";
            string gerceklesen = "merhaba";

            Assert.AreEqual(beklenen, gerceklesen, true); //true=>ignoreCase
        }

        [TestMethod]
        public void TestMethod4()
        {
            const double beklenmeyen = 0;
            var gerceklesen = Math.Pow(5, 0);
            Assert.AreNotEqual(beklenmeyen, gerceklesen);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var sayilar = new byte[] { 1, 2, 3 };
            var digerSayilar = sayilar;
            sayilar[0] = 4;

            Assert.AreSame(sayilar, digerSayilar);
            
        }

        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;
            int b = a;

            Assert.AreEqual(a, b, "AreEqual başarısız oldu");
            Assert.AreNotSame(a,b, "AreSame başarısız oldu.");

        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli degildir.");

        }

        [TestMethod]
        public void TestMethod8()
        {
            var sayi = 5m;
            Assert.IsInstanceOfType(sayi, typeof(decimal));
            Assert.IsNotInstanceOfType(sayi, typeof(int));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<string> sayilar = new List<string> { "Monica", "Ross", "Rachel" };
            var aIleBaslayanIlkIsim = sayilar.FirstOrDefault(x => x.StartsWith("A"));
            var mIleBaslayanIlkIsim = sayilar.FirstOrDefault(x => x.StartsWith("M"));

            Assert.IsNull(aIleBaslayanIlkIsim, "IsNull başarısız oldu");
            Assert.IsNotNull(mIleBaslayanIlkIsim, "IsNotNull başarısız oldu");

        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var sayi = 5;
                int sonuc = sayi / 0;
            }
            catch (DivideByZeroException)
            {

                Assert.Fail("Test başarısız oldu");
            }
        }




        }
}
