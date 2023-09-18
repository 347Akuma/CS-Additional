namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accountTotal = 0;

            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                accountTotal += money;
                Console.WriteLine($"Increase: {money:f2}");   
            }
            Console.WriteLine($"Total: {accountTotal:f2}");
        }
    }
}