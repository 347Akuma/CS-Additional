namespace _07._Cat_Walk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dailyWalkMin = int.Parse(Console.ReadLine());
            int dailyWalkCount = int.Parse(Console.ReadLine());
            int catDailyKcal = int.Parse(Console.ReadLine());

            int totalDailyWalk = dailyWalkCount * dailyWalkMin;

            int totalKcalBurned = totalDailyWalk * 5;

            if (totalKcalBurned >= catDailyKcal)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalKcalBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalKcalBurned}.");
            }
        }
    }
}