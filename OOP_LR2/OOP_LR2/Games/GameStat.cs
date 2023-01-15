using System;
using OOP_LR2;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2.Games
{
    public class GameStat
    {
        public Guid IndexGame { get; }
        public Account firstOpponent { get; }

        public Account secondOpponent { get; }

        public int Rating { get; set; }

        public ResultGame Result { get; }
        public string Id { get; set; }

        public GameStat(Account firstOpponent, Account secondOpponent, int rating, ResultGame result)
        {
            IndexGame = Guid.NewGuid();
            this.firstOpponent = firstOpponent;
            this.secondOpponent = secondOpponent;
            Rating = rating;
            Result = result;
        }
    }
}