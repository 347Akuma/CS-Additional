namespace _2._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0; // this variable contains the sum of the numbers
            int max = int.MinValue; // this variable keeps the greatest number

            for (int i = 1; i <= n; i++) // we loop n amount of times
            {
                int num = int.Parse(Console.ReadLine()); // this will keep the n-amount if inputs

                sum += num; // the input gets added to the sum variable outside the loop

                if (num > max) // we will always enter this check, the first input will become the greatest number, the rest will be compared to it
                {
                    max = num;
                }
            }
            int sumWithoutMaxNum = sum - max; // we get the sum of numbers without the greatest one
            if (max == sumWithoutMaxNum) // we check if the max number equals the above sum
            {
                Console.WriteLine("Yes"); // if yes, they're equal -> Print
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                double diff = Math.Abs(max - sumWithoutMaxNum); // if they're not, we create a variable for the difference -> Print
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}