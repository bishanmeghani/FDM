using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDbookshop;


namespace TDDbookshoptests
{
    [TestClass]
    public class cateloguetest
    {
        Basket mybasket;
        book mybook;

        [TestInitialize] //Runs before every test
        public void setup()
        {
            mybasket = new Basket();
            mybook = new book();
        }

        // Test clean can be used, it's like initialise but after the test
        [TestCleanup]
        public void clean()
        {
            
        }

        // You never want any thing to be returned from test i.e. "void"
        [TestMethod]
        public void test_GetBooksInBasket_ReturnsEmptyBookList_IfNoBooksHaveBeenAdded()
        {
            // Arrange : set up of test
            
   

            // Act : run a method that we're testing
            List<book> books = mybasket.getBooksInBasket();    

            // Assert : see if result is what we expected
            Assert.AreEqual(0, books.Count);
    
        }

        [TestMethod]
        public void test_AddBook_ReturnsArrayOfLengthOne_AfterAddBookMethodIsCalledWithOneBook()
        {
            // Arrange : set up of test
           

            // Act : run a method that we're testing
            mybasket.addBook(mybook);
            ////List<book> books = mybasket.getBooksInBasket();

            // Assert : see if result is what we expected
            Assert.AreEqual(1, mybasket.books.Count);
            
        }

        [TestMethod]
        public void test_AddBook_ReturnsArrayOfLengthTwo_AfterAddBookMethodIsCalledWithTwoBook()
        {
            // Arrange : set up of test
            mybasket.addBook(mybook);
            mybasket.addBook(mybook);

            // Act : run a method that we're testing
            List<book> books = mybasket.getBooksInBasket();

            // Assert : see if result is what we expected
            Assert.AreEqual(2, books.Count);

        }
        

    }
}
