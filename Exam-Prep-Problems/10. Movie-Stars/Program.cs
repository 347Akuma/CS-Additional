namespace _10._Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double actorsBudget = double.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "ACTION")
            {               
                if (input.Length <= 15)
                {
                    double currActorSalary = double.Parse(Console.ReadLine());
                    actorsBudget = actorsBudget - currActorSalary;
                }
                else
                {
                    actorsBudget = actorsBudget * 0.80;
                }
                if (actorsBudget < 0)
                {
                    break;
                }
            }
            if (actorsBudget > 0)
            {
                Console.WriteLine($"We are left with {actorsBudget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {-actorsBudget:f2} leva for our actors");
            }
        }
    }
}