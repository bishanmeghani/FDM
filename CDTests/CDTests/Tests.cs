using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDs;
using System.Collections.Generic;
using System.Linq;

namespace CDTests
{
    [TestClass]
    public class Tests
    {
        CDStock stock;

        [TestInitialize]
        public void Setup()
        {
            stock = new CDStock();
            stock.cds.Add(new CD("A", "a", 10, 1));
            stock.cds.Add(new CD("B", "b", 20, 2));
            stock.cds.Add(new CD("C", "c", 30, 3));
            stock.cds.Add(new CD("D", "d", 40, 4));
            stock.cds.Add(new CD("E", "e", 50, 5));
            stock.cds.Add(new CD("F", "f", 60, 6));
            stock.cds.Add(new CD("G", "g", 70, 7));
            stock.cds.Add(new CD("H", "h", 80, 8));
            stock.cds.Add(new CD("I", "i", 90, 9));
            stock.cds.Add(new CD("J", "j", 100, 10));
        }

        [TestMethod]
        public void CheckThatSearchByTitleReturnsSearchedCD()
        {
            //Arrange
            
            List<CD> expected = new List<CD>();
            expected.Add(stock.cds[4]);

            //Act
            List<CD> actual = stock.SearchByTitle("E").ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckThatSearchForTracksLessThan10ReturnsFirst9CDs()
        {
            //Arrange

            List<CD> expected = new List<CD>();
            expected.Add(stock.cds[0]);
            expected.Add(stock.cds[1]);
            expected.Add(stock.cds[2]);
            expected.Add(stock.cds[3]);
            expected.Add(stock.cds[4]);
            expected.Add(stock.cds[5]);
            expected.Add(stock.cds[6]);
            expected.Add(stock.cds[7]);
            expected.Add(stock.cds[8]);

            //Act
            List<CD> actual = stock.SearchForTracksLessThan10().ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckThatSearchForTracksMoreThan60MinReturnsLastFourTracks()
        {
            //Arrange

            List<CD> expected = new List<CD>();
            expected.Add(stock.cds[6]);
            expected.Add(stock.cds[7]);
            expected.Add(stock.cds[8]);
            expected.Add(stock.cds[9]);

            //Act
            List<CD> actual = stock.SearchForLengthOfTracksMoreThan60Min().ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckThatOrderByTitleReturnsListInAlphabeticalOrder()
        {
            //Arrange

            List<CD> expected = new List<CD>();
            expected.Add(stock.cds[0]);
            expected.Add(stock.cds[1]);
            expected.Add(stock.cds[2]);
            expected.Add(stock.cds[3]);
            expected.Add(stock.cds[4]);
            expected.Add(stock.cds[5]);
            expected.Add(stock.cds[6]);
            expected.Add(stock.cds[7]);
            expected.Add(stock.cds[8]);
            expected.Add(stock.cds[9]);

            //Act
            List<CD> actual = stock.OrderByAlphabeticalOrder().ToList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfArtistExistsReturnsFalseIfArtistDoesntExist()
        {
            //Arrange

            bool expected = false;

            //Act
            bool actual = stock.CheckIfArtistExists("z");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfArtistExistsReturnsTrueIfArtistExists()
        {
            //Arrange

            bool expected = true;

            //Act
            bool actual = stock.CheckIfArtistExists("f");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
