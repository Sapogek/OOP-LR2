namespace OOP_LR2.Games
{
    public class GameFactory
    {
        public static Game GetStandardGame()
        {
            return new StandardGame();
        }
        public static Game GetTrainingGame()
        {
            return new TrainingGame();
        }
        
        public static Game GetSinglePlayerGame()
        {
            return new SinglePlayerGame();
        }
    }
}