namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine()); // number of tournaments he participated in
            int startPoints = int.Parse(Console.ReadLine()); // the starting points of the ranklist
             // the current stage of the game

            // W - 2000 points
            // F - 1200 points
            // SF - 720 points

            int totalpoints = 0;
            int tourPoints = 0;
            double winCounter = 0;

            for (int i = 1; i <= tournaments;i++)
            {
                string currentStage = Console.ReadLine();

                switch (currentStage)
                {
                    case "W":
                        winCounter++;
                        tourPoints += 2000;
                        totalpoints = startPoints + tourPoints;
                        break;
                    case "F":
                        tourPoints += 1200;
                        totalpoints = startPoints + tourPoints;
                        break;
                    case "SF":
                        tourPoints += 720;
                        totalpoints = startPoints + tourPoints;
                        break;
                }
            }

            int tourAverage = (tourPoints / tournaments);
            

            Console.WriteLine($"Final points: {totalpoints}");
            Console.WriteLine($"Average points: {tourAverage}");
            Console.WriteLine($"{(winCounter / tournaments) * 100:F2}%");
        }
    }
}