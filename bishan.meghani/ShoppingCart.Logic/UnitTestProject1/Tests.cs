using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;

namespace CartTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test_AddOneItemToCartReturnsOne()
        {
            Item item = new Item { ProductId = 1, Name = "Predator", Price = 1000.0, Quantity = 1};
            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item);

            Assert.AreEqual(cart.GetAllItems().Count, 1);
        }

        [TestMethod]
        public void Test_CheckThat_CheckItemExistsThenAddToCart_Works()
        {
            Item item = new Item { ProductId = 1, Name = "Predator", Price = 1000.0, Quantity = 1 };
            IShoppingCart cart = new ShoppingCart();

            

            Assert.AreEqual(cart.GetAllItems().Count, 1);
        }

        [TestMethod]
        public void Test_AddTwoItemsToCartReturnsTwo()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = 100.0, Quantity = 1 };
            Item item2 = new Item { ProductId = 2, Name = "Predator2", Price = 200.00, Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            Assert.AreEqual(cart.GetAllItems().Count, 2);
        }

        [TestMethod]
        public void Test_AddingSameItemIncrementsQuatityByOne()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = 1000.00, Quantity = 1 };
            Item item2 = new Item { ProductId = 1, Name = "Predator", Price = 1000.00, Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            
            Assert.AreEqual(item1.Quantity, 2);
            

        }

        [TestMethod]
        public void Test_AddingSameItemTwiceShowsTwo()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = 1000.00, Quantity = 1 };
            Item item2 = new Item { ProductId = 1, Name = "Predator", Price = 1000.00, Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

           
            Assert.AreEqual(cart.GetAllItems().Count, 2);


        }
    }
}
