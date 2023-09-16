namespace _04._Even_Powers_Of_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            for (double i = n; i % 2 == 0; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
