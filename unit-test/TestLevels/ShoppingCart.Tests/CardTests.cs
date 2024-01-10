using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CardTests
    {
        private CartItem _cartItem;
        private CartManager _cartManager;


        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 10000

                },
                Quantity = 1
            };

            //act 
            _cartManager.Add(_cartItem);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            _cartManager.Clear();
        }



        [TestMethod]
        public void Sepete_urun_eklenebilmeli()
        {
            //arrange

            const int beklenen = 1;

            //act
            var toplamElemanSayisi = _cartManager.TotalItems;

            Assert.AreEqual(beklenen, toplamElemanSayisi);


        }

        [TestMethod]
        public void Sepette_olan_urun_cikarilabilmeli()
        {

            
            var sepetteOlanElemanSayisi=_cartManager.TotalItems;

            //act 
            _cartManager.Remove(1);
            var sepetteKalanElemanSayisi = _cartManager.TotalItems;

            //assert

            Assert.AreEqual(sepetteOlanElemanSayisi - 1, sepetteKalanElemanSayisi);
        }

        [TestMethod]
        public void Sepet_temizlenebilmeli()
        {
           

            //act
           _cartManager.Clear();

            //assert
            Assert.AreEqual(0, _cartManager.TotalItems);
            Assert.AreEqual(0, _cartManager.TotalQuantity);

        }



    }
}
