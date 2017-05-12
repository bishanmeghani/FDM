using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDbookshop;

namespace TDDbookshoptests
{
    [TestClass]
    public class CheckoutTest
    {
        Basket mybasket;
        book mybook;
        Checkout mycheckout;

        [TestInitialize] //Runs before every test
        public void setup()
        {
            mybasket = new Basket();
            mybook = new book();
            mycheckout = new Checkout();
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsZeroWhenPassedAnEmptyBasket()
        {
            
            //Arrange

            
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(0.0, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsPriceOfBookInBasket_WhenPassedBasketWithOneBook()
        {
            //Arrange

            mybasket.addBook(mybook);
            mybook.price = 10.0;
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(10, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsSumOfPricesOfTwoBooksInBasket_WhenPassedBasketWithTwoBook()
        {
            //Arrange
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybook.price = 10.0;
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(20, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsDiscountedCostOfThreeBooksInBasket_WhenPassedBasketWithThreeBook()
        {
            //Arrange
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);

            mybook.price = 10;
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(29.70, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsDiscountedCostOfSevenBooksInBasket_WhenPassedBasketWithSevenBook()
        {
            //Arrange
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);

            mybook.price = 10;
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(68.6, cost);
        }

        [TestMethod]
        public void test_CalculatePrice_ReturnsDiscountedCostOfTenBooksInBasket_WhenPassedBasketWithTenBook()
        {
            //Arrange
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);

            mybook.price = 10;
            //Act
            double cost = mycheckout.calculatePrice(mybasket);

            //Assert
            Assert.AreEqual(87.00, cost);
        }
    }
}
