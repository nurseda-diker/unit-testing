using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _kullanicilar;

        [TestInitialize]
        public void DataOlustur()
        {
            _kullanicilar = new List<string>();
            _kullanicilar.Add("Monica"); //Monica => salih
            _kullanicilar.Add("Ross"); //Ross => engin 
            _kullanicilar.Add("Rachel"); //Rachel => ahmet
        }

        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Monica");
            yeniKullanicilar.Add("Ross");
            yeniKullanicilar.Add("Rachel");

            CollectionAssert.AreEqual(_kullanicilar,yeniKullanicilar);
        }

        [TestMethod]
        public void Elemanlar_ayni_fakat_sirasi_farkli_olabilir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Ross");
            yeniKullanicilar.Add("Monica");
            yeniKullanicilar.Add("Rachel");

            CollectionAssert.AreEquivalent(_kullanicilar, yeniKullanicilar);
        }


        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmamalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Ross");
            yeniKullanicilar.Add("Monica");
            yeniKullanicilar.Add("Rachel");

            CollectionAssert.AreNotEqual(_kullanicilar, yeniKullanicilar);
        }

        [TestMethod]
        public void Elemanlar_farkli_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Monica");
            yeniKullanicilar.Add("Ross");
            yeniKullanicilar.Add("Rachel");
            yeniKullanicilar.Add("Joey");

            CollectionAssert.AreNotEquivalent(_kullanicilar, yeniKullanicilar);
        }

        [TestMethod]
        public void Kullanicilar_null_deger_almamalidir()
        {
            CollectionAssert.AllItemsAreNotNull(_kullanicilar);
        }

        [TestMethod]
        public void Kullanicilar_benzersiz_olmalidir()
        {
            CollectionAssert.AllItemsAreUnique(_kullanicilar);
        }

        [TestMethod]
        public void Tüm_elemanlar_ayni_tipte_olmalidir()
        {
            ArrayList liste = new ArrayList
            {
                "Monica","Ross","Rachel"
            };

            CollectionAssert.AllItemsAreInstancesOfType(liste, typeof(string));
        }

        [TestMethod]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanicilar = new List<string>() { "Monica", "Ross" };
            List<string> eskiKullanicilar = new List<string>() { "Monica", "Chandler" };

            CollectionAssert.IsSubsetOf(yeniKullanicilar, _kullanicilar);
            CollectionAssert.IsNotSubsetOf(eskiKullanicilar, _kullanicilar);

        }

        [TestMethod]
        public void Contains_test()
        {
            CollectionAssert.Contains(_kullanicilar, "Monica");
            CollectionAssert.DoesNotContain(_kullanicilar, "Janice");
        }









    }
}
