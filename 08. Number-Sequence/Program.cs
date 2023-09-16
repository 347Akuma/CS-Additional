namespace _08._Number_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Default value:
            // Sum -> 0 (A + 0 = A)
            // Product -> 1 (A * 1 = A)
            // MaxNumber -> Lowest possible value (A > Lowest Possible Value = true)
            // MinNumber -> Greatest possible value (A < Greatest Possible Value = true)



            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
                if (currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}