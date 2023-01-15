using System;
using OOP_LR2.Games;

namespace OOP_LR2.TypeAccounts
{
    public class LowPriorityAccount : Account
    {
        public LowPriorityAccount(string userName) : base(userName)
        {
        }
        
        public override void WinGame(string typeGame, GameStat game, Account player)
        {
            var bonus = 0;
            if (game.Rating < 0)
            {
                throw new ArgumentException("rating < 0");
            }

            var beforeRating = CurrentRating;

            var winners = 0;

            if (Results.Count >= 3)
            {
                for (var i = Results.Count - 1; i > Results.Count - 4; i--)
                {
                    if (Results[i].Result == ResultGame.Lose)
                    {
                        winners++;
                    }
                }
            }


            if (winners == 3)
            {
                CurrentRating += (int)(game.Rating / 1.5);
                bonus = (int)(game.Rating / 1.5) - game.Rating;
            }
            else
            {
                CurrentRating += game.Rating;
            }

            Results.Add(new AccountStat(typeGame, game.IndexGame, game.Rating, ResultGame.Win, player, beforeRating,
                CurrentRating, bonus));
        }
    }
}