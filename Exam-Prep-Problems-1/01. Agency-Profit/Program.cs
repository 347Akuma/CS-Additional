namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string agencyName = Console.ReadLine();
            int adultTicketsCount = int.Parse(Console.ReadLine());
            int childTicketsCount = int.Parse(Console.ReadLine());
            double netAdultTicket = double.Parse(Console.ReadLine());
            double serviceCharge = double.Parse(Console.ReadLine());

            double netChildTicket = netAdultTicket - (netAdultTicket * 0.70);

            double adultTicketCharge = netAdultTicket + serviceCharge;
            double childTicketCharge = netChildTicket + serviceCharge;

            double totalTicketsPrice = (childTicketsCount * childTicketCharge) + (adultTicketCharge * adultTicketsCount);

            double totalProfit = totalTicketsPrice - (totalTicketsPrice * 0.80);

            Console.WriteLine($"The profit of your agency from {agencyName} tickets is {totalProfit:f2} lv.");
        }
    }
}