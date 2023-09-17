namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyStartPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());

            double currentPoints = academyStartPoints;
            string juryName;
            double juryPoints;

            // if points reach 1250.5 at any time the program must end -> print nominee ->  break;

            for (int i = 1; i <= juryCount; i++)
            {
                 juryName = Console.ReadLine();
                 juryPoints = double.Parse(Console.ReadLine());

                currentPoints += (juryName.Length * juryPoints) / 2;

                if (currentPoints > 1250.5)
                {
                    break;
                }               
            }
            if (currentPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {currentPoints:f1}!");
            }
            else if (currentPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - currentPoints:F1} more!");
            }

        } 
    }
}