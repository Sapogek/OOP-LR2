using System;
using System.Collections.Generic;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2.Games
{
    public abstract class Game
    {
        protected Game()
        {
            Results = new List<GameStat>();
            Random = new Random();
        }

        protected string TypeGame { get; set; } 

        protected readonly Random Random ;
        protected List<GameStat> Results { get;}
        public abstract void Acting(Account firstOpponent, Account secondOpponent, int rating);
        
        public virtual void  Information()
        {
            Console.WriteLine("Stats about " + TypeGame);
            Console.WriteLine("Games count: " + Results.Count);

            Console.WriteLine("|\t\tID\t\t    | |Players       | |Raiting| |Result|");
            foreach (var result in Results)
            {
                Console.WriteLine(
                    $"{result.IndexGame,6}| |{result.firstOpponent.UserName,5} VS {result.secondOpponent.UserName,-5}| |{result.Rating}| |{result.firstOpponent.UserName,5} {result.Result,-4} {result.secondOpponent.UserName,-5}|");
            }
        }
    }
}