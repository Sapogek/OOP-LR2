using System;
using OOP_LR2;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2.Games
{

    public class SinglePlayerGame : Game
    {
        public SinglePlayerGame()
        {
            TypeGame = GetType().ToString().Substring(GetType().ToString().LastIndexOf('.') + 1);
        }

        public override void Information()
        {
            Console.WriteLine("Stats about " + TypeGame);
            Console.WriteLine("Games count: " + Results.Count);

            Console.WriteLine("|\t\tID\t\t    | |Players       | |Raiting| |Result|");
            foreach (var result in Results)
            {
                Console.Write(
                    $"|{result.IndexGame,6}|  -->  |");
                Console.Write($"{result.firstOpponent.UserName,5}");
                Console.WriteLine($" VS {result.secondOpponent.UserName,-5}| |{result.Rating}| |{result.firstOpponent.UserName,5} {result.Result,-4} {result.secondOpponent.UserName,-5}|");
            }
            
        }

        public override void Acting(Account firstOpponent, Account secondOpponent, int rating)
        {
            var random = Random.Next(1, 3);

            if (random == 1)
            {
                var game = new GameStat(firstOpponent, secondOpponent, 0, ResultGame.Win);
                secondOpponent.LoseGame(TypeGame, game, firstOpponent);
                game.Rating = rating;
                firstOpponent.WinGame(TypeGame, game, secondOpponent);
                Results.Add(game);
            }
            else
            {
                
                var game = new GameStat(firstOpponent, secondOpponent, 0, ResultGame.Lose);
                secondOpponent.WinGame(TypeGame, game, firstOpponent);
                game.Rating = rating;
                firstOpponent.LoseGame(TypeGame, game, secondOpponent);
                Results.Add(game);

            }
        }
    }
}