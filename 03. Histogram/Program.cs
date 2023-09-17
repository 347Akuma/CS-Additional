namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;


            int n = int.Parse(Console.ReadLine());

            int num;

            for (int index = 1; index <= n; index++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }


            Console.WriteLine($"{(double)p1 / n * 100:F2}%"); // forcing the numbers to be read as "double" for the sake of the division, otherwise they are read as 0
            Console.WriteLine($"{(double)p2 / n * 100:F2}%"); // we only need our integers to be transformed into "double" here
            Console.WriteLine($"{(double)p3 / n * 100:F2}%");
            Console.WriteLine($"{(double)p4 / n * 100:F2}%");
            Console.WriteLine($"{(double)p5 / n * 100:F2}%");

        }
    }
}