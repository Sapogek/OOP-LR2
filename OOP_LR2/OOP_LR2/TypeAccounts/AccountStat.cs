using System;

namespace OOP_LR2.TypeAccounts
{
    public class AccountStat
    {
        
        public AccountStat(string typeGame, Guid indexgame, int rating, ResultGame result, Account oponent,
            int beforeRating, int afterRating,int bonus)
        {
            TypeGame = typeGame;
            IndexGame = indexgame;
            Rating = rating;
            Result = result;
            Oponent = oponent;
            BeforeRating = beforeRating;
            AfterRating = afterRating;
            Bonus = bonus;
        }

        public static int Number = 1;

        public string TypeGame { get; }

        public Guid IndexGame { get; }

        public int Rating { get; }

        public ResultGame Result { get; }

        public Account Oponent { get; }

        public int BeforeRating { get; }

        public int AfterRating { get; }
        
        public int Bonus { get; }

    }
}