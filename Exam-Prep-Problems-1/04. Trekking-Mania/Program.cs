namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int climberGroupsCount = int.Parse(Console.ReadLine());

            int groupMusala = 0;
            int groupMonblanc = 0;
            int groupKillimanjaro = 0;
            int groupKTwo = 0;
            int groupEverest = 0;

            int totalClimbers = 0;

            for (int i = 1; i <= climberGroupsCount; i++)
            {
                int climbersCount = int.Parse(Console.ReadLine());

                totalClimbers += climbersCount;

                if (climbersCount <= 5)
                {
                    groupMusala += climbersCount;
                }
                else if (climbersCount >= 6 && climbersCount <= 12)
                {
                    groupMonblanc += climbersCount;
                }
                else if (climbersCount >= 13 && climbersCount <= 25)
                {
                    groupKillimanjaro += climbersCount;
                }
                else if (climbersCount >= 26 && climbersCount <= 40)
                {
                    groupKTwo += climbersCount;
                }
                else
                {
                    groupEverest += climbersCount;
                }
            }
            Console.WriteLine($"{(double)groupMusala / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)groupMonblanc / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)groupKillimanjaro / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)groupKTwo / totalClimbers * 100:F2}%");
            Console.WriteLine($"{(double)groupEverest / totalClimbers * 100:F2}%");
        }
    }
}