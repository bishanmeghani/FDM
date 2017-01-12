using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineTraining.DataAccess;
using OnlineTraining.Logic;
using OnlineTraining.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;

namespace OnlineTrainingTests
{
    [TestClass]
    public class OLTrainingTests
    {
        [TestMethod]
        public void Test_GetAllCoursesReturnsAllCourses()
        {
            //Arrange
            Courses course1 = new Courses();
            course1 = new Courses { courseId = 13, courseName = "C# Programming", courseRating = "4 Stars", courseDurationHours = 150 };
            Courses course2 = new Courses();
            course2 = new Courses { courseId = 14, courseName = "Mandarin", courseRating = "2 Stars", courseDurationHours = 40 };

            List<Courses> expected = new List<Courses>();
            expected = new List<Courses> { course1, course2 };

            //List<Courses> expected = new List<Courses>()
            //{
            //    new Courses { courseId = 13, courseName = "C# Programming", courseRating = "4 Stars", courseDurationHours = 150 },
            //    new Courses { courseId = 14, courseName = "Mandarin", courseRating = "2 Stars", courseDurationHours = 40 }
            //};

            var testData = new List<Courses>()
            {
                new Courses { courseId = 13, courseName = "C# Programming", courseRating = "4 Stars", courseDurationHours = 150 },
                new Courses { courseId = 14, courseName = "Mandarin", courseRating = "2 Stars", courseDurationHours = 40 }
            }.AsQueryable();

            Mock<DbSet<Courses>> dbSetMock = new Mock<DbSet<Courses>>();
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.courses).Returns(dbSetMock.Object);
            
            Reposit classUnderTest = new Reposit(contextMock.Object);

            //Act
            List<Courses> actual = classUnderTest.GetAllCourses();
           
            //Assert
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].courseId, actual[0].courseId);
            Assert.AreEqual(expected[1].courseId, actual[1].courseId);
        }

        [TestMethod]
        public void Test_GetAllCustomersReturnsAllCustomers()
        {
            //Arrange
            Customers customer1 = new Customers();
            customer1 = new Customers { customerId = 11, customerFirstName = "Mister", customerLastName = "Bean", customerAddress = "12ArbourRoad-N51RA", customerPhone = "", customerEmail = "mrbean@studios.com", customerpassword = "beano"};
            Customers customer2 = new Customers();
            customer2 = new Customers { customerId = 12, customerFirstName = "Trigger", customerLastName = "Ball", customerAddress = "Flat3PeckhamRoad-SE153AA", customerPhone = "07401255663", customerEmail = "trigg@studios.com", customerpassword = "dave" };

            List<Customers> expected = new List<Customers>();
            expected = new List<Customers> { customer1, customer2 };

            var testData = new List<Customers>()
            {
                new Customers { customerId = 11, customerFirstName = "Mister", customerLastName = "Bean", customerAddress = "12ArbourRoad-N51RA", customerPhone = "", customerEmail = "mrbean@studios.com", customerpassword = "beano" },
                new Customers { customerId = 12, customerFirstName = "Trigger", customerLastName = "Ball", customerAddress = "Flat3PeckhamRoad-SE153AA", customerPhone = "07401255663", customerEmail = "trigg@studios.com", customerpassword = "dave" }
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As < IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);

            //Act
            List<Customers> actual = classUnderTest.GetAllCustomers();

            //Assert
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].customerId, actual[0].customerId);
            Assert.AreEqual(expected[1].customerId, actual[1].customerId);
        }

        [TestMethod]
        public void Test_GetAllPerformancesReturnsAllPerformances()
        {
            //Arrange
            Performances performance1 = new Performances();
            performance1 = new Performances { performanceId = 12, performancePercentage = 12 };
            Performances performance2 = new Performances();
            performance2 = new Performances { performanceId = 13, performancePercentage = 13 };

            List<Performances> expected = new List<Performances>();
            expected = new List<Performances> { performance1, performance2 };

            var testData = new List<Performances>()
            {
                new Performances { performanceId = 12, performancePercentage = 12 },
                new Performances { performanceId = 13, performancePercentage = 13 }
            }.AsQueryable();

            Mock<DbSet<Performances>> dbSetMock = new Mock<DbSet<Performances>>();
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.performances).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);

            //Act
            List<Performances> actual = classUnderTest.GetAllPerformances();

            //Assert
            //CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(expected[0].performanceId, actual[0].performanceId);
            Assert.AreEqual(expected[1].performanceId, actual[1].performanceId);
        }
    }
}
