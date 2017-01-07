using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata;

namespace TennisTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test_NewGameShouldReturnLoveAll()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            string actual = scores.GetScore();
            string expected = "Love all";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    
    
        [TestMethod]
        public void Test_PlayerOneWinsFirstBall()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            string actual = scores.GetScore();
            string expected = "Fifteen, Love";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_FifteenAll()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Fifteen all";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerTwoWinsFirstTwoBalls()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Love, Thirty";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerOneWinsFirstThreeBalls()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            string actual = scores.GetScore();
            string expected = "Forty, Love";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayersAreDeuce()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Deuce";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayersOneWins()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            string actual = scores.GetScore();
            string expected = "Rafael Nadal wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayersTwoWins()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Roger Federer wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayersAreDeuceAgain()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Deuce";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerTwoAdvantage()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Advantage Roger Federer";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerOneAdvantage()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            string actual = scores.GetScore();
            string expected = "Advantage Rafael Nadal";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerTwoWinsAfterAdvantage()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            string actual = scores.GetScore();
            string expected = "Roger Federer wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PlayerOneWinsAfterAdvantage()
        {
            //Arrange 
            TennisScores scores = new TennisScores("Rafael Nadal", "Roger Federer");

            //Act
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerTwoGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            scores.playerOneGainsPoint();
            string actual = scores.GetScore();
            string expected = "Rafael Nadal wins";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}