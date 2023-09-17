namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string openWebsite;

            for (int i = 2; i <= openTabs; i++)
            {
                openWebsite = Console.ReadLine();

                if (openWebsite == "Facebook")
                {
                    salary -= 150;
                }
                else if (openWebsite == "Instagram")
                {
                    salary -= 100;
                }
                else if (openWebsite == "Reddit")
                {
                    salary -= 50;
                }   
                if (salary <= 0) { break; }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else if (salary > 0)
            {
                Console.WriteLine($"{(int)salary}");
            }
        }
    }
}