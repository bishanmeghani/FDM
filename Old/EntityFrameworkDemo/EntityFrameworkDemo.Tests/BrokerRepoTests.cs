using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkDemo.CodeFirst;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Moq;

namespace EntityFrameworkDemo.Tests
{
    [TestClass]
    public class BrokerRepoTests
    {
        [TestMethod]
        public void Test_GetAllBrokersReturnsAllBrokers()
        {
            //Arrange
            var expected = new List<Broker>
            {
                new Broker { id = 1, name = "Batman", companyId = 1 },
                new Broker { id = 2, name = "Robin", companyId = 1 },
                new Broker { id = 3, name = "Joker", companyId = 1 }

            };

            var testData = new List<Broker>
             {
                new Broker { id = 1, name = "Batman", companyId = 1 },
                new Broker { id = 2, name = "Robin", companyId = 1 },
                new Broker { id = 3, name = "Joker", companyId = 1 }

            }.AsQueryable();

            Mock<DbSet<Broker>> dbSetMock = new Mock<DbSet<Broker>>();
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Broker>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            var contextMock = new Mock<CodeFirstModel>();
            contextMock.Setup(c => c.brokers).Returns(dbSetMock.Object);

            BrokerRepo classUnderTest = new BrokerRepo(contextMock.Object);
            //Act
            var actual = classUnderTest.GetAllBrokers();
            //Assert
            Assert.AreEqual(expected[0].id, actual[0].id);
            Assert.AreEqual(expected[1].id, actual[1].id);
            Assert.AreEqual(expected[2].id, actual[2].id);
        }
    }
}
