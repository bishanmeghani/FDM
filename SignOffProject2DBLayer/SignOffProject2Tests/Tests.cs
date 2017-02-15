using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignOffProject2DBLayer;
using Moq;
using System.Collections.Generic;

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

            //Mock<SignOffDBModel> contextMock = new Mock<SignOffDBModel>();
            //Repository classUnderTest = new Repository(contextMock.Object);

            //Act
            //classUnderTest.AddBook(mockBook.Object);

            //Assert

        }
    }
}
