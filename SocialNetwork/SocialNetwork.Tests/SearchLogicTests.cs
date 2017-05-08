﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork.DataAccess;
using Moq;
using SocialNetwork.Logic;
using System.Collections.Generic;
using SocialNetwork.WebUI.Controllers;
using SocialNetwork.WebUI.Models;

namespace SocialNetwork.Tests
{
    [TestClass]
    public class SearchLogicTests
    {
        Mock<Repository<User>> userRepo;
        Mock<Repository<Post>> postRepo;
        ISearchLogic searchLogic;
        Mock<User> user1;
        Mock<Post> post1;
        List<User> users;
        List<Post> posts;

        [TestInitialize]
        public void SetUp()
        {
            userRepo = new Mock<Repository<User>>();
            postRepo = new Mock<Repository<Post>>();
            searchLogic = new SearchLogic(postRepo.Object, userRepo.Object);
            user1 = new Mock<User>();
            post1 = new Mock<Post>();
            users = new List<User>(){ user1.Object };
            posts = new List<Post>(){ post1.Object };
        }

        [TestMethod]
        public void Test_SearchForUserById_RunsFirstMethodInRepository_WithIdEnteredInMethod()
        {
            //Arrange

            userRepo.Setup(x => x.First(It.IsAny<Func<User, bool>>())).Returns(user1.Object);

            //Act
            IUser user = searchLogic.SearchForUserById(1);


            //Assert
            Assert.AreEqual(user1.Object, user);

        }

        [TestMethod]

        public void Test_SearchForUserByName_RunsSearchMethodInRepository_WithNameEnteredInMethod()
        {
            //Arrange           
            userRepo.Setup(x => x.Search(It.IsAny<Func<User, bool>>())).Returns(users);

            //Act

            List<User> actual = searchLogic.SearchForUserByName("Spencer Newton");  

            //Assert

            CollectionAssert.AreEqual(users, actual);

        }

        [TestMethod]

        public void Test_SearchForCode_RunsSearchMethodInRepository()
        {
            //Arrange
            List<Post> posts = new List<Post> { post1.Object };

            postRepo.Setup(x => x.Search(It.IsAny<Func<Post, bool>>())).Returns(posts);

            //Act
            List<Post> actual = searchLogic.SearchForCode("C#");

            //Assert

            CollectionAssert.AreEqual(posts, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(EntityNotFoundException))]
        public void Test_EntityNotFoundException_IsThrown_WhenSearchNameNotInDatabase_AndSearchForUserByNameMethodRun()
        {
            //Arrange
            userRepo.Setup(x => x.Search(It.IsAny<Func<User, bool>>())).Returns(new List<User>());
            //Act
            searchLogic.SearchForUserByName("Benjamin Bowes");
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(EntityNotFoundException))]
        public void Test_EntityNotFoundException_IsThrown_WhenSearchIdNotInDatabase_AndSearchForUserByIdMethodRun()
        {
            //Arrange
            userRepo.Setup(x => x.First(It.IsAny<Func<User, bool>>()));
            //Act
            searchLogic.SearchForUserById(1);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IntegerMustBeGreaterThanZeroException))]
        public void Test_IntegerMustBeGreaterThanZeroException_IsThrown_WhenSearchIdIsNotGreaterThanZero_AndSearchForUserByIdMethodRun()
        {
            //Arrange
            userRepo.Setup(x => x.First(It.IsAny<Func<User, bool>>()));
            //Act
            searchLogic.SearchForUserById(0);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(EntityNotFoundException))]
        public void Test_EntityNotFoundException_IsThrown_WhenCodeLanguageNotInDatabase_AndSearchForCodeMethodRun()
        {
            //Arrange
            postRepo.Setup(x => x.Search(It.IsAny<Func<Post, bool>>())).Returns(new List<Post>());
            //Act
            searchLogic.SearchForCode("Java");
            //Assert
        }

        [TestMethod]
        public void Test_CheckIfSearchTermInUserDataBase_ReturnsTrue_WhenTermExists() 
        {
            //arr
            bool resul = true;
            userRepo.Setup(g => g.GetAll()).Returns(new List<User>() { user1.Object });
            user1.Setup(u => u.fullName).Returns("user");

            //act
            bool actual = searchLogic.CheckIfSearchTermInUserDataBase("user");

            //ass 
            Assert.AreEqual(resul, actual);
            userRepo.Verify(d => d.GetAll(), Times.Once);
        
        }

        [TestMethod]
        public void Test_CheckIfSearchTermInUserDataBase_ReturnsFalse_WhenTermDoesNotExists()
        {
            //arr
            bool resul = false;
            userRepo.Setup(g => g.GetAll()).Returns(new List<User>() { user1.Object });
            user1.Setup(u => u.fullName).Returns("use");

            //act
            bool actual = searchLogic.CheckIfSearchTermInUserDataBase("user");

            //ass 
            Assert.AreEqual(resul, actual);
            userRepo.Verify(d => d.GetAll(), Times.Once);

        }

        [TestMethod]
        public void Test_CheckIfSearchTermInPostDataBase_ReturnsTrue_WhenTermExists()
        {
            //arr
            bool resul = true;
            postRepo.Setup(g => g.GetAll()).Returns(new List<Post>() { post1.Object });
            post1.Setup(u => u.language).Returns("user");

            //act
            bool actual = searchLogic.CheckIfSearchTermInPostDataBase("user");

            //ass 
            Assert.AreEqual(resul, actual);
            postRepo.Verify(d => d.GetAll(), Times.Once);

        }

        [TestMethod]
        public void Test_CheckIfSearchTermInPostDataBase_ReturnsFalse_WhenTermDoesNotExists()
        {
            //arr
            bool resul = false;
            postRepo.Setup(g => g.GetAll()).Returns(new List<Post>() { post1.Object });
            post1.Setup(u => u.language).Returns("user");

            //act
            bool actual = searchLogic.CheckIfSearchTermInPostDataBase("lo");

            //ass 
            Assert.AreEqual(resul, actual);
            postRepo.Verify(d => d.GetAll(), Times.Once);

        }

        
    }
}
