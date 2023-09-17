namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int groupMusala = 0;
            int groupMonblan = 0;
            int groupKilimandjaro = 0;
            int groupK2 = 0;
            int groupEverest = 0;

            int peopleCount;

            int totalPeople = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                peopleCount = int.Parse(Console.ReadLine());

                if (peopleCount <= 5)
                {
                    groupMusala += peopleCount;
                    totalPeople += peopleCount;
                }
                else if (peopleCount >= 6 && peopleCount <= 12)
                {
                    groupMonblan += peopleCount;
                    totalPeople += peopleCount;
                }
                else if (peopleCount > 12 && peopleCount <= 25)
                {
                    groupKilimandjaro += peopleCount;
                    totalPeople += peopleCount;
                }
                else if (peopleCount > 25 && peopleCount <= 40)
                {
                    groupK2 += peopleCount;
                    totalPeople += peopleCount;
                }
                else if (peopleCount > 40)
                {
                    groupEverest += peopleCount;
                    totalPeople += peopleCount;
                }
            }

            Console.WriteLine($"{(double)groupMusala / totalPeople * 100:F2}%");
            Console.WriteLine($"{(double)groupMonblan / totalPeople * 100:F2}%");
            Console.WriteLine($"{(double)groupKilimandjaro / totalPeople * 100:F2}%");
            Console.WriteLine($"{(double)groupK2 / totalPeople * 100:F2}%");
            Console.WriteLine($"{(double)groupEverest / totalPeople * 100:F2}%");

        }
    }
}