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
            Item item = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1};
            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item);

            Assert.AreEqual(cart.GetAllItems().Count, 1);
        }

        [TestMethod]
        public void Test_CheckThat_CheckItemExistsThenAddToCart_Works()
        {
            Item item = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };
            IShoppingCart cart = new ShoppingCart();

            cart.CheckItemExistsThenAddToCart(item);

            Assert.AreEqual(cart.GetAllItems().Count, 1);
        }

        [TestMethod]
        public void Test_AddTwoItemsToCartReturnsTwo()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };
            Item item2 = new Item { ProductId = 2, Name = "Predator2", Price = "20000.00", Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            Assert.AreEqual(cart.GetAllItems().Count, 2);
        }

        [TestMethod]
        public void Test_AddingSameItemIncrementsQuatityByOne()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };
            Item item2 = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            cart.CheckItemExistsThenAddToCart(item1);
            Assert.AreEqual(item1.Quantity, 2);
            

        }

        [TestMethod]
        public void Test_AddingSameItemTwiceShowsTwo()
        {
            Item item1 = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };
            Item item2 = new Item { ProductId = 1, Name = "Predator", Price = "10000.00", Quantity = 1 };

            IShoppingCart cart = new ShoppingCart();

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            cart.CheckItemExistsThenAddToCart(item1);
            Assert.AreEqual(cart.GetAllItems().Count, 2);


        }
    }
}
