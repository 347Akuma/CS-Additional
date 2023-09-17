namespace _04._Clever_lily
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // read console input - age, waching machine price, single toy price
            int lilyAge = int.Parse(Console.ReadLine());
            double wMachinePrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());

            int moneySaved = 0; // keep savings from each birthday

            // loop from the first to the last birthday
            for (int i = 1; i <= lilyAge; i++)
            {
                // check if current birthday is odd or even
                if (i % 2 == 0)  // even -> money
                {
                    moneySaved += i * 5 - 1; // moneySaved = moneySaved+ i (lilys age) * 5 - 1 (1 lev stolen each time)
                }
                else // odd -> toys
                {
                    moneySaved += singleToyPrice; // lily gets a toy which she sells for P amount, so we add it to the saved money
                }
            }
            // check if lily can afford the machine
            if (moneySaved >= wMachinePrice) 
            {
                Console.WriteLine($"Yes! {moneySaved - wMachinePrice:f2}"); // yes -> print positive remainder
            }
            else
            {
                Console.WriteLine($"No! {wMachinePrice - moneySaved:f2}"); // no -> print negative remainder
            }
        }
    }
}