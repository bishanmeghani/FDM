using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignOffProject2DBLayer;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SignOffProject2Logic;

namespace SignOffProject2Tests
{
    [TestClass]
    public class Tests
    {
        Mock<Book> mockBook;
        Mock<DbSet<Book>> dbSetMock;
        Mock<SignOffDBModel> contextMock;

        [TestInitialize]
        public void Setup()
        {
            mockBook = new Mock<Book>();
            dbSetMock = new Mock<DbSet<Book>>();
            contextMock = new Mock<SignOffDBModel>();
        }

        //Repository Tests

        [TestMethod]
        public void Test_AddBookInRepository_AddsABook()
        {
            //Arrange
            
            List<Book> expected = new List<Book>();
            expected.Add(mockBook.Object);                        
            contextMock.Setup(b => b.books).Returns(dbSetMock.Object);
            Repository classUnderTest = new Repository(contextMock.Object);

            //Act
            classUnderTest.AddBook(mockBook.Object);

            //Assert
            dbSetMock.Verify(b => b.Add(mockBook.Object));
            contextMock.Verify(b => b.SaveChanges());
        }

        [TestMethod]
        public void Test_GetAllBooksInRepository_GetsAllBooks()
        {
            //Arrange
           
            List<Book> expected = new List<Book>();
            expected.Add(mockBook.Object);

            var testData = new List<Book>()
            {
               mockBook.Object,
            }.AsQueryable();
                        
            dbSetMock.As<IQueryable<Book>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Book>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Book>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Book>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());
                       
            contextMock.Setup(b => b.books).Returns(dbSetMock.Object);
            Repository classUnderTest = new Repository(contextMock.Object);

            //Act
            List<Book> actual = classUnderTest.GetAllBooks();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddToCartInLogic_CallsAddBook()
        {
            //Arrange        
            
            contextMock.Setup(b => b.books).Returns(dbSetMock.Object);
            Mock<Repository> mockRepo = new Mock<Repository>(contextMock.Object);
            BookLogic classUnderTest = new BookLogic(contextMock.Object);
            mockRepo.Setup(b => b.AddBook(mockBook.Object)).Verifiable();
            
            //Act
            classUnderTest.AddToCart(mockBook.Object);

            //Assert
            mockRepo.Verify(b => b.AddBook(mockBook.Object), Times.Once);
        }
    }
}
