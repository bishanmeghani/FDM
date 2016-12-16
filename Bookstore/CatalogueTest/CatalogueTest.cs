using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bookstore;
using System.Collections.Generic;
using Moq;

namespace CatalogueTest
{
    [TestClass]
    public class CatalogueTest
    {
        Mock<DatabaseReader> mockDatabaseReader;
        Mock<DatabaseWriter> mockDatabaseWriter;
        Catalogue myCatalogue;

        [TestInitialize]
        public void Setup()
        {
            mockDatabaseReader = new Mock<DatabaseReader>();
            mockDatabaseWriter = new Mock<DatabaseWriter>();
            myCatalogue = new Catalogue(mockDatabaseReader.Object, mockDatabaseWriter.Object);
        }

        [TestMethod]
        public void Test_GetAllBooks_ReturnsEmptyBookList_IfNoBooksAreInTheCatalogue()
        {
            //Arrange
            mockDatabaseReader.Setup(r => r.ReadDb()).Returns(new List<Book>()); //Stubbing
            
            Book myBook = new Book();

            //Act
            List<Book> books = myCatalogue.GetAllBooks();

            //Assert
            Assert.AreEqual(0, books.Count);

        }

        [TestMethod]
        public void test_GetAllBooks_CallsReadDatabaseMethodOfDatabaseReader_WhenCalled()
        {
            //Arrange


            //Act
            myCatalogue.GetAllBooks();

            //Assert
            mockDatabaseReader.Verify(d => d.ReadDb(), Times.Once);
        }

        [TestMethod]
        public void test_GetAllBooks_ReturnsListOfBooksItReceivesFromReadDatabaseMethodOfDatabaseReader_WhenCalled()
        {
            //Arrange


            Mock<List<Book>> mockListofBooks = new Mock<List<Book>>();


            mockDatabaseReader.Setup(r => r.ReadDb()).Returns(mockListofBooks.Object);

            //Act
            List<Book> books = myCatalogue.GetAllBooks();


            //Assert
            CollectionAssert.AreEqual(mockListofBooks.Object, books);
        }

        [TestMethod]
        public void test_AddBook_CallsWriteDatabaseMethodOfDatabaseWriter_WhenCalled()
        {
            
            //Arrange


                
            //Act

            myCatalogue.AddBook(new Book());

            //Assert
            mockDatabaseWriter.Verify(d => d.WriteDatabase(It.IsAny<Book>()), Times.Once);
           
        }

        [TestMethod]
        public void test_Addbook_CallsWriteDatabaseMethodofDatabaseWriterWithTheBookObjectToAdd_WhenCalled()
        {
            //Arrange
            Mock<Book> mockBook = new Mock<Book>();



            //Act
            myCatalogue.AddBook(mockBook.Object);

            //Assert
            mockDatabaseWriter.Verify(r => r.WriteDatabase(mockBook.Object), Times.Once);

        }
    }
}


