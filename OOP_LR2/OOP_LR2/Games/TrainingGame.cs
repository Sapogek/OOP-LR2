using System.Linq;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2.Games
{
   
        public class TrainingGame : Game
        {
            public TrainingGame()
            {
                //TypeGame = GetType().ToString().Substring(GetType().ToString().LastIndexOf('.') + 1);//
                TypeGame = nameof(TrainingGame);
            }


            public override void Acting(Account firstOpponent, Account secondOpponent, int rating)
            {
                
                var random = Random.Next(1, 3);

                if (random == 1)
                {
                    rating = 0;
                    Results.Add(new GameStat(firstOpponent, secondOpponent, rating, ResultGame.Win));
                    firstOpponent.WinGame(TypeGame, Results.Last(), secondOpponent);
                    secondOpponent.LoseGame(TypeGame,Results.Last(), firstOpponent);
                }
                else
                {
                    rating = 0;
                    Results.Add(new GameStat(firstOpponent, secondOpponent, rating, ResultGame.Lose));
                    firstOpponent.LoseGame(TypeGame, Results.Last(), secondOpponent);
                    secondOpponent.WinGame(TypeGame,  Results.Last(), firstOpponent);
                }
            }
        }
    }