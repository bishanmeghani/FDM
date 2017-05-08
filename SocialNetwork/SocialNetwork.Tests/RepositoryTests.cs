﻿using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork.DataAccess;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SocialNetwork.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        public Repository<User> userRepo;
        public List<User> testUsers;

        public Mock<SocialNetworkDataModel> mockContext;
        public Mock<DbSet<User>> mockUsers;
        public Mock<User> mockUser1;
        public Mock<User> mockUser2;
        public Mock<User> mockUser3;

        [TestInitialize]
        public void Setup()
        {
            mockUser1 = new Mock<User>();
            mockUser2 = new Mock<User>();
            mockUser3 = new Mock<User>();

            mockUser1.SetupAllProperties();
            mockUser2.SetupAllProperties();
            mockUser3.SetupAllProperties();

            mockUser1.Object.userId = 1;
            mockUser1.Object.username = "Test A";
            mockUser2.Object.userId = 2;
            mockUser2.Object.username = "Test B";
            mockUser3.Object.username = "Test C";

            mockUsers = new Mock<DbSet<User>>();
            testUsers = new List<User>()
            {
                mockUser1.Object,
                mockUser2.Object
            };

            mockUsers.As<IQueryable<User>>().Setup(d => d.Provider).Returns(testUsers.AsQueryable().Provider);
            mockUsers.As<IQueryable<User>>().Setup(d => d.Expression).Returns(testUsers.AsQueryable().Expression);
            mockUsers.As<IQueryable<User>>().Setup(d => d.ElementType).Returns(testUsers.AsQueryable().ElementType);
            mockUsers.As<IQueryable<User>>().Setup(d => d.GetEnumerator()).Returns(testUsers.AsQueryable().GetEnumerator());

            mockContext = new Mock<SocialNetworkDataModel>();
            mockContext.Setup(c => c.Set<User>()).Returns(mockUsers.Object);

            userRepo = new Repository<User>(mockContext.Object);
        }

        [TestMethod]
        public void Test_GetAll_ReturnsListOfAllUsers_WhenCalled()
        {
            // Arrange

            // Act
            List<User> result = userRepo.GetAll().ToList();

            // Assert
            CollectionAssert.AreEquivalent(testUsers, result);
        }

        [TestMethod]
        public void Test_Insert_CallsAddMethodWithCorrectUser_WhenCalled()
        {
            // Arrange

            // Act
            userRepo.Insert(mockUser3.Object);

            // Assert
            mockUsers.Verify(m => m.Add(mockUser3.Object), Times.Once);
        }

        [TestMethod]
        public void Test_Remove_CallsRemoveMethodWithCorrectUser_WhenCalled()
        {
            // Arrange

            // Act
            userRepo.Remove(mockUser2.Object);

            // Assert
            mockUsers.Verify(m => m.Remove(mockUser2.Object), Times.Once);
        } 

        [TestMethod]
        public void Test_Search_ReturnsListOfAllUsers_WhenCalledForAllUsers()
        {
            // Arrange 
            Func<User, bool> expression = u => true;

            // Act
            List<User> result = userRepo.Search(expression).ToList();

            // Assert
            CollectionAssert.AreEquivalent(result, testUsers);
        }
        
        [TestMethod]
        public void Test_Search_ReturnsListOfRelevantUsers_WhenCalledForSpecificUsers()
        {
            // Arrange 
            Func<User, bool> expression = u => u.username == "Test A";
            List<User> expected = new List<User>() { mockUser1.Object };

            // Act
            List<User> result = userRepo.Search(expression).ToList();

            // Assert
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void Test_Search_ReturnsEmptyList_WhenCalledForNoSpecificUsers()
        {
            // Arrange 
            Func<User, bool> expression = u => u.username == null;

            // Act
            List<User> result = userRepo.Search(expression).ToList();

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
