namespace Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        Console.WriteLine($"{h:D2}:{m:D2}:{s:D2}"); // D2 operators make it an actual clock, but judge wont take it
                        Thread.Sleep(1000);
                    }
                }

            }
        }
    }
}