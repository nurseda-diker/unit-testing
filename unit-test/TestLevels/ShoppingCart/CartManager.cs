﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //Gereksinimler
    //Sepete ürün eklenebilmeli
    //Sepette olan ürün çıkarılabilmeli
    //Sepet temizlenebilmeli

    //

    public class CartManager
    {
       private readonly List<CartItem> _cartItems;

        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            _cartItems.Add(cartItem);
            
        }

        public void Remove(int productId)
        {
            var product=_cartItems.FirstOrDefault(x => x.Product.ProductId == productId);
            _cartItems.Remove(product);
        }

        public List<CartItem> CartItems
        {
            get { return _cartItems; }
        }

        public void Clear()
        {
            _cartItems.Clear();
        } 


        public decimal TotalPrice
        {
            get { return _cartItems.Sum(x => x.Quantity * x.Product.UnitPrice); }
        }

        public int TotalQuantity
        {
            get { return _cartItems.Sum(x => x.Quantity); }
        }

        public int TotalItems
        {
            get { return _cartItems.Count; }
        }



    }
}
