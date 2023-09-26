namespace _06._Basketball_Tournaments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wonMatches = 0;
            int lostMatches = 0;

            string input;
            while ((input = Console.ReadLine()) != "End of tournaments")
            {
                int matchCount = int.Parse(Console.ReadLine());

                int currentMatch = 1;

                while (currentMatch <= matchCount)
                {
                    int desiPoints = int.Parse(Console.ReadLine());
                    int enemyPoints = int.Parse(Console.ReadLine());

                    if (desiPoints > enemyPoints)
                    {
                        wonMatches++;
                        Console.WriteLine($"Game {currentMatch} of tournament {input}: win with {Math.Abs(desiPoints - enemyPoints)} points.");
                    }
                    else
                    {
                        lostMatches++;
                        Console.WriteLine($"Game {currentMatch} of tournament {input}: lost with {Math.Abs(desiPoints - enemyPoints)} points.");
                    }
                    currentMatch++;
                }
            }

            int totalMatches = wonMatches + lostMatches;

            Console.WriteLine($"{(double)wonMatches / totalMatches * 100:f2}% matches win");
            Console.WriteLine($"{(double)lostMatches / totalMatches * 100:f2}% matches lost");

        }
    }
}