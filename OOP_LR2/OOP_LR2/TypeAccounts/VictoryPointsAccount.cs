using System;
using OOP_LR2;
using OOP_LR2.Games;

namespace OOP_LR2.TypeAccounts
{
    public class VictoryPointsAccount : Account{
        
    public VictoryPointsAccount(string userName) : base(userName)
            {
            }

            public override void WinGame(string typeGame, GameStat game, Account player)
            {
                if (game.Rating < 0)
                {
                    throw new ArgumentException("rating < 0");
                }


                var beforeRating = CurrentRating;
                CurrentRating += game.Rating * 2;
                Results.Add(new AccountStat(typeGame, game.IndexGame, game.Rating, ResultGame.Win, player, beforeRating,
                    CurrentRating, game.Rating));
            }

            public override void LoseGame(string typeGame, GameStat game, Account player)
            {
                var bonus = 0;
                if (game.Rating < 0)
                {
                    throw new ArgumentException("rating < 0");
                }

                var beforeRating = CurrentRating;

                CurrentRating -= game.Rating / 2;
                bonus = game.Rating - game.Rating / 2;

                Results.Add(new AccountStat(typeGame, game.IndexGame, game.Rating, ResultGame.Lose, player, beforeRating,
                    CurrentRating, bonus));
        }
    }
}