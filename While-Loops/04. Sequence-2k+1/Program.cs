namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            while (currentNum <= n)
            {
                Console.WriteLine(currentNum); // we print first so we don't miss 1
                currentNum *= 2; // once we have 1, we start calculating
                currentNum++;
            }
        }
    }
}