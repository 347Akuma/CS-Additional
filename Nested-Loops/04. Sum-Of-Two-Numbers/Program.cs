namespace _04._Sum_Of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());

            int combCounter = 0;

            bool isFound = false;

            int i = 0;
            int j = 0;

            for (i = start; i <= end; i++)
            {
                for (j = start; j <= end; j++)
                {
                    combCounter++;
                    if (i + j == target)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                    break;
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{combCounter} ({i} + {j} = {target})");
            }
            else
            {
                Console.WriteLine($"{combCounter} combinations - neither equals {target}");
            }
        }
    }
}