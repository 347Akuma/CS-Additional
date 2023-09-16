namespace _03._Numbers_1_To_N_3_Step
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}