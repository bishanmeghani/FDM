using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class TennisScores
    {
        private int playerOneScore { get; set; }
        private int playerTwoScore { get; set; }
        private string playerOneName { get; set; }
        private string playerTwoName { get; set; }

        public TennisScores(string PlayerOneName, string PlayerTwoName )
        {
            this.playerOneName = PlayerOneName;
            this.playerTwoName = PlayerTwoName;
        }


        public string GetScore()
        {
            if (playerAdvantage())
            {
                return "Advantage "+ playerWithHighestScore();
            }

            if (IsDeuce())
            {
                return "Deuce";
            }

            if (HasWinner())
            {
                return playerWithHighestScore() + " wins";
            }

            if (playerOneScore == playerTwoScore)
            {
                return ScoreInEnglish(playerOneScore) + " all";
            }

                        
            return ScoreInEnglish(playerOneScore) + ", " + ScoreInEnglish(playerTwoScore);
        }

        public void playerOneGainsPoint()
        {
            playerOneScore = playerOneScore + 1;
        }

        public void playerTwoGainsPoint()
        {
            playerTwoScore = playerTwoScore + 1;
        }

        private bool IsDeuce()
        {
            if (playerOneScore == playerTwoScore && playerOneScore >= 3)
            {
                return true;
            }
            return false;
        }

        private bool HasWinner()
        {
            if (playerOneScore >= 4 && playerOneScore > playerTwoScore)
            {
                return true;
            }
            if (playerTwoScore >= 4 && playerTwoScore > playerOneScore)
            {
                return true;
            }
            return false;
        }

        private string playerWithHighestScore()
        {
            if (playerOneScore > playerTwoScore)
            {
                return playerOneName;
            }
            else
            {
                return playerTwoName;
            }

        }

        private bool playerAdvantage()
        {
            if (playerOneScore >= 4 && playerOneScore - playerTwoScore == 1)
            {
                return true;
            }

            if (playerTwoScore >= 4 && playerTwoScore - playerOneScore == 1)
            {
                return true;
            }
            return false;
        }

        private string ScoreInEnglish(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
            }
            throw new IllegalArgumentException();
        }

        private class IllegalArgumentException : Exception
        {
            public IllegalArgumentException() : base("Not a valid score!")
            {

            }
        }
    }
}
