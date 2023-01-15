using System;
using System.Collections.Generic;
using System.Linq;
using OOP_LR2.Games;

namespace OOP_LR2.TypeAccounts
{
    public  class Account
    {
        public Account(string userName)
        {
            UserName = userName;
            Results = new List<AccountStat>();
        }


        public string UserName { get; }

        private int _currentRating = 1;

        protected int CurrentRating
        {
            get => _currentRating;
            set => _currentRating = value < 1 ? 1 : value;
        }
        
        protected List<AccountStat> Results { get;  }

        public void InformationForPlayer()
        {
            Console.WriteLine("      Info for: " + UserName);
            Console.WriteLine("      Type account: " + GetType().ToString().Substring(GetType().ToString().LastIndexOf('.')+1));
            Console.WriteLine("      Player: " + UserName);
            Console.WriteLine("      Rating: " + CurrentRating);
            Console.WriteLine("      All game counter: " + Results.Count);
            Console.WriteLine("      Win counter: " + Results.Count(x => x.Result == ResultGame.Win));
            Console.WriteLine("      Lose counter: " + Results.Count(x => x.Result == ResultGame.Lose));


            Console.ResetColor();
        }
        
        public  void GetStats()
        {
            Console.WriteLine($"\n\t\t{"Stats for:",65} " + UserName);
            Console.WriteLine("| № || Type game  |       |                 ID                 |       |RATING GAME|       |     RESULT     |       |CHANGE|       |RATING|       |BONUS|\n");

            foreach (var result in Results)
            {
                Console.WriteLine($"|{AccountStat.Number,2} | |{result.TypeGame,-12}| |{result.IndexGame,6}| |{result.Rating}|  |{UserName,5} {result.Result,-4} {result.Oponent.UserName,-5}| |{result.BeforeRating,2} {(result.Result == ResultGame.Lose ? $"-{result.BeforeRating - result.AfterRating,2}" : $"{result.AfterRating - result.BeforeRating,2}")}" +
                                  $"|  {result.AfterRating,2}  |  -->  | +{result.Bonus}  |");
                AccountStat.Number++;
            }

            AccountStat.Number = 1;

            Console.WriteLine(
                "----------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Console.ResetColor();
        }
        public virtual void WinGame(string typeGame,  GameStat game, Account player )
        {
            if (game.Rating < 0)
            {
                throw new ArgumentException("rating < 0");
            }


            var beforeRating = CurrentRating;
            CurrentRating += game.Rating;
            Results.Add(new AccountStat(typeGame, game.IndexGame, game.Rating, ResultGame.Win, player, beforeRating, CurrentRating, 0));
        }
        
        public virtual void LoseGame(string typeGame,  GameStat game, Account player)
        {

            if (game.Rating < 0)
            {
                throw new ArgumentException("rating < 0");
            }

            var beforeRating = CurrentRating;
            CurrentRating -= game.Rating;
            Results.Add(new AccountStat(typeGame, game.IndexGame, game.Rating, ResultGame.Lose, player, beforeRating, CurrentRating, 0));
        }
    }
}
