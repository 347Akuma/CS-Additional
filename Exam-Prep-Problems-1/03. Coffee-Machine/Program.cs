namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine();
            string sugarChoice = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double drinkPrice = 0;

            switch (drinkType)
            {
                case "Espresso":
                    if (sugarChoice == "Without")
                    {
                        drinkPrice = (0.90 * drinksCount) * 0.65;
                    }
                    else if (sugarChoice == "Normal")
                    {
                        drinkPrice = 1.00 * drinksCount;
                    }
                    else if (sugarChoice == "Extra")
                    {
                        drinkPrice = 1.20 * drinksCount;
                    }
                    if (drinksCount >= 5)
                    {
                        drinkPrice *= 0.75;
                    }
                    break;
                case "Cappuccino":
                    if (sugarChoice == "Without")
                    {
                        drinkPrice = (1.00 * drinksCount) * 0.65;
                    }
                    else if (sugarChoice == "Normal")
                    {
                        drinkPrice = 1.20 * drinksCount;
                    }
                    else if (sugarChoice == "Extra")
                    {
                        drinkPrice = 1.60 * drinksCount;
                    }
                    break;
                case "Tea":
                    if (sugarChoice == "Without")
                    {
                        drinkPrice = (0.50 * drinksCount) * 0.65;
                    }
                    else if (sugarChoice == "Normal")
                    {
                        drinkPrice = 0.60 * drinksCount;
                    }
                    else if (sugarChoice == "Extra")
                    {
                        drinkPrice = 0.70 * drinksCount;
                    }
                    break;
            }
            if (drinkPrice > 15.00)
            {
                drinkPrice *= 0.80;
            }
            Console.WriteLine($"You bought {drinksCount} cups of {drinkType} for {drinkPrice:F2} lv.");
        }
    }
}