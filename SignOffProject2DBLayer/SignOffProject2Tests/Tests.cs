using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignOffProject2DBLayer;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SignOffProject2Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test_AddBookInRepository_AddsABook()
        {
            //Arrange
            Mock<Book> mockBook = new Mock<Book>();

            List<Book> expected = new List<Book>();
            expected.Add(mockBook.Object);

            //var testData = new List<Book>()
            //{

            //}.AsQueryable();

            Mock<DbSet<Book>> dbSetMock = new Mock<DbSet<Book>>();
            //dbSetMock.As<IQueryable<Book>>().Setup(d => d.Provider).Returns(testData.Provider);
            //dbSetMock.As<IQueryable<Book>>().Setup(d => d.Expression).Returns(testData.Expression);
            //dbSetMock.As<IQueryable<Book>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            //dbSetMock.As<IQueryable<Book>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<SignOffDBModel> contextMock = new Mock<SignOffDBModel>();
            contextMock.Setup(b => b.books).Returns(dbSetMock.Object);
            Repository classUnderTest = new Repository(contextMock.Object);

            //Act
            classUnderTest.AddBook(mockBook.Object);

            //Assert
            dbSetMock.Verify(b => b.Add(mockBook.Object));
            contextMock.Verify(b => b.SaveChanges());
        }
    }
}
