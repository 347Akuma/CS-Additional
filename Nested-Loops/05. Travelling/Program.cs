namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }
               
                int minBudget = int.Parse(Console.ReadLine());
                int saved = 0;

                while (saved < minBudget)
                {
                    saved += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}