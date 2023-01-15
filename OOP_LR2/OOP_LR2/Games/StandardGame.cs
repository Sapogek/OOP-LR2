using System.Linq;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2.Games
{
    public class StandardGame : Game
    {

            public StandardGame()
            {
                TypeGame = nameof(StandardGame);
            }
        
            public override void Acting(Account firstOpponent, Account secondOpponent, int rating )
            {
                var random = Random.Next(1, 2);//mb 3!!!!!!!
           

                if (random == 1)
                {
                
                    Results.Add(new GameStat( firstOpponent, secondOpponent, rating, ResultGame.Win));
                    firstOpponent.WinGame(TypeGame, Results.Last(), secondOpponent);
                    secondOpponent.LoseGame(TypeGame, Results.Last(), firstOpponent);
               
                }
                else
                {
                    Results.Add(new GameStat( firstOpponent, secondOpponent, rating, ResultGame.Lose));
                    firstOpponent.LoseGame(TypeGame, Results.Last(), secondOpponent);
                    secondOpponent.WinGame(TypeGame,Results.Last(), firstOpponent);
                }
            }
    }
}