﻿using System;
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
            Mock<Courses> course1 = new Mock<Courses>();
            Mock<Courses> course2 = new Mock<Courses>();

            List<Courses> expected = new List<Courses>();
            expected = new List<Courses> { course1.Object, course2.Object };

            var testData = new List<Courses>()
            {
                course1.Object,
                course2.Object
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
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllCustomersReturnsAllCustomers()          
        {       
            //Arrange
            Mock<Customers> customer1 = new Mock<Customers>();
            Mock<Customers> customer2 = new Mock<Customers>();
            List<Customers> expected = new List<Customers>();
            expected = new List<Customers> { customer1.Object, customer2.Object };

            var testData = new List<Customers>()
            {
               customer1.Object,
               customer2.Object
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
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_GetAllPerformancesReturnsAllPerformances()
        {
            //Arrange

            Mock<Performances> performance1 = new Mock<Performances>();
            Mock<Performances> performance2 = new Mock<Performances>();
            List<Performances> expected = new List<Performances>();
            expected = new List<Performances> { performance1.Object, performance2.Object };

            var testData = new List<Performances>()
            {
               performance1.Object,
               performance2.Object
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
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddCustomerMethodAddsANewCustomer()
        {
            //Arrange
            Mock<Customers> customerAdded = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList.Add(customerAdded.Object);

            var testData = new List<Customers>()
            {

            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);

            //Act
            classUnderTest.AddCustomer(customerAdded.Object);

            //Assert

            dbSetMock.Verify(c => c.Add(customerAdded.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_AddCourseMethodAddsANewCourse()
        {
            //Arrange
            Mock<Courses> courseAdded = new Mock<Courses>();

            List<Courses> courseList = new List<Courses>();
            courseList.Add(courseAdded.Object);

            var testData = new List<Courses>()
            {

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
            classUnderTest.AddCourse(courseAdded.Object);

            //Assert

            dbSetMock.Verify(c => c.Add(courseAdded.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }
        
        [TestMethod]
        public void Test_AddPerformanceMethodAddsANewPerformance()
        {
            //Arrange
            Mock<Performances> performanceAdded = new Mock<Performances>();

            List<Performances> performanceList = new List<Performances>();
            performanceList.Add(performanceAdded.Object);

            var testData = new List<Performances>()
            {

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
            classUnderTest.AddPerformance(performanceAdded.Object);

            //Assert

            dbSetMock.Verify(c => c.Add(performanceAdded.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemoveCustomerByIdMethodRemovesCustomer()
        {
            //Arrange
            Mock<Customers> customerRemoved = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerRemoved.Object };

            customerRemoved.Setup(c => c.customerId).Returns(1);

            var testData = new List<Customers>()
            {
                customerRemoved.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(customerRemoved.Object));

            //Act
            classUnderTest.RemoveCustomerById(1);

            //Assert

            dbSetMock.Verify(c => c.Remove(customerRemoved.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemoveCourseByIdMethodRemovesCourse()
        {
            //Arrange
            Mock<Courses> courseRemoved = new Mock<Courses>();

            List<Courses> courseList = new List<Courses>();
            courseList = new List<Courses> { courseRemoved.Object };

            courseRemoved.Setup(c => c.courseId).Returns(1);

            var testData = new List<Courses>()
            {
                courseRemoved.Object
            }.AsQueryable();
            
            Mock<DbSet<Courses>> dbSetMock = new Mock<DbSet<Courses>>();
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Courses>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.courses).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(courseRemoved.Object));

            //Act
            classUnderTest.RemoveCourseById(1);

            //Assert

            dbSetMock.Verify(c => c.Remove(courseRemoved.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_RemovePerformanceByIdMethodRemovesPerformance()
        {

            //Arrange
            Mock<Performances> performanceRemoved = new Mock<Performances>();

            List<Performances> performanceList = new List<Performances>();
            performanceList = new List<Performances> { performanceRemoved.Object };

            performanceRemoved.Setup(c => c.performanceId).Returns(1);

            var testData = new List<Performances>()
            {
                performanceRemoved.Object
            }.AsQueryable();

            
            Mock<DbSet<Performances>> dbSetMock = new Mock<DbSet<Performances>>();
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Performances>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(p => p.performances).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(performanceRemoved.Object));

            //Act
            classUnderTest.RemovePerformanceById(1);

            //Assert

            dbSetMock.Verify(c => c.Remove(performanceRemoved.Object), Times.Once);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_CheckIfUserHasAnAccountReturnsTrueIfUserHasAnAccount()
        {
            //Arrange
            Mock<Customers> customerChecked = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerChecked.Object };

            customerChecked.Setup(c => c.customerEmail).Returns("mrbean@studios.com");

            var testData = new List<Customers>()
            {
                customerChecked.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);


            //Act
            bool actual = classUnderTest.CheckIfUserHasAnAccount("mrbean@studios.com");

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_CheckIfUserHasAnAccountReturnsFalseIfUserDoesntHaveAnAccount()
        {
            //Arrange
            Mock<Customers> customerChecked = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerChecked.Object };

            customerChecked.Setup(c => c.customerEmail).Returns("mrbean@studios.com");

            var testData = new List<Customers>()
            {

            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);


            //Act
            bool actual = classUnderTest.CheckIfUserHasAnAccount("mrbean@studios.com");

            //Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_CheckIfGetCourseByIdGetsTheCorrectCourse()
        {
            //Arrange
            Mock<Courses> courseToCheck = new Mock<Courses>();
            List<Courses> courseList = new List<Courses>();
            courseList = new List<Courses> { courseToCheck.Object };

            courseToCheck.Setup(c => c.courseId).Returns(1);
            courseToCheck.Setup(c => c.courseName).Returns("GCSE Maths");

            var testData = new List<Courses>()
            {
                courseToCheck.Object,
                
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
            string actual = classUnderTest.GetCourseById(1).courseName;

            //Assert
            Assert.AreEqual("GCSE Maths", actual);
        }

        [TestMethod]
        public void Test_CheckIfUpdateCustomerByIdUpdatesTheirAdminStatus()
        {
            //Arrange
            Mock<Customers> customerUpdated = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerUpdated.Object };

            customerUpdated.Setup(c => c.customerId).Returns(1);
            customerUpdated.Setup(c => c.customerAdmin).Returns(0);

            var testData = new List<Customers>()
            {
                customerUpdated.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(customerUpdated.Object));
            customerUpdated.SetupSet(c => c.customerAdmin = 1).Verifiable();

            //Act
            classUnderTest.UpdateCustomerById(1, "customerAdmin", "1");

            //Assert
            customerUpdated.VerifySet(c => c.customerAdmin = 1);
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_CheckIfUpdateCustomerByIdUpdatesTheirFirstName()
        {
            //Arrange
            Mock<Customers> customerUpdated = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerUpdated.Object };

            customerUpdated.Setup(c => c.customerId).Returns(1);
            customerUpdated.Setup(c => c.customerFirstName).Returns("John");

            var testData = new List<Customers>()
            {
                customerUpdated.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);
            dbSetMock.Setup(s => s.Remove(customerUpdated.Object));
            customerUpdated.SetupSet(c => c.customerFirstName = "Paul").Verifiable();

            //Act
            classUnderTest.UpdateCustomerById(1, "customerFirstName", "Paul");

            //Assert
            customerUpdated.VerifySet(c => c.customerFirstName = "Paul");
            contextMock.Verify(c => c.SaveChanges(), Times.Once);
        }

        

        [TestMethod]
        public void Test_CheckIfPasswordIsCorrect()
        {
            //Arrange
            Mock<Customers> customerChecked = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerChecked.Object };

            customerChecked.Setup(c => c.customerPassword).Returns("password");

            var testData = new List<Customers>()
            {
                customerChecked.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);


            //Act
            bool actual = classUnderTest.CheckUserPassword("password");

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_CheckIfPasswordIsNotCorrect()
        {
            //Arrange
            Mock<Customers> customerChecked = new Mock<Customers>();

            List<Customers> customerList = new List<Customers>();
            customerList = new List<Customers> { customerChecked.Object };

            customerChecked.Setup(c => c.customerPassword).Returns("password");

            var testData = new List<Customers>()
            {
                customerChecked.Object
            }.AsQueryable();

            Mock<DbSet<Customers>> dbSetMock = new Mock<DbSet<Customers>>();
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Provider).Returns(testData.Provider);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.Expression).Returns(testData.Expression);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.ElementType).Returns(testData.ElementType);
            dbSetMock.As<IQueryable<Customers>>().Setup(d => d.GetEnumerator()).Returns(testData.GetEnumerator());

            Mock<OnlineTrainingModel> contextMock = new Mock<OnlineTrainingModel>();
            contextMock.Setup(c => c.customers).Returns(dbSetMock.Object);

            Reposit classUnderTest = new Reposit(contextMock.Object);


            //Act
            bool actual = classUnderTest.CheckUserPassword("wrongpassword");

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
