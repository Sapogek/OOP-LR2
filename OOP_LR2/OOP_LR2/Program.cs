using System;
using System.Collections.Generic;
using OOP_LR2.Games;
using OOP_LR2.TypeAccounts;

namespace OOP_LR2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {

            var random = new Random();
            var p = new VictoryPointsAccount("Pl1");
            var p1 = new LowPriorityAccount("Pl2");
            var p2 = new Account("Pl3");
            var list = new List<Game>{GameFactory.GetStandardGame(),GameFactory.GetTrainingGame(),GameFactory.GetSinglePlayerGame()};
            
            
            for (var i = 0; i < 5; i++)
            {
                list[0].Acting(p,p1,random.Next(5,20));
                list[0].Acting(p2,p1,random.Next(5,20));
            }
            
            list[0].Information();
            
            for (var i = 0; i < 5; i++)
            {
                list[1].Acting(p2,p,0);
                list[1].Acting(p1,p,0);
            }
            
            list[1].Information();
            
            for (var i = 0; i < 5; i++)
            {
                list[2].Acting(p,p2,random.Next(5,20));
                list[2].Acting(p1,p2,random.Next(5,20));
            }

            list[2].Information();
            p.InformationForPlayer();
            p.GetStats();
            p1.InformationForPlayer();
            p1.GetStats();
            p2.InformationForPlayer();
            p2.GetStats();
        }
    }
}