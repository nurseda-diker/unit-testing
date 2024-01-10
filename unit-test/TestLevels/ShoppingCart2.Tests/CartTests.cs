using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart2.Tests
{
    public class CartTests
    {
        [TestClass]
        public class CardTests
        {
            private static CartItem _cartItem;
            private static CartManager _cartManager;


            [ClassInitialize]
            public static void ClassInitialize(TestContext testContext)
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

            [ClassCleanup]
            public static void ClassCleanup()
            {
                _cartManager.Clear();
            }

            [TestMethod]
            public void Sepette_farkli_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_ve_eleman_sayisi_bir_artmalidir()
            {
                //arrange
                int toplamAdet = _cartManager.TotalQuantity;
                int toplamElemanSayisi = _cartManager.TotalItems;

                //act 
                _cartManager.Add(new CartItem
                {
                    Product = new Product
                    {
                        ProductId = 2,
                        ProductName="Mouse",
                        UnitPrice=200
                    },
                    Quantity = 1
                });

                //assert
                Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
                Assert.AreEqual(toplamElemanSayisi + 1, _cartManager.TotalItems);
            }

            [TestMethod]
            public void Sepette_olan_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_bir_artmali_eleman_sayisi_aynikalmali()
            {
                //arrange
                int toplamAdet = _cartManager.TotalQuantity;
                int toplamElemanSayisi = _cartManager.TotalItems;

                //act
                _cartManager.Add(_cartItem);

                //assert
                Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
                Assert.AreEqual(toplamElemanSayisi, _cartManager.TotalItems);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
           // [ExpectedException(typeof(Exception),AllowDerivedTypes =true)]
            public void Sepette_ayni_urunden_ikinci_kez_eklendiginde_hata_vermeli()
            {
                _cartManager.Add(_cartItem);
            }


        }
         

        }
    }
