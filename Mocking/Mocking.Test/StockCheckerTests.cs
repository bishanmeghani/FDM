using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mocking.bookshop;


namespace Mocking.Test
{
    [TestClass]
    public class StockCheckerTests
    {
        [TestMethod]
        public void testnumberinstock_callsthereadquantitymethodfromourdatabasereaderwhencalled()
        {
            //Arrange
            Mock<Idatabasereader> mockdbreader = new Mock<Idatabasereader>();
            string isbn = "123";
            Stockchecker stockchecker = new Stockchecker(mockdbreader.Object);
            

            //Act
            stockchecker.numberinstock(isbn);

            //Assert
            // We expect readquantity to be called once and read a string otherwise it will fail
            mockdbreader.Verify(r => r.readquantity(It.IsAny<string>()), Times.Once);
            
        }

        [TestMethod]
        public void test_callsreadquatitu_correctisbn()
        {
            //Arrange
            Mock<Idatabasereader> mockdbreader = new Mock<Idatabasereader>();
            string isbn = "123";
            Stockchecker stockchecker = new Stockchecker(mockdbreader.Object);


            //Act
            stockchecker.numberinstock(isbn);

            //Assert
            // We expect readquantity to be called once and read a string otherwise it will fail
            mockdbreader.Verify(r => r.readquantity(isbn), Times.Once);
        }
        
        [TestMethod]
        public void test_numberinstockmethod_returns3whentherearethreematchingbooksinthedatabase()
        {
            //Arrange
            string isbn = "123";
            int expected = 3;
            Mock<Idatabasereader> mockdbreader = new Mock<Idatabasereader>();
            Stockchecker stockchecker = new Stockchecker(mockdbreader.Object);
            // Stubbing:
            mockdbreader.Setup(r => r.readquantity(isbn)).Returns(3); 

            //Act
            int actual = stockchecker.numberinstock(isbn);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
